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
    public partial class HistorijaRezervacijaPage : ContentPage
    {
        private HistorijaRezervacijaViewModel model = null;

        public HistorijaRezervacijaPage()
        {
            InitializeComponent();
            BindingContext = model = new HistorijaRezervacijaViewModel();
           
        
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            if (model.rezervacijeList.Count == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Threading bar d.o.o!", "Trenutno nemate rezervisanih termina!", "OK");
                await Navigation.PopAsync();

            }

        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Rezervacija;
            await Navigation.PushAsync(new HistorijaRezervacijaDetailPage(item));
        }
    }
}