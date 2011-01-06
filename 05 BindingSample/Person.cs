namespace BindingSample
{
	using System.ComponentModel;

	public class Person : INotifyPropertyChanged
	{
		string firstName;
		string lastName;
		bool hasAClue;

		public bool HasAClue
		{
			get { return hasAClue; }
			set { hasAClue = value; NotifyPropertyChanged("HasAClue"); }
		}
		
		public string FirstName
		{
			get { return firstName; }
			set
			{
				firstName = value;
				NotifyPropertyChanged("");
			}
		}
		public string LastName
		{
			get { return lastName; }
			set
			{
				lastName = value;
				NotifyPropertyChanged("");
			}
		}

		public string FullName
		{
			get { return string.Format("{0} {1}", FirstName, LastName); }
		}

		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		void NotifyPropertyChanged(string propertyName)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion
	}

	public static class PersonFactory
	{
		public static Person New()
		{
			return new Person { FirstName = "Zaphod", LastName = "Beeblebrox" };
		}
	}
}