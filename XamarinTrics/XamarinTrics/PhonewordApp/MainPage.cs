using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

using static XamarinTrics.PhonewordApp.PhonewordTranslator;

namespace XamarinTrics.PhonewordApp
{
    public class MainPage : ContentPage
    {
        Entry phoneNumberText;
        Button translateButton;
        Button callButton;

        string translatedNumber;

        public MainPage()
        {
            Title = "Phone word APP";
            this.Padding = new Thickness(20,
           Device.OnPlatform<double>(40, 20, 20), 20, 20);

            //To Understand
            //double spacing = Device.OnPlatform<double>
            //                                            (
            //                                                40, // iOS
            //                                                20, // Android
            //                                                20  // Windows Phone
            //                                            );

            StackLayout panel = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,//default orientation is also vertical
                Spacing = 15,//spacing between stack children
            };

            panel.Children.Add(new Label
            {
                Text = "Enter a Phoneword:",
            });

            panel.Children.Add(phoneNumberText = new Entry
            {
                Text = "1-855-XAMARIN",
            });

            panel.Children.Add(translateButton = new Button
            {
                Text = "Translate"
            });


            panel.Children.Add(callButton = new Button
            {
                Text = "Call",
                IsEnabled = false,
            });

            translateButton.Clicked += OnTranslate;
            callButton.Clicked += OnCall;
            this.Content = panel;
        }

        private async void OnCall(object sender, EventArgs e)
        {
            if (await this.DisplayAlert(
        "Dial a Number",
        "Would you like to call " + translatedNumber + "?",
        "Yes",
        "No"))
            {

                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                {
                    await dialer.DialAsync(translatedNumber);
                }
            }
        }

        private void OnTranslate(object sender, EventArgs e)
        {
            translatedNumber = ToNumber(phoneNumberText.Text);
            if (!string.IsNullOrEmpty(translatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Text = "Call " + translatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }
        }
    }
}
