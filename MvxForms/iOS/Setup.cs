using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.iOS;
using MvvmCross.Forms.Platform;
using MvvmCross.iOS.Platform;
using UIKit;

namespace MvxForms.iOS {
	public class Setup : MvxFormsIosSetup {
		public Setup ( IMvxApplicationDelegate applicationDelegate, UIWindow window )
			: base ( applicationDelegate, window ) {
		}

		protected override IEnumerable<Assembly> GetViewAssemblies () {
			return new List<Assembly> ( base.GetViewAssemblies ().Union ( new[] { typeof ( MvxForms.App ).GetTypeInfo ().Assembly } ) );
		}

		protected override MvxFormsApplication CreateFormsApplication () => new MvxForms.App ();

		protected override IMvxApplication CreateApp () => new MvxForms.CoreApp ();
	}
}