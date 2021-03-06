﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace XCMDEMO.Converters
{
    public class YesNotBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return "T";
            return "F";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((string)value == "T")
                return true;
            return false;
        }
    }
}