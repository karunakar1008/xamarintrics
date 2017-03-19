using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.StylesBasic
{
    public class SignUpPageDemo : ContentPage
    {
        //https://www.youtube.com/watch?v=8d3au9ck-uE
        public SignUpPageDemo()
        {
            Title = "Quick tips on UI design";

            Label title = new Label
            {
                Text = "Form Controls",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            Label emailLabel = new Label
            {
                Text = "Email",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            Entry emailEntry = new Entry
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            StackLayout emailStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { emailLabel, emailEntry }
            };

            Label passwordLabel = new Label
            {
                Text = "Password",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            Entry passwordEntry = new Entry
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                IsPassword = true
            };
            StackLayout passwordSTack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { passwordLabel, passwordEntry }
            };

            Picker colorPicker = new Picker
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Title = "Favorite Color"
            };
            string[] colors = new string[] { "red", "blue", "green", "red", "yellow" };

            foreach (string s in colors)
            {
                colorPicker.Items.Add(s);
            }
            StackLayout stack = new StackLayout
            {

                Children = {
                  title,emailStack,passwordSTack,colorPicker
                }
            };
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 10);
            Content = stack;
        }
    }
}
