using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.StylesDemo
{
    public class HomePageCS : TabbedPage
    {
        public HomePageCS()
        {
            Children.Add(new NoStylesPageCS());
          //  Children.Add(new ExplicitStylesPageCS());
            //Children.Add(new ImplicitStylesPageCS());
            //Children.Add(new ApplicationStylesPageCS());
           // Children.Add(new StyleInheritancePageCS());
        }
    }
}
