using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.FormsGallery
{
    public class AboutPage : ContentPage
    {
     
        public AboutPage()
        {
            Title = "About Page Demo";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "About Page" }
                }
            };
        }
    }
}
