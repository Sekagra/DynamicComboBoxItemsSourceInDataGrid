using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows;
using DynamicComboBoxItemsSourceInDataGrid.Model;

namespace DynamicComboBoxItemsSourceInDataGrid.Converter
{
    class OwnerItemsSourceConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] == null || values[0].Equals(DependencyProperty.UnsetValue))
                return null;
            else if ((OwnerType)values[0] == OwnerType.USER)
                return values[1];
            else if ((OwnerType)values[0] == OwnerType.GROUP)
                return values[2];

            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
