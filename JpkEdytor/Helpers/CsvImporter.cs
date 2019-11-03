namespace JpkEdytor.Helpers
{
    using Microsoft.VisualBasic.FileIO;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Models.Attributes;

    /// <summary>
    /// A class for parsing CSV file.
    /// </summary>
    public static class CsvImporter
    {
        /// <summary>
        /// Parses CSV file.
        /// </summary>
        /// <typeparam name="T">The type of object each CSV line has to be parsed to.</typeparam>
        /// <param name="fullFilePath">Absolute file path to CSV file</param>
        /// <returns>Collection of <typeparamref name="T"/> objects</returns>
        /// <remarks>
        /// CSV file must be <see cref="Encoding.UTF8"/> encoded.
        /// Cell delimiter in CSV file has to be ";" character.
        /// Fields in the CSV file must be enclosed with quote characters.
        /// The CSV file must not have a header row (the row with column names).
        /// Number and order of columns in the CSV file must be in line with the number and order 
        /// of properties with <see cref="CsvField"/> attribute in <typeparamref name="T"/> type.
        /// </remarks>
        /// <seealso cref="CsvField"/>
        public static IEnumerable<T> GetCollectionFromCsv<T>(string fullFilePath) 
            where T : class, new()
        {
            using (var parser = new TextFieldParser(fullFilePath, new UTF8Encoding(), true))
            {
                parser.HasFieldsEnclosedInQuotes = true;
                parser.TextFieldType = FieldType.Delimited;
                parser.TrimWhiteSpace = true;
                parser.SetDelimiters(";");

                var properties = typeof(T)
                    .GetProperties()
                    .Where(w => w.GetCustomAttributes(typeof(CsvField), false).Any())
                    .OrderBy(o => ((CsvField)o.GetCustomAttributes(typeof(CsvField), false).First()).Order);

                while (!parser.EndOfData)
                {
                    var fields = parser.ReadFields();
                    var obj = new T();

                    int count = 0;
                    foreach (var property in properties)
                    {
                        var field = fields[count++];
                        var type = property.PropertyType;
                        var value = type.IsEnum
                            ? Enum.Parse(type, field)
                            : Convert.ChangeType(field, property.PropertyType);

                        property.SetValue(obj, value, null);
                    }
                    
                    yield return obj;
                }
            }
        }
    }
}
