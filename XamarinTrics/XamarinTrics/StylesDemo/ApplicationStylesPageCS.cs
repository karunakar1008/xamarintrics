using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.StylesDemo
{
    public class ApplicationStylesPageCS : ContentPage
    {
        public ApplicationStylesPageCS()
        {
            Title = "Application";
            Icon = "csharp.png";
            Padding = new Thickness(0, 20, 0, 0);

            Content = new StackLayout
            {
                Children = {
                    new Button { Text = "These buttons", Style = (Style)Application.Current.Resources ["buttonStyle"] },
                    new Button { Text = "are demonstrating", Style = (Style)Application.Current.Resources ["buttonStyle"] },
                    new Button { Text = "application styles", Style = (Style)Application.Current.Resources ["buttonStyle"]
                    }
                }
            };
        }
    }
}
