using eThreadinBar.MobileApp1.Views;
using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eThreadinBar.MobileApp1.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _notifikacija = new APIService("KlijentNotifikacija");

        private readonly GradAPIService _service1 = new GradAPIService("Grad");

        private readonly APIService _serviceLogin = new APIService("Klijent");


        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }
        Klijent k;

        async Task Login()
        {
            IsBusy = true;
            
            APIService.Username = Username;
            APIService.Password = Password;
            List<KlijentNotifikacija> notifikacije = null;
         
            try
            {
                var Kl =await _serviceLogin.Get<List<Klijent>>(new KlijentSearchRequest { KorisnickoIme = APIService.Username });
                foreach(var klijent in Kl)
                {
                    if(klijent.KorisnickoIme==APIService.Username)
                    {
                        k = klijent;
                        APIService.klijent = klijent;
                    }
                }
                
                var list = await _notifikacija.Get<List<KlijentNotifikacija>>(new KlijentNotifikacijaSearchRequest { KlijentId=k.KlijentId});
                notifikacije = list;
                APIService.BrojNotifikacija = notifikacije.Count.ToString();
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Tim threading bar d.o.o", "Pogresno korisnicko ime ili password!", "OK");
                Application.Current.MainPage = new LoginPage();
            }
        }
    }
}
