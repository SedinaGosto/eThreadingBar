using eThreadingBar.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eThreadinBar.MobileApp1.ViewModels
{
   public class UposleniciViewModel:BaseViewModel
    {
        private readonly APIService _Uposlenici = new APIService("Korisnici");
     

        public UposleniciViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Korisnici> Uposlenici { get; set; } = new ObservableCollection<Korisnici>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _Uposlenici.Get<List<Korisnici>>(null);
            Uposlenici.Clear();
            foreach (var uposlenik in list)
            {
                Uposlenici.Add(uposlenik);
            }
        }
        }
}
