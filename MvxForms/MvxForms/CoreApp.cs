using System;
using MvvmCross.Core.ViewModels;

namespace MvxForms {
	public class CoreApp : MvxApplication {
		public override void Initialize () {
			RegisterNavigationServiceAppStart<MainViewModel> ();
		}
	}
}