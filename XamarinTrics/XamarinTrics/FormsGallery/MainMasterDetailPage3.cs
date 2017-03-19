using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.FormsGallery
{
    public class MainMasterDetailPage3 : MasterDetailPage
    {
        //https://bugzilla.xamarin.com/show_bug.cgi?id=42548
        NavigationPage _navPage;

        public MainMasterDetailPage3()
        {
            Title = "Main";

            var btnViewA = new Button() { Text = "ViewA" };
            btnViewA.Clicked += Button_Clicked;

            var btnViewB = new Button() { Text = "ViewB" };
            btnViewB.Clicked += Button_Clicked;

            var stack = new StackLayout();
            stack.Children.Add(btnViewA);
            stack.Children.Add(btnViewB);

            var master = new ContentPage() { Title = "Master", Content = stack };

            _navPage = new NavigationPage(new ViewA());

            Master = master;
            Detail = _navPage;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Page newRoot = null;

            var btn = (Button)sender;
            if (btn.Text == "ViewA")
                newRoot = new ViewA();
            else
                newRoot = new ViewB();

            await _navPage.Navigation.PushAsync(newRoot);

            IsPresented = false;
        }
    }

    public class ViewA : ContentPage
    {
        public ViewA()
        {
            //hide the back button, and only show the hamburger
            //no hambuger is shown
            NavigationPage.SetHasBackButton(this, false);

            Title = "ViewA";
            Content = new Label() { Text = "View A" };
        }
    }

    public class ViewB : ContentPage
    {
        public ViewB()
        {
            //hide the back button, and only show the hamburger
            //no hambuger is shown
            NavigationPage.SetHasBackButton(this, false);

            Title = "ViewB";
            Content = new Label() { Text = "View B" };
        }
    }
}
