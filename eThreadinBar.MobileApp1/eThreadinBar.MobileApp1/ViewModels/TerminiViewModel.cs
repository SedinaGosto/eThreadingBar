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
    public class TerminiViewModel:BaseViewModel
    {
        private readonly APIService _terminiservice = new APIService("Termin");

        public Korisnici _uposlenik { get; set; }

        public TerminiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Termin> termini { get; set; } = new ObservableCollection<Termin>();

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            DateTime danasnji = DateTime.Now;
            var list = await _terminiservice.Get<IEnumerable<Termin>>(new TerminSearchRequest { UposlenikId = _uposlenik.KorisnikId, Rezervisan = false }); 
            termini.Clear();
            foreach (var novost in list)
            {
                DateTime temp = novost.VrijemeTermina.AddDays(1);
                if(temp>danasnji)
                termini.Add(novost);



            }
        }


        
    }
}
