using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.StylesBasic
{
    public class LayoutOptionsDemo : ContentPage
    {
        static readonly StackLayout stackLayout = new StackLayout
        {
            BackgroundColor = Color.Gray,
            Padding = 2,
            Spacing = 2,
        };

        public LayoutOptionsDemo()
        {
            AddElement("Start", LayoutOptions.Start);
            AddElement("Center", LayoutOptions.Center);
            AddElement("End", LayoutOptions.End);
            AddElement("Fill", LayoutOptions.Fill);
            AddElement("StartAndExpand", LayoutOptions.StartAndExpand);
            AddElement("CenterAndExpand", LayoutOptions.CenterAndExpand);
            AddElement("EndAndExpand", LayoutOptions.EndAndExpand);
            AddElement("FillAndExpand", LayoutOptions.FillAndExpand);
            AddElement("StartAndExpand", LayoutOptions.StartAndExpand);
            Title = "Layout options in X.Forms";
            Padding = new Thickness(0, Device.OnPlatform<int>(20, 0, 0), 0, 0);

            Content = stackLayout;

        }

        static void AddElement(string text, LayoutOptions layoutOption)
        {
            stackLayout.Children.Add(
            new Label
            {
                Text = text,
                BackgroundColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = layoutOption,
                VerticalOptions = layoutOption,
                WidthRequest = 160,
                HeightRequest = 25,
            });

            //stackLayout.Children.Add(new Label
            //{
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    Text = "Welcome to Xamarin Forms!"
            //});

            //stackLayout.Children.Add(new BoxView
            //{
            //    HeightRequest = 1,
            //    Color = Color.Yellow,
            //});
        }

    }
}
