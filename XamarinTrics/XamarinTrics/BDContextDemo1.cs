using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics
{
    public class BDContextDemo1 : ContentPage
    {
        public BDContextDemo1()
        {
            //var label = new Label();
            //label.SetBinding(Label.TextProperty, "Name");
            //label.BindingContext = new { Name = "John Doe", Company = "Xamarin" };
            //Debug.WriteLine(label.Text);

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Enter Your Name" }
                }
            };
        }
    }
}
