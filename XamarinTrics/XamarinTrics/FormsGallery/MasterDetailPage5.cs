using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrics.FormsGallery
{
    //http://stackoverflow.com/questions/33045854/xamarin-forms-master-detail-page-icon-and-menu-icon

    public class Home : ContentPage
    {
        public Home()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Home Page" }
                }
            };
        }
    }

    public class Register : ContentPage
    {
        public Register()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Registr Page" }
                }
            };
        }
    }
    public class SearchInstructors : ContentPage
    {
        public SearchInstructors()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "SearchInstructors Page" }
                }
            };
        }
    }
    

    public class MasterDetailPage5 : MasterDetailPage
    {
        MenuPage menuPage;
        public MasterDetailPage5()
        {


            menuPage = new MenuPage();
            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);
            Master = menuPage;
            NavigationPage page = new NavigationPage(new Home());
            page.BarBackgroundColor = Color.FromHex("#56198E");
            Detail = page;


        }

        void NavigateTo(MenuItem menu)
        {
            if (menu == null)
                return;
            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);
            NavigationPage page = new NavigationPage(displayPage);
            page.BarBackgroundColor = Color.FromHex("#56198E");
            Detail = page;

            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }

    public class MenuPage : ContentPage
    {
        public ListView Menu { get; set; }


        public MenuPage()
        {
            Icon = "settings.png";
            Title = "menu"; // The Title property must be set.
            BackgroundColor = Color.FromHex("#56198E");

            Menu = new MenuListView();

            var menuLabel = new ContentView
            {
                Padding = new Thickness(10, 36, 0, 5),
                Content = new Label
                {
                    TextColor = Color.FromHex("#C8C8C8"),
                    Text = "MENU",
                }
            };

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            layout.Children.Add(menuLabel);
            layout.Children.Add(Menu);

            Content = layout;
        }
    }

    public class MenuListView : ListView
    {
        public MenuListView()
        {
            List<MenuItem> data = new MenuListData();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;
            // SeparatorVisibility = SeparatorVisibility.None;

            //var cell = new DataTemplate(typeof(MenuCell));
            //cell.SetBinding(MenuCell.TextProperty, "Title");
            //cell.SetBinding(MenuCell.ImageSourceProperty, "IconSource");

            //ItemTemplate = cell;
        }
    }

    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Title = " Home",
                IconSource = "Home.png",
                TargetType = typeof(Home)
            });


            this.Add(new MenuItem()
            {
                Title = " Register for Classes",
                IconSource = "Calendar.png",
                TargetType = typeof(Register)
            });

            this.Add(new MenuItem()
            {
                Title = " Search Instructors",
                IconSource = "ContactsSearch.png",
                TargetType = typeof(SearchInstructors)
            });


        }
    }

    public class MenuItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}
