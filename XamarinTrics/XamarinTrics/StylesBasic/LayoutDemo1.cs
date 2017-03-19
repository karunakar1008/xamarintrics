using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.StylesBasic
{
    public class LayoutDemo1 : ContentPage
    {
        public LayoutDemo1()
        {
            Title = "Layout Demo1";
            BackgroundColor = Color.Aqua;

            Content = new StackLayout
            {
                HorizontalOptions=LayoutOptions.Center,
                VerticalOptions=LayoutOptions.Center,
                BackgroundColor=Color.Yellow,
                //Children = {
                //    new Label { Text = "Hello Page" }
                //}
            };
        }
    }
}
