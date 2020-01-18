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
    public partial class TerminiPage : ContentPage
    {
        private TerminiViewModel model = null;

        public TerminiPage(Korisnici u)
        {

            InitializeComponent();
            BindingContext = model = new TerminiViewModel()
            {
                _uposlenik = u
            };

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            if(model.termini.Count==0)
            {
                await Application.Current.MainPage.DisplayAlert("Zao nam je!", "Trenutno nemamo slobodnih termina", "OK");
                await Navigation.PushAsync(new UposleniciPage());

            }

        }

        private async  void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Termin;
            await Navigation.PushAsync(new RezervacijaPage(item));
        }
    }
}