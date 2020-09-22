namespace JpkEdytor.Converters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    /// <summary>
    /// Checks is a given <see cref="string"/> is null or empty and returns boolean.
    /// </summary>
    public class IsStringNullOrEmptyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return true;

            var valueStr = value as string;

            return string.IsNullOrEmpty(valueStr);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
