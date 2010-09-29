namespace TekpubBrowser
{
	using System;
	using System.Windows.Controls;
	using Microsoft.Phone.Controls;

	public partial class MainPage : PhoneApplicationPage
	{
		public MainPage()
		{
			InitializeComponent();

			DataContext = new[]
			              	{
			              		new Category {Name = "all"},
			              		new Category {Name = ".net"},
			              		new Category {Name = "ruby"},
			              		new Category {Name = "free"},
			              		new Category {Name = "iphone"},
			              		new Category {Name = "android"},
			              		new Category {Name = "tools"},
			              	};
		}

		void LoadingPivotItem(object sender, PivotItemEventArgs e)
		{
			var category = (Category) e.Item.DataContext;
			category.LoadProductions();
		}

		void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var listbox = (ListBox) sender;
			var production = (Production) listbox.SelectedItem;

			NavigationService.Navigate(new Uri("/ProductionDetail.xaml?slug=" + production.slug, UriKind.Relative));
		}
	}
}