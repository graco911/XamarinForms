using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.Interfaces;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(App1.iOS.PlatformInfo))]

namespace App1.iOS
{
    public class PlatformInfo : IPlatformInfo
    {
        UIDevice device = new UIDevice();
        public string GetModel()
        {
            return device.Model.ToString();
        }

        public string GetVersion()
        {
            return string.Format("{0} {1}", device.SystemName, device.SystemVersion);
        }
    }
}