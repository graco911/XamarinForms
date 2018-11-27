using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1.Views
{
    public class SizedBoxViewPage : ContentPage
    {
        public SizedBoxViewPage()
        {
            Content = new BoxView
            {
                Color = Color.Accent
            };
        }
    }
}