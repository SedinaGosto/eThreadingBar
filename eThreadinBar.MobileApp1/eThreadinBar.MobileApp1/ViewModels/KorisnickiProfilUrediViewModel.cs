using eThreadinBar.MobileApp1.Views;
using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eThreadinBar.MobileApp1.ViewModels
{
    public class KorisnickiProfilUrediViewModel:BaseViewModel
    {
        private APIService _service = new APIService("Klijent");
        private APIService _apiServiceGradovi = new APIService("Grad");
        public Klijent k = null;

        public KorisnickiProfilUrediViewModel()
        {
            InitCommand = new Command(async () => await Init());
            RegistrationCommand = new Command(async () => await Uredi());
        }
        public ICommand RegistrationCommand { get; set; }
        public ICommand InitCommand { get; set; }

        public ObservableCollection<Grad> GradoviList { get; set; } = new ObservableCollection<Grad>();
    

    public async Task Init()
    {
        var list = await _apiServiceGradovi.Get<List<Grad>>(null);
        GradoviList.Clear();
        foreach (var g in list)
        {
            GradoviList.Add(g);
        }
            var korisnicko = APIService.Username;
            var korsinici = await _service.Get<List<Klijent>>(null);
            foreach (var klijent in korsinici)
            {
                if (klijent.KorisnickoIme == korisnicko)
                {
                    k = klijent;
                    Ime = klijent.Ime;
                    Prezime = klijent.Prezime;
                    Telefon = klijent.BrojTelefona;
                    Email = klijent.Email;
                    KorisnickoIme = klijent.KorisnickoIme;
             
                    GradID = klijent.GradId;
                }
            }
        }

    public async Task Uredi()
    {
        IsBusy = true;

        //var response = await _service.Get<List<Korisnik>>(new KorisniciSearchRequest() { KorisnickoIme = _korisnickoIme });
        //if (response.Count == 0)
        //{

        //try
        //{//
        await _service.Update<Klijent>(k.KlijentId,new KlijentInsertRequest()
        {
            KlijentId=k.KlijentId,
            Ime = _ime,
            Prezime = _prezime,

            BrojTelefona = _telefon,
            Email = _email,
            KorisnickoIme = _korisnickoIme,
            Password = _lozinka,
            GradId = _gradID,
            PasswordPotvrda = _potvrdaLozinke
        });

        await Application.Current.MainPage.DisplayAlert("Tim threading bar d.o.o", "Uspjesno ste izmijenili podatke!", "OK");
         
            //Application.Current.MainPage = new MainPage();
        //}
        //catch (Exception)
        //{
        //await Application.Current.MainPage.DisplayAlert("Greška", "Neispravni podaci", "OK");
        //    }
        //}
        //else
        //{
        //    await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime već postoji", "OK");
        //}
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

