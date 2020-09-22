namespace JpkEdytor.Converters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    /// <summary>
    /// Converts nullable <see cref="Enum"/> value to <see cref="string"/> value and vice versa.
    /// </summary>
    public class NullableEnumToStringConverter : IValueConverter
    {
        public static string NullEnumStringValue => "";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value ?? NullEnumStringValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var valueStr = value.ToString();
            var enumType = Nullable.GetUnderlyingType(targetType);

            return valueStr != NullEnumStringValue
                ? System.Convert.ChangeType(Enum.Parse(enumType, valueStr), enumType)
                : null;
        }
    }
}
