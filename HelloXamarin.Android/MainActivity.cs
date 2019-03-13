using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace HelloXamarin.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private int counter = 0;
        private Button myButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.activity_main);

            this.myButton = this.FindViewById<Button>(Resource.Id.myButton);
            this.myButton.Click += this.MyButton_Click;
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            this.counter++;
            this.myButton.Text = $"Clicked {this.counter}";
        }
    }
}