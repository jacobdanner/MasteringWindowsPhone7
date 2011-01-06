namespace BindingSample
{
	using System;
	using System.Globalization;
	using System.Windows;
	using System.Windows.Data;

	public class BooleanToVisibilityConverter : IValueConverter
	{
		#region IValueConverter Members

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var isVisible = (bool) value;
			return isVisible
			       	? Visibility.Visible
			       	: Visibility.Collapsed;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}