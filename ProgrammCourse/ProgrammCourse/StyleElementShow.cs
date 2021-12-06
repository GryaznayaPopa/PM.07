using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ProgrammCourse
{
    class StyleElementShow : IValueConverter
    {
   
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value == "Оплачено" ?
            new SolidColorBrush(Colors.Green) :
            new SolidColorBrush(Colors.White);
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
