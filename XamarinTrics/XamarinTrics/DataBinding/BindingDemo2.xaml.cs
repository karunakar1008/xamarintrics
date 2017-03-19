using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinTrics.DataBinding
{
    public partial class BindingDemo2 : ContentPage
    {
        //https://blog.xamarin.com/introduction-to-data-binding/
        //https://github.com/davidbritch/xamarin-forms/blob/master/DataBinding101/DataBinding101/HomePage.xaml.cs
        public BindingDemo2()
        {
            InitializeComponent();

            BindingContext = new DetailsViewModel() { Forename = "Karunakr", Surname = "Bhogyari" };
        }
    }
}
