using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1.Views
{
    public class StackLayoutColors : ContentPage
    {
        public StackLayoutColors()
        {
            Color[] colors =
            {
             Color.White, Color.Silver, Color.Gray, Color.Black, Color.Red,
             Color.Maroon, Color.Yellow, Color.Olive, Color.Lime, Color.Green,
             Color.Aqua, Color.Teal, Color.Blue, Color.Navy, Color.Pink,
             Color.Fuchsia, Color.Purple
            };            string[] colorNames =
            {
             "White", "Silver", "Gray", "Black", "Red",
             "Maroon", "Yellow", "Olive", "Lime", "Green",
             "Aqua", "Teal", "Blue", "Navy", "Pink",
             "Fuchsia", "Purple"
            };            StackLayout stackLayout = new StackLayout();

            for (int i = 0; i < colors.Length; i++)
            {
                Label label = new Label
                {
                    Text = colorNames[i],
                    TextColor = colors[i],
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                };

                stackLayout.Children.Add(label);
            }
            Content = stackLayout;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(10, 20, 10, 10);
                    break;
                case Device.Android:
                    Padding = new Thickness(20);
                    break;
            }
        }
    }
}