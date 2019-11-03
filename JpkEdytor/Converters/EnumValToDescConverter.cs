namespace JpkEdytor.Converters
{
    using System;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Data;

    /// <summary>
    /// Converts <see cref="Enum"/> value to a <see cref="DescriptionAttribute"/> 
    /// value if this <see cref="Enum"/> value is marked with one.
    /// </summary>
    public class EnumValToDescConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = value.GetType();
            var descAttr = type.GetField(value.ToString())
                ?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault() as DescriptionAttribute;

            var desc = descAttr?.Description;

            return string.IsNullOrEmpty(desc) ? value.ToString() : desc;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
