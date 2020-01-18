using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eThreadinBar.MobileApp1.Models;

namespace eThreadinBar.MobileApp1.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new MapPage()));
                        break;
                    case (int)MenuItemType.Novosti:
                        MenuPages.Add(id, new NavigationPage(new NovostiPage()));
                        break;
                    case (int)MenuItemType.UposlenikRezervacija:
                        MenuPages.Add(id, new NavigationPage(new UposleniciPage()));
                        break;
                    case (int)MenuItemType.KorisnickiProfil:
                        MenuPages.Add(id, new NavigationPage(new KorisnickiProfilPage()));
                        break;
                    case (int)MenuItemType.HistorijaRezervacija:
                        MenuPages.Add(id, new NavigationPage(new HistorijaRezervacijaPage()));
                        break;
                    case (int)MenuItemType.Notifikacija:
                        MenuPages.Add(id, new NavigationPage(new KlijentNotifikacijaPage()));
                        break;
                    case (int)MenuItemType.Odjava:
                        MenuPages.Add(id, new NavigationPage(new OdjavaPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
                
            }
        }
    }
}