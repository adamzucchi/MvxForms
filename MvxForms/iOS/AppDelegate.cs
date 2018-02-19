using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using MvvmCross.Forms.iOS;
using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;

namespace MvxForms.iOS {
	[Register ( "AppDelegate" )]
	public partial class AppDelegate : MvxFormsApplicationDelegate {

		public override bool FinishedLaunching ( UIApplication app, NSDictionary options ) {
			Window = new UIWindow ( UIScreen.MainScreen.Bounds );

			var setup = new Setup ( this, Window );
			setup.Initialize ();

			var startup = Mvx.Resolve<IMvxAppStart> ();
			startup.Start ();

			LoadApplication ( setup.FormsApplication );

			Window.MakeKeyAndVisible ();

			return base.FinishedLaunching ( app, options );
		}
	}
}
