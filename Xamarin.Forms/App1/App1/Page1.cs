using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            //Label label = new Label();
            //label.Text = "Greetings, Xamarin.Forms!";
            //this.Content = label;

            //Label label = new Label
            //{
            //    Text = "Greetings, Xamarin.Forms!"
            //};

            //this.Content = label;

            Content = new Label
            {
                Text = "Greetings, Xamarin.Forms!"
            };
        }
    }
}