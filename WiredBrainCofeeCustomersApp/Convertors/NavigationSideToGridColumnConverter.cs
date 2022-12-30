﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WiredBrainCofeeCustomersApp.Enums;

namespace WiredBrainCofeeCustomersApp.Convertors
{
    public class NavigationSideToGridColumnConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            var navigationSide = (NavigationSide) value;
            return navigationSide == NavigationSide.Left
                ? 0 //<-- Value for Grid.Column
                : 2;
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
