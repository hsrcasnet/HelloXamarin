using System;
using UIKit;

namespace HelloXamarin.iOS
{
    public partial class ViewController : UIViewController
    {
        private int counter = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.myButton.TouchUpInside += this.MyButtonOnTouchUpInside;
        }

        private void MyButtonOnTouchUpInside(object sender, EventArgs e)
        {
            this.counter++;
            this.myButton.SetTitle($"Clicked {this.counter}", UIControlState.Normal);
        }
    }
}