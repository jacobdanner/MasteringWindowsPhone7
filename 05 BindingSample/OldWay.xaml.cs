namespace BindingSample
{
	using System.Windows;
	using Microsoft.Phone.Controls;

	public partial class OldWay : PhoneApplicationPage
	{
		public OldWay()
		{
			InitializeComponent();
		}

		void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var person = PersonFactory.New();

			firstName.Text = person.FirstName;
			lastName.Text = person.LastName;

			firstName.TextChanged += delegate { person.FirstName = firstName.Text; };
			lastName.TextChanged += delegate { person.LastName = lastName.Text; };
		}
	}
}