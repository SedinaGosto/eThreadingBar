using eThreadingBar.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eThreadinBar.MobileApp1.ViewModels
{
    public class BrojNotifikacijaViewModel: BaseViewModel
    {

        private readonly APIService _notifikacija = new APIService("PoslataNotifikacija");
     
    
        public BrojNotifikacijaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {

            var lista = await _notifikacija.Get<List<PoslataNotifikacija>>(null);
            Brojnotifikacija = lista.Count.ToString();
         
        }
        string brojnotifikacija = string.Empty;
        public string Brojnotifikacija
        {
            get { return brojnotifikacija; }
            set { SetProperty(ref brojnotifikacija, value); }
        }
      
    }
}
