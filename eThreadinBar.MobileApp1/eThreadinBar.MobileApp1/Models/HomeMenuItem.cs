using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace eThreadinBar.MobileApp1.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Novosti,
        UposlenikRezervacija,
        KorisnickiProfil,
        HistorijaRezervacija,
        Notifikacija,
        Odjava
    }
    public class HomeMenuItem:INotifyPropertyChanged
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
        public string ImageSource { get; set; }
        public string brojNotif;
        public event PropertyChangedEventHandler PropertyChanged;
        public string BrojNotifikacija
        {
            set
            {
                if (brojNotif != value)
                {
                    brojNotif = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BrojNotifikacija"));
                    }
                }
            }
            get
            {
                return brojNotif;
            }
        }

 
    }
}
