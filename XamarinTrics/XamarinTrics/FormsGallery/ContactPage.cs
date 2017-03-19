using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.FormsGallery
{
    public class ContactPage : ContentPage
    {
        public ContactPage()
        {
            Title = "Conatct Page Demo";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Conatct Page" }
                }
            };
        }
    }
}
