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
   public class HistorijaRezervacijaViewModel:BaseViewModel
    {
        private readonly APIService _apiService = new APIService("Rezervacija");
        private readonly APIService _klijent = new APIService("Klijent");
        private readonly APIService _tretman = new APIService("Tretman");


        Klijent klijent = null;


        public HistorijaRezervacijaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
   
        public ICommand InitCommand { get; set; }
        public ObservableCollection<Rezervacija> rezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();

        public async Task Init()
        {
            int ukupno = 0;
            var username = APIService.Username;
            var korisnici = await _klijent.Get<List<Klijent>>(null);
            foreach(var k in korisnici)
            {
                if (k.KorisnickoIme == username)
                    klijent = k;
            }
            var rezervacije = await _apiService.Get<List<Rezervacija>>(new RezervacijaSearchRequest() { KlijentId = klijent.KlijentId });
            rezervacijeList.Clear();
            foreach(var r in rezervacije)
            {
                var tretman = await _tretman.GetById<Tretman>(r.TretmanId);
                r.Tretman = tretman.NazivCijena;
                ukupno += tretman.Cijena;
                rezervacijeList.Add(r);
  
            }

            Ukupno = ukupno.ToString() + " KM";

        }
        string _ukupno = null;
        public string Ukupno
        {
            get { return _ukupno; }
            set { SetProperty(ref _ukupno, value); }
        }

    }
}

