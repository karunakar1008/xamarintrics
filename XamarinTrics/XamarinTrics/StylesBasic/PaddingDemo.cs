using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.StylesBasic
{
    public class PaddingDemo : ContentPage
    {
        public PaddingDemo()
        {
            var stackLayout = new StackLayout
            {
                Padding = new Thickness(10, 10, 10, 20),
                BackgroundColor=Color.Yellow,
                Children = {
                              new Label {Text = "Hello"},
                              new Label {Text = "World",BackgroundColor=Color.Red},
                    
                           }
            };

            Content = stackLayout;
        }
    }
}
