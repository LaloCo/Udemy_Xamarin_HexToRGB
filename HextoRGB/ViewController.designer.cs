// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HextoRGB
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel blueValueLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView colorView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton convertButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel greenValueLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField hexValueTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel redValueLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (blueValueLabel != null) {
				blueValueLabel.Dispose ();
				blueValueLabel = null;
			}
			if (colorView != null) {
				colorView.Dispose ();
				colorView = null;
			}
			if (convertButton != null) {
				convertButton.Dispose ();
				convertButton = null;
			}
			if (greenValueLabel != null) {
				greenValueLabel.Dispose ();
				greenValueLabel = null;
			}
			if (hexValueTextField != null) {
				hexValueTextField.Dispose ();
				hexValueTextField = null;
			}
			if (redValueLabel != null) {
				redValueLabel.Dispose ();
				redValueLabel = null;
			}
		}
	}
}
