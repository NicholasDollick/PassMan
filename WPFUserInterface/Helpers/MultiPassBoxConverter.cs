using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFUserInterface.Helpers
{
    class MultiPassBoxConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.Clone();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            // this should never happen
            throw new NotImplementedException();
        }
    }
}
