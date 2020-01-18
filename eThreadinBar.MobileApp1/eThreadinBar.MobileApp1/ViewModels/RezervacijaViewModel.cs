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
    public class RezervacijaViewModel:BaseViewModel
    {
        private APIService _tretmanservice = new APIService("Tretman");
        private APIService _terminService = new APIService("Termin");

        private APIService _apiServiceRezervacija = new APIService("Rezervacija");
        private APIService _apiServiceNotifikacija = new APIService("PoslataNotifikacija");

        private APIService _apiServiceKlijent = new APIService("Klijent");
        private APIService _apiServiceKorisnici= new APIService("Korisnici");


        public Termin Termin { get; set; }
        public Klijent korisnik { get; set; }
        public Korisnici uposlenik { get; set; }


        public RezervacijaViewModel()
        {
            InitCommand = new Command(async () => await Init());
            Rezervacija = new Command(async () => await RezervacijaTask());
        }
        public ObservableCollection<Tretman> TretmanList { get; set; } = new ObservableCollection<Tretman>();

        public ICommand InitCommand { get; set; }
        public ICommand Rezervacija { get; set; }

        public async Task Init()
        {
            Vrijemetermina = Termin.VrijemeTermina;

            var korisnickoIme = APIService.Username;
            List<Klijent> listKorisnici = await _apiServiceKlijent.Get<List<Klijent>>(null);
            foreach (var k in listKorisnici)
            {
                if (k.KorisnickoIme == korisnickoIme)
                {
                    korisnik = k;
                    break;
                }
            }
            uposlenik = await _apiServiceKorisnici.GetById<Korisnici>(Termin.KorisnikId);
            var list = await _tretmanservice.Get<List<Tretman>>(null);
            TretmanList.Clear();
            foreach (var g in list)
            {
                TretmanList.Add(g);
            }
        }
        Rezervacija entity = null;
        public async Task RezervacijaTask()
        {
            IsBusy = true;
          entity=  await _apiServiceRezervacija.Insert<Rezervacija>(new RezervacijaInsertRequest()
            {
                KlijentId = korisnik.KlijentId,
                TerminId=Termin.Id,
                DatumRezervacije= _datumRezervacije,
                TretmanId= _tretmanId
            }) ;

            await _terminService.Update<Termin>(Termin.Id,new TerminInsertRequest
            {
                Id = Termin.Id,
                KorisnikId = Termin.KorisnikId,
                VrijemeTermina = Termin.VrijemeTermina,
                Rezervisan = true

            });


            if(entity!=null)
            {
                await _apiServiceNotifikacija.Insert<PoslataNotifikacija>(new PoslataNotifikacijaInsertRequest
                {
                    RezervacijaId = entity.Id,
                    DatumSlanja = DateTime.Now,
                    IsProcitano = false

                }) ;
                await Application.Current.MainPage.DisplayAlert("Uspjesno pohranjeno", "Zahvaljujemo na kreiranoj rezervaciji!", "OK");
            }
        
        }
        int _tretmanId = 0;
        public int TretmanID
        {
            get { return _tretmanId; }
            set { SetProperty(ref _tretmanId, value); }
        }
        DateTime _datumRezervacije = DateTime.Now;
        public DateTime DatumRezervacije
        {
            get { return _datumRezervacije; }
            set { SetProperty(ref _datumRezervacije, value); }
        }
        DateTime vrijemetermina = DateTime.Now;
        public DateTime Vrijemetermina
        {
            get { return vrijemetermina; }
            set { SetProperty(ref vrijemetermina, value); }
        }

    }
}
