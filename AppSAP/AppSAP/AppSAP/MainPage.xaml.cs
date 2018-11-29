using Xamarin.Forms;

#if __IOS__

using UIKit;

#elif __ANDROID__

using Android.OS;

#endif

namespace AppSAP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

#if __IOS__
            UIDevice device = new UIDevice();
            modelLabel.Text = device.Model.ToString();
            versionLabel.Text = string.Format("{0} {1}", device.SystemName, device.SystemVersion);
#elif __ANDROID__
            modelLabel.Text = string.Format("{0} {1}", Build.Manufacturer, Build.Model);
            versionLabel.Text = Build.VERSION.Release.ToString();
#endif
        }
    }
}
