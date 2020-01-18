using eThreadinBar.MobileApp1.ViewModels;
using eThreadingBar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eThreadinBar.MobileApp1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KlijentNotifikacijaPage : ContentPage
    {
        private KlijentNotifikacijaViewModel model = null;

        public KlijentNotifikacijaPage()
        {
            InitializeComponent();
            BindingContext = model = new KlijentNotifikacijaViewModel();
           
        }
    

     
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.Init();

        }
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as KlijentNotifikacijaList;
           
            await model.Procitano(item);
      

        }
    }
}