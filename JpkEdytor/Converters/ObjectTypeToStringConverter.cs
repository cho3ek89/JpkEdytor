namespace JpkEdytor.Converters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class ObjectTypeToStringConverter : IValueConverter
    {
        /// <summary>
        /// Converts an object to its type name.
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.GetType().Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
