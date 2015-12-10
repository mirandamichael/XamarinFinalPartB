using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace androidApplicationFinal
{
	[Activity (Label = "Simple Calculator", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			Xamarin.Insights.Initialize (XamarinInsights.ApiKey, this);
			base.OnCreate (savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			// Get our button from the layout resource,
			// and attach an event to it
			Button plus = FindViewById<Button> (Resource.Id.addition);
			Button minus = FindViewById<Button> (Resource.Id.subtraction);
			Button divide = FindViewById<Button> (Resource.Id.division);
			Button mult = FindViewById<Button> (Resource.Id.multiplication);

			TextView resultsView = FindViewById<TextView> (Resource.Id.resultTextView);
			EditText num1 = FindViewById<EditText> (Resource.Id.number1);
			EditText num2 = FindViewById<EditText> (Resource.Id.number2);
			plus.Click += delegate {
				resultsView.Text = "";
				if (num1.Text != "" && num2.Text != "") {
					int result = Convert.ToInt32 (num1.Text) + Convert.ToInt32 (num2.Text);
					string results = "" + result;
					resultsView.Text = results;
				}
			};
			minus.Click += delegate {
				resultsView.Text = "";
				if (num1.Text != "" && num2.Text != "") {
					int result = Convert.ToInt32 (num1.Text) - Convert.ToInt32 (num2.Text);
					string results = "" + result;
					resultsView.Text = results;
				}
			};
			divide.Click += delegate {
				resultsView.Text = "";
				if (num1.Text != "" && num2.Text != "" && num2.Text != "0") {
					int result = Convert.ToInt32 (num1.Text) / Convert.ToInt32 (num2.Text);
					string results = "" + result;
					resultsView.Text = results;
				}
			};
			mult.Click += delegate {
				resultsView.Text = "";
				if (num1.Text != "" && num2.Text != "") {
					int result = Convert.ToInt32 (num1.Text) * Convert.ToInt32 (num2.Text);
					string results = "" + result;
					resultsView.Text = results;
				}
			};
		}
	}

}
