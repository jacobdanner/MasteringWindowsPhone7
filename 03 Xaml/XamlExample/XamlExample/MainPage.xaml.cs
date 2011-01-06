namespace XamlExample
{
	using System.Windows.Controls;
	using System.Windows.Media;
	using Microsoft.Phone.Controls;

	public partial class MainPage : PhoneApplicationPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		void CreateButton()
		{
			var button = new Button
			             	{
			             		Content = "Click Me",
			             		FontSize = 26,
			             		Height = 60,
			             		Width = 200,
								//Background = new SolidColorBrush(Colors.Green)
			             	};

			LayoutRoot.Children.Add(button);
		}
	}
}