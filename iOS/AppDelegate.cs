using System;
using System.Collections.Generic;
using System.Linq;
using EasyMath;


using Foundation;
using UIKit;

namespace EasyMath.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(0, 146, 255);
			UINavigationBar.Appearance.TintColor = UIColor.White;




			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new EasyMath.App());

			return base.FinishedLaunching(app, options);
		}
	}
}