using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace PierwszaAplikacjaMVVM
{
    public class DoubleToBrushConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double d = (double)value;
            double r = d > 127 ? 255 : 2 * d;
            double g = d < 127 ? 255 : 255- 2 * (d-127.7);
            Color c = Color.FromRgb((byte)r, (byte)g, (byte)0);
            return new SolidColorBrush(c);

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
