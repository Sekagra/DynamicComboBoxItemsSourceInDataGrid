using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using DynamicComboBoxItemsSourceInDataGrid.Model;

namespace DynamicComboBoxItemsSourceInDataGrid.Converter
{
    class TypeToDisplayPropertyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var __type = (OwnerType)value;
            if (__type == OwnerType.GROUP) return "Name";
            else if (__type == OwnerType.USER) return "Username";
            else return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
