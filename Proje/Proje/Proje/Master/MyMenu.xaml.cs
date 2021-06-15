using Proje.Models;
using Proje.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proje.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMenu : ContentPage
    {
        public MyMenu()
        {
            InitializeComponent();

            IconImageSource = "menu.png";
            Title = "Menu";
            var lst = new List<Item>
            {
                  new Item { Name = "Anasayfa", No = "1",Image="home.png" },
                  new Item {Name="Sözlük",No="2"},
                  new Item {Name="Pazar",No="3"},
                  new Item {Name="Adres",No="4"},
                  new Item {Name="Market",No="5"},
                  new Item {Name ="Çıkış Yap",No="6",Image="exit.png"},


            };
            lstMenu.ItemsSource = lst;
        }
            private void lstMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
                if (e.SelectedItemIndex == 0)
                {
                    Navigation.PushAsync(new MyDetail());
                }
                if (e.SelectedItemIndex == 1)
                {
                    Navigation.PushAsync(new Dict());
                }
                if (e.SelectedItemIndex == 2)
                {
                    Navigation.PushAsync(new Pazar());
                }
            if (e.SelectedItemIndex == 3)
            {
                Navigation.PushAsync(new Adres());
            }
            if (e.SelectedItemIndex == 4)
            {
                Navigation.PushAsync(new Market());
            }
            if (e.SelectedItemIndex == 5)
            {
                Navigation.PushAsync(new MyDetail());
            }

        }


        }
    }