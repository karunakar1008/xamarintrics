using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics
{
    public class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            ////Default Code:

            //var content = new ContentPage
            //{
            //    Title = "Xamarin Trics",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        BackgroundColor = Color.Yellow,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};

            Title = "Xamarin Trics";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.Yellow,
                Padding=new Thickness(10),
                Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions=LayoutOptions.FillAndExpand,
                            Text = "Welcome to Xamarin Forms!",
                            BackgroundColor=Color.Gray
                        }
                    }

            };

        }
    }
}
