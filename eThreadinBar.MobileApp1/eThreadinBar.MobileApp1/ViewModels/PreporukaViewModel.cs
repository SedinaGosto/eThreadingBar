using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eThreadinBar.MobileApp1.ViewModels
{
    public class PreporukaViewModel:BaseViewModel
    {
        private APIService _apiServiceKorisnici = new APIService("Korisnici");
        private APIService _apiServiceRezervacija = new APIService("Rezervacija");
        private  APIService _terminiservice = new APIService("Termin");

        public PreporukaViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        List<Preporuka> preporuke = new List<Preporuka>();
        public ObservableCollection<Termin> termini { get; set; } = new ObservableCollection<Termin>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {

            var uposlenici = await _apiServiceKorisnici.Get<List<Korisnici>>(null);
            foreach(var u in uposlenici)
            {
                var rezervacije = await _apiServiceRezervacija.Get<List<Rezervacija>>(new RezervacijaSearchRequest
                {
                    KlijentId=APIService.klijent.KlijentId,
                   UposlenikId=u.KorisnikId
                    

                });
                int brojrezervacija = rezervacije.Count;
                
                preporuke.Add(new Preporuka { KorisnikId = u.KorisnikId, Brojrezervacija = brojrezervacija });
            }
            preporuke = preporuke.OrderByDescending(x => x.Brojrezervacija).ToList();
            var termin = await _terminiservice.Get<List<Termin>>(new TerminSearchRequest { UposlenikId = preporuke[0].KorisnikId, Rezervisan = false });
            if (termini.Count > 0)
                termini.Clear();
            foreach (var t in termin)
            {
                DateTime danasnji = DateTime.Now;
                DateTime temp = t.VrijemeTermina.AddDays(1);
                if (temp > danasnji)
                    termini.Add(t);

                termini.Add(t);
            }
            var korisnik = await _apiServiceKorisnici.GetById<Korisnici>(preporuke[0].KorisnikId);
            Uposlenik = korisnik.Ime + " " + korisnik.Prezime;
        }
        string _uposlenik = string.Empty;
        public string Uposlenik
        {
            get { return _uposlenik; }
            set { SetProperty(ref _uposlenik, value); }
        }

    }
}
