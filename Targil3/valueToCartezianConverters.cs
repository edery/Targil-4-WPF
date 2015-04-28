using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Targil4
{
  
        public class SinConverter : IValueConverter
        {
            

            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                try
                {
                    double angle = System.Convert.ToDouble(value);
                    double angleRad = Math.PI * angle / 180;
                    double radius = System.Convert.ToDouble(parameter);
                    return radius * Math.Sin(angleRad);
                }
                catch
                {
                    return Binding.DoNothing;
                }
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }

         
        }

        public class CosConverter : IValueConverter
        {


            object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }

            object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                try
                {
                    double angle = System.Convert.ToDouble(value);
                    double angleRad = Math.PI * angle / 180;
                    double radius = System.Convert.ToDouble(parameter);
                    return radius * Math.Cos(angleRad);
                }
                catch
                {
                    return Binding.DoNothing;
                }

            }
        }
}

