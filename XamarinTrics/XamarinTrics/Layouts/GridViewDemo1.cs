using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.Layouts
{
    public class GridViewDemo1 : ContentPage
    {
        //http://www.pauloortins.com/2015/07/28/xamarin-forms-layouts-grid/
        //https://coderwall.com/p/uwsdlw/programmatically-adding-views-to-xamarin-forms-grid
        public GridViewDemo1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page" }
                }
            };
        }
    }
}
