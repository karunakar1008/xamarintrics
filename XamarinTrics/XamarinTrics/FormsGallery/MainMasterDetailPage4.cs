using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.FormsGallery
{
    //https://bugzilla.xamarin.com/show_bug.cgi?id=41038
    public class MainMasterDetailPage4 : MasterDetailPage
    {
        NavigationPage _navPage;

        public MainMasterDetailPage4()
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
            Page root = _navPage.Navigation.NavigationStack[0];

            await _navPage.Navigation.PopToRootAsync(false);

            Page newRoot = null;

            var btn = (Button)sender;
            if (btn.Text == "ViewA")
                newRoot = new ViewA();
            else
                newRoot = new ViewB();

            await _navPage.Navigation.PushAsync(newRoot);

            _navPage.Navigation.RemovePage(root);
        }
    }

    
}
