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

namespace TouchExample
{
	public partial class LowLevel : PhoneApplicationPage
	{
		public LowLevel()
		{
			InitializeComponent();

			Touch.FrameReported += new TouchFrameEventHandler(Touch_FrameReported);
		}

		void Touch_FrameReported(object sender, TouchFrameEventArgs e)
		{
			var points = e.GetTouchPoints();
			var first = points.First();

		}
	}
}