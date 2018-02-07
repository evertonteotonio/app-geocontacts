﻿using AwesomeContacts.Helpers;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Device = Xamarin.Forms.Device;

namespace AwesomeContacts
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new ContentPage());
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
			if ((Device.RuntimePlatform == Device.Android && CommonConstants.AppCenterAndroid != "AC_ANDROID") ||
				(Device.RuntimePlatform == Device.iOS && CommonConstants.AppCenteriOS != "AC_IOS") ||
				(Device.RuntimePlatform == Device.UWP && CommonConstants.AppCenterUWP != "AC_UWP"))
			{
				AppCenter.Start($"android={CommonConstants.AppCenterAndroid};" +
				   $"uwp={CommonConstants.AppCenterUWP};" +
				   $"ios={CommonConstants.AppCenteriOS}",
				   typeof(Analytics), typeof(Crashes), typeof(Distribute));
			}
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