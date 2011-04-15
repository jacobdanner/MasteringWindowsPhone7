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
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructor
		public MainPage()
		{
			InitializeComponent();

			this.ManipulationStarted += new EventHandler<ManipulationStartedEventArgs>(MainPage_ManipulationStarted);
			this.ManipulationCompleted += new EventHandler<ManipulationCompletedEventArgs>(MainPage_ManipulationCompleted);
		}

		void MainPage_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
		{
			Debug.WriteLine("MainPage_ManipulationCompleted");
		}

		void MainPage_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
		{
			Debug.WriteLine("MainPage_ManipulationStarted");

		}

		private void MyButton_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
		{
			Debug.WriteLine("MyButton_ManipulationStarted");
			e.Complete();
		}

		private void MyButton_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
		{
			Debug.WriteLine("MyButton_ManipulationCompleted");
		}

		private void MyButton_Click(object sender, RoutedEventArgs e)
		{
			Debug.WriteLine("MyButton_Click");
		}

		private void MyButton_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
		{
			myTransform.TranslateX = e.CumulativeManipulation.Translation.X;
			myTransform.TranslateY = e.CumulativeManipulation.Translation.Y;
		}
	}
}