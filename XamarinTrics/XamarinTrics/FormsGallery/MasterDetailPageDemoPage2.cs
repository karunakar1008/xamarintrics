using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.FormsGallery
{
    // MainPage = new NavigationPage(new MasterDetailPageDemoPage2());
    public class MasterDetailPageDemoPage2 : MasterDetailPage
    {
        ListView listView;
        public MasterDetailPageDemoPage2()
        {
            Title = "Master Detail Demo1";

            MasterPageItem[] masterPageItems = new MasterPageItem[]
            {
                new MasterPageItem
               {
                   Title = "Home",
                   IconSource = "home.png",
                   TargetType = typeof(HomePage)
               },
                new MasterPageItem
            {
                Title = "About",
                IconSource = "about.png",
                TargetType = typeof(AboutPage)
            },
                  new MasterPageItem
            {
                Title = "Conatct",
                IconSource = "contacts.png",
                TargetType = typeof(ContactPage)
            }
            };

            // Create ListView for the master page.
            listView = new ListView
            {
                ItemsSource = masterPageItems
            };

            Image header = new Image
            {
                // Some differences with loading images in initial release.
                Source =
                   Device.OnPlatform(ImageSource.FromUri(new Uri("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png")),
                                     ImageSource.FromFile("hamburger.png"),
                                     ImageSource.FromUri(new Uri("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"))),

                HorizontalOptions = LayoutOptions.Center,
                // BackgroundColor = Color.Blue
                //Source = new UriImageSource
                //{
                //    Uri = new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")
                //},
                //VerticalOptions = LayoutOptions.StartAndExpand
            };
            var stackHeader = new StackLayout
            {
                BackgroundColor = Color.Blue,
                Padding = new Thickness(1, 2, 2, 2),
                HorizontalOptions = LayoutOptions.Fill,
                Children =
                {
                        header
                }
            };

            // Create the master page with the ListView.
            this.Master = new ContentPage
            {
                Title = "Child Pages",
                Content = new StackLayout
                {
                    Children = {
                        stackHeader,
                        listView
                    }
                }
            };

            HomePage detailPage = new HomePage();
            this.Detail = detailPage;

            // For Android & Windows Phone, provide a way to get back to the master page.
            if (Device.OS != TargetPlatform.iOS)
            {
                TapGestureRecognizer tap = new TapGestureRecognizer();
                tap.Tapped += (sender, args) =>
                {
                    this.IsPresented = true;
                };

                detailPage.Content.BackgroundColor = Color.Transparent;
                detailPage.Content.GestureRecognizers.Add(tap);
            }

            // Define a selected handler for the ListView.
            listView.ItemSelected += (sender, args) =>
            {
                // Set the BindingContext of the detail page.
                this.Detail.BindingContext = args.SelectedItem;

                // Show the detail page.
                this.IsPresented = false;
            };

            // Initialize the ListView selection.
            listView.SelectedItem = masterPageItems[0];

        }
    }
}
