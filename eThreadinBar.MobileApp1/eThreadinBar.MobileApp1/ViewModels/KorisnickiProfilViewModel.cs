using eThreadingBar.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eThreadinBar.MobileApp1.ViewModels
{
    public class KorisnickiProfilViewModel:BaseViewModel
    {
        private readonly APIService _apiservice = new APIService("Klijent");

        public KorisnickiProfilViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        public ICommand InitCommand { get; set; }
        public Klijent k = null;
        public async Task Init()
        {
            var korisnicko = APIService.Username;
            var list = await _apiservice.Get<List<Klijent>>(null);
            foreach (var klijent in list)
            {
                if (klijent.KorisnickoIme == korisnicko)
                {
                    Ime = klijent.Ime;
                    Prezime = klijent.Prezime;
                    BrojTelefona = klijent.BrojTelefona;
                }
            }
        }
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        string _brojTelefona = string.Empty;

        public string BrojTelefona
        {
            get { return _brojTelefona; }
            set { SetProperty(ref _brojTelefona, value); }
        }

    }
}
