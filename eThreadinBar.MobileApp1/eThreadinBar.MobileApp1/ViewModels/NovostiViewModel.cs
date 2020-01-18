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
    public class NovostiViewModel:BaseViewModel
    {
        private readonly APIService _novostiService = new APIService("Clanak");
        private readonly APIService _clanakkategorija = new APIService("ClanakKategorija");

        public NovostiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Clanak> NovostiList { get; set; } = new ObservableCollection<Clanak>();
        public ObservableCollection<ClanakKategorija> KategorijaList { get; set; } = new ObservableCollection<ClanakKategorija>();


        ClanakKategorija _kategorija = null;
        public ClanakKategorija Kategorija
        {
            get { return _kategorija; }
            set { SetProperty(ref _kategorija, value);
            if(value!=null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        public ICommand InitCommand { get; set; }

       public  async Task Init()
        {
            if(KategorijaList.Count==0)
            {
                var list1 = await _clanakkategorija.Get<List<ClanakKategorija>>(null);
                KategorijaList.Clear();
                foreach (var novost in list1)
                {
                    KategorijaList.Add(novost);
                }
            }
            if (Kategorija != null)
            {
                var list = await _novostiService.Get<IEnumerable<Clanak>>(new ClanakSearchRequest { KategorijaId=Kategorija.ClanciKategorijaId });
                NovostiList.Clear();
                foreach (var novost in list)
                {
                    NovostiList.Add(novost);
                }
            }
            else
            {
                var list = await _novostiService.Get<IEnumerable<Clanak>>(null);
                NovostiList.Clear();
                foreach (var novost in list)
                {
                    NovostiList.Add(novost);
                }
            }
        }
    }
}
