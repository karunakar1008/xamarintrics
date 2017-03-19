using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.FormsGallery
{
    public class EditorDemo1 : ContentPage
    {
        public EditorDemo1()
        {
            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    new Label { Text = "Hello Page" },

                    new Entry {Placeholder="what is your name" },
                      new Editor {MinimumHeightRequest=150,BackgroundColor=Color.Yellow,TextColor=Color.Red,HeightRequest=300 },
                        new Entry {Placeholder="what is your company" },

                }
            };
        }
    }
}
