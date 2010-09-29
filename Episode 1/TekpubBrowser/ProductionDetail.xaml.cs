namespace TekpubBrowser
{
	using System.Windows.Input;
	using System.Windows.Navigation;
	using Microsoft.Phone.Controls;
	using Microsoft.Phone.Shell;

	public partial class ProductionDetail : PhoneApplicationPage
	{
		public ProductionDetail()
		{
			InitializeComponent();
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			var slug = NavigationContext.QueryString["slug"];
			DataContext = PhoneApplicationService.Current.State[slug];

			base.OnNavigatedTo(e);
		}

		void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (NavigationService.CanGoBack) NavigationService.GoBack();
		}
	}
}