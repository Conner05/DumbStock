using System;
using System.Globalization;
using Xamarin.Forms;

namespace DumbStock.RR.Converters
{
    public class MoneyConverter : IValueConverter
    {
        public MoneyConverter()
        {
        }

        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            return ((double)value).ToString("C");
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            return double.Parse(value.ToString().Replace("$", ""));
        }
    }
}
