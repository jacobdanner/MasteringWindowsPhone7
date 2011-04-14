using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Diagnostics;

namespace PageOrientationExample
{
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructor
		public MainPage()
		{
			InitializeComponent();

			DataContext = Enumerable.Range(500, 50);
		}

		protected override void OnOrientationChanged(OrientationChangedEventArgs e)
		{
			PageTitle.Text = e.Orientation.ToString();

			var w = LayoutRoot.ActualWidth;
			var h = LayoutRoot.ActualHeight;
			Debug.WriteLine(string.Format("h {0}, w {1}", w, h));

			if ((e.Orientation & PageOrientation.Landscape) != 0)
			{
				NumList.FontSize = 24;
			}
			else
			{
				NumList.FontSize = 48;
			}
			base.OnOrientationChanged(e);
		}
	}
}