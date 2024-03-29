﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ApexStats.View.Converters
{
    internal class PercentileToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return "Bottom 0%";

            float percentile = (float)value;
            return percentile <= 50 ? $"Bottom {percentile}%" : $"Top {100.0f - percentile}%";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
