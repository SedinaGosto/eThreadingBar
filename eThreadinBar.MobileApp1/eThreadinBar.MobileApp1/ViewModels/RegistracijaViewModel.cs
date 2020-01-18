using eThreadinBar.MobileApp1.Views;
using eThreadingBar.Model;
using eThreadingBar.Model.Requests;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eThreadinBar.MobileApp1.ViewModels
{
   public  class RegistracijaViewModel:BaseViewModel
    {
        public RegistracijaViewModel()
        {
            InitCommand = new Command(async () => await Init());
            RegistrationCommand = new Command(async () => await Registration());
        }
        public ICommand RegistrationCommand { get; set; }
        public ICommand InitCommand { get; set; }

        private KlijentAPIService _service = new KlijentAPIService("Klijent");
        private GradAPIService _apiServiceGradovi = new GradAPIService("Grad");
        public ObservableCollection<Grad> GradoviList { get; set; } = new ObservableCollection<Grad>();

        public async Task Init()
        {
            var list = await _apiServiceGradovi.Get<List<Grad>>(null);
            GradoviList.Clear();
            foreach (var g in list)
            {
                GradoviList.Add(g);
            }
        }

        public async Task Registration()
        {
            IsBusy = true;

            var response = await _service.Get<List<Klijent>>(new KlijentSearchRequest() { KorisnickoIme = this.KorisnickoIme });
            if (response.Count == 0)
            {


                await _service.Insert<Klijent>(new KlijentInsertRequest()
                {
                    Ime = _ime,
                    Prezime = _prezime,

                    BrojTelefona = _telefon,
                    Email = _email,
                    KorisnickoIme = _korisnickoIme,
                    Password = _lozinka,
                    GradId = _gradID,
                    PasswordPotvrda = _potvrdaLozinke
                });

                await Application.Current.MainPage.DisplayAlert("Tim threading bar d.o.o", "Uspjesno ste se registorvali!", "OK");

                Application.Current.MainPage = new LoginPage();

            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime već postoji", "OK");
                Application.Current.MainPage = new Registracija();

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
   
        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }

        string _lozinka = string.Empty;
        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }
        string _potvrdaLozinke = string.Empty;
        public string PotvrdaLozinke
        {
            get { return _potvrdaLozinke; }
            set { SetProperty(ref _potvrdaLozinke, value); }
        }
        int _gradID = 0;
        public int GradID
        {
            get { return _gradID; }
            set { SetProperty(ref _gradID, value); }
        }
    }
}
