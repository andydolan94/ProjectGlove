using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace ProjectGlove
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new ProjectGlove.MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("android=9abdcd14-b353-404f-b455-95ddbb149fa5;"
                            + "uwp=4ca0cedc-338a-4182-85d1-18a7a2c430f7;"
                            + "ios=7e59dde8-3cb9-4f56-b2dd-a50224f2af5b",
                            typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
