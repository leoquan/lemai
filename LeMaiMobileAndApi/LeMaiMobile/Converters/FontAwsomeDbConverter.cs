using LeMaiDto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace LeMaiMobile.Converters
{
    internal class FontAwsomeDbConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string strDb && !string.IsNullOrWhiteSpace(strDb))
            {
                try
                {
                    return ((char)System.Convert.ToUInt16(strDb.Substring(2), 16)).ToString();
                }
                catch { }
            }

            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
