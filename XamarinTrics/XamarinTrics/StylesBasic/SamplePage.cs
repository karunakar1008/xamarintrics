using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.StylesBasic
{
    public class SamplePage : ContentPage
    {
        public SamplePage()
        {
            Padding = new Thickness(20);
            Title = "Sample Page";
            var label1 = new Label
            {
                Text = "I am a simple page label1",
                BackgroundColor = Color.Blue,
                WidthRequest = 150,
                HeightRequest = 40
            };
            var label2 = new Label
            {
                Text = "I am a simple page label2",
                BackgroundColor = Color.Blue,
                WidthRequest = 150,
                HeightRequest = 40
            };

            var button = new Button
            {
                Text = "I have a button",
                BackgroundColor = Color.Red,
                Font = Font.SystemFontOfSize(20),
                WidthRequest = 200,
                HeightRequest = 200
            };

            var entry = new Entry
            {
                Placeholder = "I have a entry box",
                BackgroundColor = Color.Green,
                WidthRequest = 200,
                HeightRequest = 150
            };
            Content = new StackLayout
            {
                Spacing = 10,
                Children = {label1,label2,button,entry }
            };
        }
    }
}
