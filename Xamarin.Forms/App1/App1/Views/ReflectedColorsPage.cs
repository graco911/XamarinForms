using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace App1.Views
{
    public class ReflectedColorsPage : ContentPage
    {
        public ReflectedColorsPage()
        {
            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.Blue,
                HorizontalOptions = LayoutOptions.Start
            };

            foreach (FieldInfo info in typeof(Color).GetRuntimeFields())
            {
                if (info.GetCustomAttribute<ObsoleteAttribute>() != null)
                {
                    continue;
                }

                if (info.IsPublic && info.IsStatic && info.FieldType == typeof(Color))
                {
                    stackLayout.Children.Add(
                        CreateColorLabel((Color)info.GetValue(null), info.Name));
                }
            }

            foreach (PropertyInfo info in typeof(Color).GetRuntimeProperties())
            {
                MethodInfo methodInfo = info.GetMethod;

                if (methodInfo.IsPublic && methodInfo.IsStatic && methodInfo.ReturnType == typeof(Color))
                {
                    stackLayout.Children.Add(CreateColorLabel((Color)info.GetValue(null), info.Name));
                }
            }

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(5, 20, 5, 5);
                    break;
                case Device.Android:
                    Padding = new Thickness(5, 5, 5, 5);
                    break;
            }

            Content = new ScrollView
            {
                BackgroundColor = Color.Red,
                Content = stackLayout
            };
        }

        private Label CreateColorLabel(Color color, string name)
        {
            Color backgroundColor = Color.Default;

            if (color != Color.Default)
            {
                double luminance = 0.30 * color.R + 0.59 * color.G + 0.11 * color.B;

                backgroundColor = luminance > 0.5 ? Color.Black : Color.White;
            }

            return new Label
            {
                Text = name,
                TextColor = color,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                BackgroundColor = backgroundColor,
            };
        }
    }
}