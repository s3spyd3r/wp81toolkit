﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace winRTtoolkit.Converters
{
    public class NullReverseToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value == null ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}
