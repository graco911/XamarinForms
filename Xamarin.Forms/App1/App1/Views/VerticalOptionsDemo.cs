using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace App1.Views
{
    public class VerticalOptionsDemo : ContentPage
    {
        public VerticalOptionsDemo()
        {
            Color[] colors = { Color.Yellow, Color.Blue };
            int flipFlopper = 0;

            IEnumerable<Label> labels =
                from field in typeof(LayoutOptions).GetRuntimeFields()
                where field.IsPublic && field.IsStatic
                orderby ((LayoutOptions)field.GetValue(null)).Alignment
                select new Label
                {
                    Text = "VerticalOptions = " + field.Name,
                    VerticalOptions = (LayoutOptions)field.GetValue(null),
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    TextColor = colors[flipFlopper],
                    BackgroundColor = colors[flipFlopper = 1 - flipFlopper]
                };

            StackLayout stackLayout = new StackLayout();

            foreach (Label label in labels)
            {
                stackLayout.Children.Add(label);
            }

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(5, 20, 5, 5);
                    break;
                case Device.Android:
                    Padding = new Thickness(5);
                    break;
            }

            Content = stackLayout;
        }
    }
}