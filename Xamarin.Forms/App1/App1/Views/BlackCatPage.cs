using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace App1.Views
{
    public class BlackCatPage : ContentPage
    {
        public BlackCatPage()
        {
            StackLayout mainStack = new StackLayout();
            StackLayout textStack = new StackLayout
            {
                Padding = new Thickness(20),
                Spacing = 10
            };

            Assembly assembly = GetType().GetTypeInfo().Assembly;
            string resource = "App1.Texts.TheBlackCat.txt";

            var resources = assembly.GetManifestResourceNames();

            using (Stream stream = assembly.GetManifestResourceStream(resource))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    bool goTitle = false;
                    string line;

                    while (null != (line = reader.ReadLine()))
                    {
                        Label label = new Label
                        {
                            Text = line,
                            TextColor = Color.Black
                        };

                        if (!goTitle)
                        {
                            label.HorizontalOptions = LayoutOptions.Center;
                            label.FontSize = Device.GetNamedSize(NamedSize.Medium, label);
                            label.FontAttributes = FontAttributes.Bold;
                            mainStack.Children.Add(label);
                            goTitle = true;
                        }
                        else
                        {
                            textStack.Children.Add(label);
                        }
                    }
                }
            }

            ScrollView scrollView = new ScrollView
            {
                Content = textStack,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(5, 0),
            };

            mainStack.Children.Add(scrollView);

            Content = mainStack;

            BackgroundColor = Color.White;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
            }
        }
    }
}