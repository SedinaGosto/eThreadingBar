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
    public class KlijentNotifikacijaViewModel : BaseViewModel
    {
        private readonly APIService _notifikacijaservice = new APIService("KlijentNotifikacija");
        private readonly APIService _terminservice = new APIService("Termin");
        private readonly APIService _tretmanservice = new APIService("Tretman");
        private readonly APIService _uposlenikservice = new APIService("Korisnici");
        private readonly APIService _rezervacijaservice = new APIService("Rezervacija");

        public KlijentNotifikacijaList not {get; set;}




        public KlijentNotifikacijaViewModel()
        {
            InitCommand = new Command(async () => await Init());
            OznaciKaoProcitano = new Command(async () => await Procitano(not));

        }
        public ObservableCollection<KlijentNotifikacijaList> n { get; set; } = new ObservableCollection<KlijentNotifikacijaList>();
        public ICommand InitCommand { get; set; }
        public ICommand OznaciKaoProcitano { get; set; }

        public async Task Init()
        {
            var list = await _notifikacijaservice.Get<List<KlijentNotifikacija>>(new KlijentNotifikacijaSearchRequest
            { KlijentId=APIService.klijent.KlijentId}); 
            n.Clear();
            foreach (var notifikacija in list)
            {
                var rezervacija = await _rezervacijaservice.GetById<Rezervacija>(notifikacija.RezervacijaId);
                var termin = await _terminservice.GetById<Termin>(rezervacija.TerminId);
                var tretman = await _tretmanservice.GetById<Tretman>(rezervacija.TretmanId);
                var uposlenik = await _uposlenikservice.GetById<Korisnici>(termin.KorisnikId);
                n.Add(new KlijentNotifikacijaList
                {
                    Cijena = tretman.Cijena.ToString(),
                    DatumRezervacije = rezervacija.DatumRezervacije.ToString(),
                    Tretman = tretman.Naziv,
                    NotifikacijaId = notifikacija.NotifikacijaId,
                    Uposlenik = uposlenik.Ime + " " + uposlenik.Prezime,
                    VrijemeTermina = termin.VrijemeTermina.ToString(),
                    KlijentId=notifikacija.KlijentId,
                    DatumSlanja=notifikacija.DatumSlanja,
                    RezervacijaId=notifikacija.RezervacijaId
                });
            }
        }
        public async Task Procitano(KlijentNotifikacijaList not)
        {
           var entity= await _notifikacijaservice.Update<KlijentNotifikacija>(not.NotifikacijaId, new KlijentNotifikacijaInsertRequest
            {
                NotifikacijaId = not.NotifikacijaId,
                DatumSlanja = not.DatumSlanja,
                IsProcitano = true,
                KlijentId= not.KlijentId,
                RezervacijaId= not.RezervacijaId
            });
            if (entity != null)
            {
                   int broj = int.Parse(APIService.BrojNotifikacija);
                if (broj > 0)
                {
                    broj -= 1;

                    APIService.BrojNotifikacija = broj.ToString();
                }
                n.Remove(not);
                
                await Application.Current.MainPage.DisplayAlert("Tim threading bar d.o.o", "Notifikacija je oznacena kao procitana!", "OK");
            }
        }

    }

}

