namespace BindingSample
{
	using System.Windows;
	using Microsoft.Phone.Controls;

	public partial class SilverlightWay : PhoneApplicationPage
	{
		public SilverlightWay()
		{
			InitializeComponent();
		}

		void Window_Loaded(object sender, RoutedEventArgs e)
		{
			DataContext = PersonFactory.New();
		}
	}
}