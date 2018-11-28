using App1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App1
{
    public partial class App : Application
    {
        //const string displayLabelText = "displayLabelText";

        public string DisplayLabelText { get; set; }

        public App()
        {
            //if (Properties.ContainsKey(displayLabelText))
            //{
            //    DisplayLabelText = (string)Properties[displayLabelText];
            //}

            MainPage = new MonkeyTap();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            //Properties[displayLabelText] = DisplayLabelText;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
