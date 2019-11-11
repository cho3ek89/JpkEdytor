namespace JpkEdytor.Helpers.CsvImporter
{
    using Microsoft.VisualBasic.FileIO;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;

    /// <summary>
    /// A class for parsing CSV file.
    /// </summary>
    /// <remarks>
    /// CSV file must be <see cref="Encoding.UTF8"/> encoded.
    /// Cell delimiter in CSV file has to be ";" character.
    /// Fields containings special characters in the CSV file must be enclosed with quote characters.
    /// The CSV file must not have a header row (the row with column names).
    /// </remarks>
    public static class CsvImporter
    {
        /// <summary>
        /// Parses CSV file.
        /// </summary>
        /// <typeparam name="T">The type of object each CSV line has to be parsed to.</typeparam>
        /// <param name="fullFilePath">Absolute file path to CSV file.</param>
        /// <returns>Collection of <typeparamref name="T"/> objects.</returns>
        /// <remarks>
        /// Number and order of columns in the CSV file must be in line with the number and order 
        /// of properties mapped for <typeparamref name="T"/> type in <see cref="CsvImporterColumnMapFactory"/>.
        /// </remarks>
        /// <seealso cref="CsvImporterColumnMapFactory"/>
        public static IEnumerable<T> GetCollectionFromCsv<T>(string fullFilePath)
            where T : class, new()
        {
            var csvColumnMap = CsvImporterColumnMapFactory.GetCsvImporterColumnMap<T>();
            return GetCollectionFromCsv<T>(fullFilePath, csvColumnMap);
        }

        /// <summary>
        /// Parses CSV file.
        /// </summary>
        /// <typeparam name="T">The type of object each CSV line has to be parsed to.</typeparam>
        /// <param name="fullFilePath">Absolute file path to CSV file.</param>
        /// <param name="csvColumnMap">A custom column map, it should contain mappings for <typeparamref name="T"/> type.</param>
        /// <returns>Collection of <typeparamref name="T"/> objects.</returns>
        /// <remarks>
        /// Number and order of columns in the CSV file must be in line with the number and order 
        /// of properties mapped for <typeparamref name="T"/> type in <paramref name="csvColumnMap"/>.
        /// </remarks>
        /// <seealso cref="CsvImporterColumnMap"/>
        public static IEnumerable<T> GetCollectionFromCsv<T>(string fullFilePath, CsvImporterColumnMap csvColumnMap) 
            where T : class, new()
        {
            using (var parser = new TextFieldParser(fullFilePath, new UTF8Encoding(), true))
            {
                parser.HasFieldsEnclosedInQuotes = true;
                parser.TextFieldType = FieldType.Delimited;
                parser.TrimWhiteSpace = true;
                parser.SetDelimiters(";");

                var csvColumns = csvColumnMap.GetCsvColumnMappings<T>();

                while (!parser.EndOfData)
                {
                    var fields = parser.ReadFields();
                    var obj = new T();

                    int count = 0;
                    foreach (var csvColumn in csvColumns)
                    {
                        var field = fields[count++];

                        SetProperty(csvColumn, obj, field);
                    }
                    
                    yield return obj;
                }
            }
        }

        /// <summary>
        ///  Sets the property value of a specified object.
        /// </summary>
        /// <param name="propertyLambda">Lambda expression accessing a property or a nested property of <paramref name="target"/>.</param>
        /// <param name="target">The object whose property value will be set.</param>
        /// <param name="value">The new property value.</param>
        private static void SetProperty(Expression propertyLambda, object target, string value)
        {
            var lambdaParts = ((LambdaExpression)propertyLambda).Body.ToString().Split('.').Skip(1).ToArray();
            for (var i = 0; i < lambdaParts.Length - 1; i++)
            {
                var property = target.GetType().GetProperty(lambdaParts[i]);
                target = property.GetValue(target, null);
            }

            if (!lambdaParts.Any()) return;

            var propertyToSet = target.GetType().GetProperty(lambdaParts.Last());
            propertyToSet.SetValue(target, GetValueToSet(value, propertyToSet.PropertyType), null);
        }

        /// <summary>
        /// Converts given string value to a given type.
        /// </summary>
        /// <param name="value">String value to parse.</param>
        /// <param name="type">Type which <paramref name="value"/> will be converted to.</param>
        /// <returns>Converted string value.</returns>
        private static object GetValueToSet(string value, Type type)
        {
            var valueToSet = type.IsEnum
                ? Enum.Parse(type, value)
                : Convert.ChangeType(value, type);

            return valueToSet;
        }
    }
}
