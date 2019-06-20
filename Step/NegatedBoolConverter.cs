using System;
using System.Globalization;
using System.Windows.Data;

namespace MvvmByStep.Step
{
	public class NegatedBoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
			{
				return !((bool) value);
			}
			else
			{
				return Binding.DoNothing;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return this.Convert(value, targetType, parameter, culture);
		}
	}
}
