using System;
using System.Globalization;
using Xamarin.Forms;

namespace DumbStock.RR.Converters
{
    public class PercentageConverter : IValueConverter
    {
        public PercentageConverter()
        {
        }

        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            return ((double)value).ToString("P");
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            return double.Parse(value.ToString().Replace("%", "")) / 100;
        }
    }
}
