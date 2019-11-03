namespace JpkEdytor.Models.Attributes
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class CsvField : Attribute
    {
        public int Order { get; private set; }

        public string ColumnName { get; private set; }

        public CsvField([CallerLineNumber]int order = 0, [CallerMemberName]string columnName = null)
        {
            Order = order;
            ColumnName = columnName;
        }
    }
}
