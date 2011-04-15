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

namespace TouchExample
{
	public partial class TwoButtons : PhoneApplicationPage
	{
		public TwoButtons()
		{
			InitializeComponent();
		}

		private void StackPanel_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
		{
			var element = e.OriginalSource as FrameworkElement;
			Debug.WriteLine( element.Name );
		}
	}
}