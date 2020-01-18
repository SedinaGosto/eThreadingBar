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
    public class HistorijaRezervacijaDetailViewModel:BaseViewModel
    {
        private readonly APIService _terminiservice = new APIService("Termin");
        private readonly APIService _uposlenikService = new APIService("Korisnici");
        private readonly APIService _tretmanService = new APIService("Tretman");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        private readonly APIService _notifikacijaService = new APIService("PoslataNotifikacija");
        private readonly APIService _notifikacijaKlijentService = new APIService("KlijentNotifikacija");



        public Rezervacija rezervacija { get; set; }
        public HistorijaRezervacijaDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());
            DeleteCommand = new Command(async () => await Delete());

            IsBusy = false;

        }

        public ICommand InitCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public async Task Delete()
        {
            Prikazi = true;
            var notifikacijaKlijent = await _notifikacijaKlijentService.Get<List<KlijentNotifikacija>>(new KlijentNotifikacijaSearchRequest { 
            RezervacijaId=rezervacija.Id
            });
            if(notifikacijaKlijent.Count>0)
            {
                await _notifikacijaKlijentService.Delete<KlijentNotifikacija>(notifikacijaKlijent[0].NotifikacijaId);
                int broj = int.Parse(APIService.BrojNotifikacija);
                if (broj > 0)
                {
                    broj -= 1;

                    APIService.BrojNotifikacija = broj.ToString();
                }
            }
            var notifikacijarezervacijat = await _notifikacijaService.Get<List<PoslataNotifikacija>>(new PoslataNotifikacijaSearchRequest { 
            RezervacijaId=rezervacija.Id
            });
            if (notifikacijarezervacijat.Count > 0)
            {
                await _notifikacijaService.Delete<PoslataNotifikacija>(notifikacijarezervacijat[0].Id);
            }
           
               var entity= await _rezervacijaService.Delete<Rezervacija>(rezervacija.Id);
            if (entity != null)
            {
                  var termin = await _terminiservice.GetById<Termin>(entity.TerminId);

                await _terminiservice.Update<Termin>(termin.Id, new TerminInsertRequest
                {
                    Id = termin.Id,
                    KorisnikId = termin.KorisnikId,
                    Rezervisan = false,
                    VrijemeTermina = termin.VrijemeTermina

                });
             
                await Application.Current.MainPage.DisplayAlert("Tim threading bar d.o.o", "Uspjesno ste otkazali rezervaciju!", "OK");



            }
        }

        public async Task Init()
        {

            var termin =await _terminiservice.GetById<Termin>(rezervacija.TerminId);
            var tretman =await _tretmanService.GetById<Tretman>(rezervacija.TretmanId);
            var uposlenik = await _uposlenikService.GetById<Korisnici>(termin.KorisnikId);
            //RezervacijaId = rezervacija.Id;
            Uposlenik = uposlenik.FirstLastName;
            Tretman = tretman.Naziv;
            VrijemeTermina = termin.VrijemeTermina.ToString();
            Cijena = tretman.Cijena.ToString() + " KM";
            var temp = DateTime.Now.AddDays(3);
            if (termin.VrijemeTermina > temp)
                IsBusy = true;
            else
                IsBusy = false;
        }
        string _uposlenik = string.Empty;
        public string Uposlenik
        {
            get { return _uposlenik; }
            set { SetProperty(ref _uposlenik, value); }
        }
        bool _prikazi = false;
        public bool Prikazi
        {
            get { return _prikazi; }
            set { SetProperty(ref _prikazi, value); }
        }
        string _cijena = string.Empty;
        public string Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }
        string _tretman = string.Empty;
        public string Tretman
        {
            get { return _tretman; }
            set { SetProperty(ref _tretman, value); }
        }
        //int ?_rezervacijaId = null;
        //public int RezervacijaId
        //{
        //    get { return _rezervacijaId.Value; }
        //    set { SetProperty(ref _rezervacijaId.Value, value); }
        //}
        string _vrijemetermina = string.Empty;
        public string VrijemeTermina
        {
            get { return _vrijemetermina; }
            set { SetProperty(ref _vrijemetermina, value); }
        }
    




    }
}
