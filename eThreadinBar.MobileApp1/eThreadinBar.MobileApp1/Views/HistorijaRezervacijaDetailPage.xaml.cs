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
    public partial class HistorijaRezervacijaDetailPage : ContentPage
    {
        private HistorijaRezervacijaDetailViewModel model = null;

        public HistorijaRezervacijaDetailPage(Rezervacija r)
        {
            InitializeComponent();
            BindingContext = model = new HistorijaRezervacijaDetailViewModel()
            {
                rezervacija = r
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            if (!model.IsBusy)
            {
                AktivnaRezervacija.BackgroundColor = Color.Gray;
                TextNapomena.Text = "Rezervacija se može otkazati samo 3 dana prije!";
                TextNapomena.TextColor = Color.Red;
            }
        

        }

        private async void AktivnaRezervacija_Clicked(object sender, EventArgs e)
        {
           await model.Delete();
            await Navigation.PopAsync();


        }
    }
}