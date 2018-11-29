using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(App1.Droid.PlatformInfo))]

namespace App1.Droid
{
    public class PlatformInfo : IPlatformInfo
    {
        public string GetModel()
        {
            return string.Format("{0} {1}", Build.Manufacturer, Build.Model);
        }

        public string GetVersion()
        {
            return Build.VERSION.Release.ToString();
        }
    }
}