namespace JpkEdytor.Helpers.CsvImporter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Stores CSV column mappings for certain types.
    /// </summary>
    public sealed class CsvImporterColumnMap
    {
        private readonly Dictionary<Type, List<Expression>> map = 
            new Dictionary<Type, List<Expression>>();

        /// <summary>
        /// Adds a property to a CSV column mapping.
        /// </summary>
        /// <typeparam name="TSource">A source object type.</typeparam>
        /// <typeparam name="TProperty">A property of the source object.</typeparam>
        /// <param name="propertyLambda">Lambda expression accessing a property or a nested property.</param>
        public void AddCsvColumnMapping<TSource, TProperty>(Expression<Func<TSource, TProperty>> propertyLambda)
        {
            var type = typeof(TSource);

            if (!map.ContainsKey(type))
                map.Add(type, new List<Expression>());

            map[type].Add(propertyLambda);
        }

        /// <summary>
        /// Gets CSV column mappings for all types.
        /// </summary>
        /// <returns>Collection of lambda expression accessing a property or a nested property.</returns>
        public List<Expression> GetCsvColumnMappings()
        {
            return map.SelectMany(s => s.Value).ToList();
        }

        /// <summary>
        /// Gets CSV column mappings for a given type.
        /// </summary>
        /// <param name="type">A type to get mappings for.</param>
        /// <returns>Collection of lambda expression accessing a property or a nested property.</returns>
        public List<Expression> GetCsvColumnMappings(Type type)
        {
            return map.ContainsKey(type) 
                ? map[type] 
                : new List<Expression>();
        }

        /// <summary>
        /// Gets CSV column mappings for a given type.
        /// </summary>
        /// <typeparam name="T">A type to get mappings for.</typeparam>
        /// <returns>Collection of lambda expression accessing a property or a nested property.</returns>
        public List<Expression> GetCsvColumnMappings<T>()
        {
            return GetCsvColumnMappings(typeof(T));
        }
    }
}
