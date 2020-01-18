using eThreadinBar.MobileApp1.Models;
using eThreadinBar.MobileApp1.ViewModels;
using eThreadingBar.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eThreadinBar.MobileApp1.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        ObservableCollection<HomeMenuItem> menuItems;
        
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new ObservableCollection<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Preporuke", ImageSource="recommendation.png"},
                new HomeMenuItem {Id = MenuItemType.About, Title=" Kako do nas?", ImageSource="map.png"},
                new HomeMenuItem {Id = MenuItemType.KorisnickiProfil, Title="Pregledaj profil", ImageSource="Profile.png" },
                new HomeMenuItem {Id = MenuItemType.HistorijaRezervacija, Title="Moje rezervacije", ImageSource="Historijarezervacija.png" },
                new HomeMenuItem {Id = MenuItemType.Novosti, Title="Novosti", ImageSource="novosti.png" },
                new HomeMenuItem {Id = MenuItemType.UposlenikRezervacija, Title="Kreiraj rezervaciju", ImageSource="rezervacija.png" },
                new HomeMenuItem {Id = MenuItemType.Notifikacija, Title="Notifikacije", ImageSource="notification.png",BrojNotifikacija=APIService.BrojNotifikacija},

                new HomeMenuItem {Id = MenuItemType.Odjava, Title="Odjava",ImageSource="Logout.png" }
       



            };
       
      
            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
     
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;

               
                menuItems[6].BrojNotifikacija = APIService.BrojNotifikacija;




                await RootPage.NavigateFromMenu(id);
            };
        }
    
      


    }
}