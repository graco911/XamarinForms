using Xamarin.Forms;

namespace App1.Views
{
    public class PageLogin : ContentPage
    {
        public PageLogin()
        {
            //Content = new StackLayout
            //{
            //    //Children =
            //    //{
            //    //    new Label { Text = "Welcome to Xamarin.Forms!" }
            //    //}
            //};

            //Content = new Label
            //{
            //    Text = "Greetings, Xamarin.Forms!",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //};

            //Content = new Label
            //{
            //    Text = "Greetings, Xamarin.Forms!",
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    VerticalTextAlignment = TextAlignment.Center
            //};

            //Content = new Label
            //{
            //    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec enim vitae nibh finibus convallis. Sed lobortis malesuada aliquam." +
            //    " Proin non augue gravida, aliquam purus sed, vestibulum arcu. Sed ullamcorper metus vitae lacus lacinia, quis posuere augue finibus. Sed et porta urna." +
            //    " Quisque nec condimentum felis. Integer vestibulum lorem ac condimentum posuere. In lacinia turpis lobortis risus commodo aliquet.Sed porta dui dolor.Vestibulum " +
            //    "pellentesque nulla at urna lobortis, mattis condimentum sapien tristique.Nullam tincidunt quis lacus a luctus.Pellentesque tellus eros," +
            //    "feugiat eget accumsan id, vehicula non ante.Suspendisse faucibus bibendum odio, a pellentesque sapien fermentum at.Nunc dignissim odio purus." +
            //    "Mauris sed sapien est.Suspendisse et convallis dolor, id accumsan elit.Donec vitae nulla vel velit imperdiet vehicula.Nullam eu neque eget " +
            //    "ipsum sodales tristique.Maecenas nisi nunc, condimentum viverra sollicitudin vel, condimentum fringilla nulla.Suspendisse feugiat massa eget" +
            //    "laoreet varius.Nullam lacinia pretium bibendum.Phasellus at congue lorem.Cras vitae urna gravida, volutpat neque vel, interdum enim.Praesent egestas,",
            //    VerticalTextAlignment = TextAlignment.Center
            //};

            //        Content = new Label
            //        {
            //            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec enim vitae nibh finibus convallis. Sed lobortis malesuada aliquam." +
            //" Proin non augue gravida, aliquam purus sed, vestibulum arcu. Sed ullamcorper metus vitae lacus lacinia, quis posuere augue finibus. Sed et porta urna." +
            //" Quisque nec condimentum felis. Integer vestibulum lorem ac condimentum posuere. In lacinia turpis lobortis risus commodo aliquet.Sed porta dui dolor.Vestibulum " +
            //"pellentesque nulla at urna lobortis, mattis condimentum sapien tristique.Nullam tincidunt quis lacus a luctus.Pellentesque tellus eros," +
            //"feugiat eget accumsan id, vehicula non ante.Suspendisse faucibus bibendum odio, a pellentesque sapien fermentum at.Nunc dignissim odio purus." +
            //"Mauris sed sapien est.Suspendisse et convallis dolor, id accumsan elit.Donec vitae nulla vel velit imperdiet vehicula.Nullam eu neque eget " +
            //"ipsum sodales tristique.Maecenas nisi nunc, condimentum viverra sollicitudin vel, condimentum fringilla nulla.Suspendisse feugiat massa eget" +
            //"laoreet varius.Nullam lacinia pretium bibendum.Phasellus at congue lorem.Cras vitae urna gravida, volutpat neque vel, interdum enim.Praesent egestas,",
            //            VerticalTextAlignment = TextAlignment.Center,
            //            LineBreakMode = LineBreakMode.CharacterWrap
            //        };


            //Content = new Label
            //{
            //    Text = "Greetings, Xamarin.Forms!",
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    VerticalTextAlignment = TextAlignment.Center,
            //    BackgroundColor = Color.Yellow,
            //    TextColor = Color.Red
            //};

            //Content = new Label
            //{
            //    Text = "Greetings, Xamarin.Forms!",
            //    VerticalOptions = LayoutOptions.Center,
            //    HorizontalOptions = la.Center,
            //    BackgroundColor = Color.Yellow,
            //    TextColor = Color.Red
            //};

            Content = new Label
            {
                FormattedText = Utils.Helper.CreateFormattedString(new Span[]
                {
                    new Span
                    {
                        Text = "I "
                    },
                    new Span
                    {
                        Text = "love",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Bold
                    },
                    new Span
                    {
                        Text = " Xamarin.Forms!"
                    }
                }),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Yellow,
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

            //#if __IOS__
            //            Padding = new Thickness(0, 20, 0, 0);
            //#endif

            //Padding = Device.OnPlatform<Thickness>(new Thickness(0, 20, 0, 0),
            //    new Thickness(0),
            //    new Thickness(0));

            //switch (Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //        Padding = new Thickness(0, 20, 0, 0);
            //        break;
            //    case Device.Android:
            //        Padding = new Thickness(5);
            //        break;
            //}
        }

    }
}