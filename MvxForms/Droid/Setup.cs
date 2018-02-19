using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Droid.Platform;
using MvvmCross.Forms.Platform;

namespace MvxForms.Droid {
	public class Setup : MvxFormsAndroidSetup {
		public Setup ( Context applicationContext ) : base ( applicationContext ) {
		}

		protected override IEnumerable<Assembly> GetViewAssemblies () {
			return new List<Assembly> ( base.GetViewAssemblies ()
			                           .Union ( new[] { typeof ( MvxForms.App ).GetTypeInfo ().Assembly } )
				.Except ( new[] { this.GetType ().Assembly } )
				);
		}

		protected override MvxFormsApplication CreateFormsApplication () => new MvxForms.App ();

		protected override IMvxApplication CreateApp () => new MvxForms.CoreApp ();
	}
}