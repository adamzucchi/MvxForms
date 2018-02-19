using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmCross.Forms.Droid.Views;
using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;

namespace MvxForms.Droid {
	[Activity ( Label = "MvvmcrossGettingStarted", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation )]
	public class MainActivity : MvxFormsAppCompatActivity<MainViewModel>
//global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
{
		protected override void OnCreate ( Bundle bundle ) {
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate ( bundle );

			var startup = Mvx.Resolve<IMvxAppStart> ();
			startup.Start ();
			InitializeForms ( bundle );

		}
	}
}
