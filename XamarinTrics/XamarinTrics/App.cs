using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTrics.DataBinding;
using XamarinTrics.FormsGallery;
using XamarinTrics.Layouts;
using XamarinTrics.PhoneWord2;
//using XamarinTrics.PhonewordApp;
using XamarinTrics.StylesBasic;
using XamarinTrics.StylesDemo;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinTrics
{
    public class App : Application
    {
        public App()
        {
            #region appresources

            var buttonStyle = new Style(typeof(Button))
            {
                Setters = {
                    new Setter {
                        Property = View.HorizontalOptionsProperty,
                        Value = LayoutOptions.Center
                    },
                    new Setter {
                        Property = View.VerticalOptionsProperty,
                        Value = LayoutOptions.CenterAndExpand
                    },
                    new Setter {
                        Property = Button.BorderColorProperty,
                        Value = Color.Lime
                    },
                    new Setter {
                        Property = Button.BorderRadiusProperty,
                        Value = 5
                    },
                    new Setter {
                        Property = Button.BorderWidthProperty,
                        Value = 5
                    },
                    new Setter {
                        Property = VisualElement.WidthRequestProperty,
                        Value = 200
                    },
                    new Setter {
                        Property = Button.TextColorProperty,
                        Value = Color.Teal
                    }
                }
            };

            Resources = new ResourceDictionary();
            Resources.Add("buttonStyle", buttonStyle);

            #endregion appresources

            // The root page of your application
            var content = new ContentPage
            {
                Title = "Xamarin Trics",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    BackgroundColor = Color.Yellow,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };

            MainPage = new NavigationPage(new BindingDemo1());


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
