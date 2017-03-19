using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.DataBinding
{
    public class BindingDemo1 : ContentPage
    {
        public BindingDemo1()
        {
            var sourceModel = new DetailsViewModel { Forename = "Sreenu", Surname = "Bogyari" };
            BindingContext = sourceModel;
            var surNameEntry = new Entry { };
            surNameEntry.SetBinding(Entry.TextProperty, "Surname", mode: BindingMode.TwoWay);
            var forNameEntry = new Entry { };
            forNameEntry.SetBinding(Entry.TextProperty, "Forename", mode: BindingMode.TwoWay);

            var surNameLabel = new Label { };
            surNameLabel.SetBinding(Label.TextProperty, "Surname", mode: BindingMode.TwoWay);

            var forNameLabel = new Label { };
            forNameLabel.SetBinding(Label.TextProperty, "Forename", mode: BindingMode.TwoWay);

            Content = new StackLayout
            {
                Padding = new Thickness(0, 20, 0, 0),
                Children = {
                    new Label { Text = "Data Binding 101 Dem2",FontAttributes=FontAttributes.Bold,HorizontalOptions=LayoutOptions.Center },
                     new Label { Text = "Forename" },
                        forNameEntry,
                    new Label { Text = "Surname" },
                   surNameEntry,
                    new StackLayout
                    {
                         Padding = new Thickness(0, 20, 0, 0),
                         Orientation=StackOrientation.Horizontal,
                         Children=
                        {
                            new Label { Text="Your forename is:" },
                              forNameLabel
                        }
                    },
                    new StackLayout
                    {
                         Padding = new Thickness(0, 20, 0, 0),
                         Orientation=StackOrientation.Horizontal,
                           Children=
                        {
                             new Label { Text="Your surname is:" },
                             surNameLabel
                        }
                    }
                }
            };
        }
    }
}
