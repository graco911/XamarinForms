using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1.Views
{
    public class NamedFontSizesPage : ContentPage
    {
        public NamedFontSizesPage()
        {
            FormattedString formattedString = new FormattedString();
            NamedSize[] namedSizes =
            {
                NamedSize.Default,
                NamedSize.Micro,
                NamedSize.Small,
                NamedSize.Medium,
                NamedSize.Large
            };


            foreach (var item in namedSizes)
            {
                double fontSize = Device.GetNamedSize(item, typeof(Label));

                formattedString.Spans.Add(new Span
                {
                    Text = String.Format("Named Size = {0} ({1:F2})", item, fontSize),
                    FontSize = fontSize
                });

                if (item != namedSizes.Last())
                {
                    formattedString.Spans.Add(new Span
                    {
                        Text = Environment.NewLine + Environment.NewLine
                    });
                }
            }

            Content = new Label
            {
                FormattedText = formattedString,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
        }
    }
}