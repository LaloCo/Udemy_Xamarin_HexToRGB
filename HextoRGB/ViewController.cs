using System;

using UIKit;

namespace HextoRGB
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			convertButton.TouchUpInside += ConvertButton_TouchUpInside;
		}

		void ConvertButton_TouchUpInside (object sender, EventArgs e)
		{
			string hexValue = hexValueTextField.Text;

			try
			{
			string redHexValue = hexValue.Substring (0, 2);
			string greenHexValue = hexValue.Substring (2, 2);
			string blueHexValue = hexValue.Substring (4, 2);

			int redValue = int.Parse (redHexValue, System.Globalization.NumberStyles.HexNumber);
			int greenValue = int.Parse (greenHexValue, System.Globalization.NumberStyles.HexNumber);
			int blueValue = int.Parse (blueHexValue, System.Globalization.NumberStyles.HexNumber);

			redValueLabel.Text = redValue.ToString ();
			greenValueLabel.Text = greenValue.ToString ();
			blueValueLabel.Text = blueValue.ToString ();

			colorView.BackgroundColor = UIColor.FromRGB (redValue, greenValue, blueValue);
			}
			catch(ArgumentOutOfRangeException)
			{
				// string's lenght was less than 6
			}
			catch(FormatException)
			{
				// String had something different than 0-9 or A-F
			}
			catch(Exception ex)
			{
				// something different
				Console.WriteLine(ex.Message);
			}
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

