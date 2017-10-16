using System;

using UIKit;

namespace HexConvertedRGB
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            //this calls on an event when the button is pushed
            convertButton.TouchUpInside += ConvertButton_TouchUpInside;
        }

        //this is the event that is called
        void ConvertButton_TouchUpInside(object sender, EventArgs e)
        {
			//this takes the hex value inputed and converts it to an RGB, and stores it as a string
			string hexValue = hexValueTextField.Text;
			string redHexValue = hexValue.Substring(0, 2);
			string greenHexValue = hexValue.Substring(2, 2);
			string blueHexValue = hexValue.Substring(4, 2);

            //this takes the RGB string and turns into into numbers and stores it
			int redValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
			int greenValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
			int blueValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);


            //this takes the stored numbers and puts them in the label 
			redValueLabel.Text = redValue.ToString();
			greenValueLabel.Text = greenValue.ToString();
			blueValueLabel.Text = blueValue.ToString();

			//this grabs the view box, and colours it according the rgb value
            colorView.BackgroundColor = UIColor.FromRGB(redValue, greenValue, blueValue);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}
