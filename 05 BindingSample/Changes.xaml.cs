namespace BindingSample
{
	using System.Windows;
	using Microsoft.Phone.Controls;

	public partial class Changes : PhoneApplicationPage
	{
		Person someone;

		public Changes()
		{
			InitializeComponent();

			Loaded += delegate
			          	{
			          		someone = PersonFactory.New();
			          		DataContext = someone;
			          	};
		}

		void Button_Click(object sender, RoutedEventArgs e)
		{
			someone.FirstName = "Jemaine";
			someone.LastName = "Clement ";
			someone.HasAClue = true;
		}
	}
}