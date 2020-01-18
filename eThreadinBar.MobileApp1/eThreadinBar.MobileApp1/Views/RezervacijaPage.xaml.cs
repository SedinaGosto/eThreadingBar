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
    public partial class RezervacijaPage : ContentPage
    {
        private RezervacijaViewModel model = null;

        public RezervacijaPage(Termin u)
        {

            InitializeComponent();
            BindingContext = model = new RezervacijaViewModel()
            {
                Termin = u
            };
            

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            
          
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (this.Tretmani.SelectedItem == null)
            {
                tretmanigreska.Text = "** Morate odabrati tretman! **";
                tretmanigreska.IsVisible = true;



            }
            else
            {
                tretmanigreska.Text = " ";
                tretmanigreska.IsVisible = false;


            }
            if (!tretmanigreska.IsVisible)
            {
                Tretman g = this.Tretmani.SelectedItem as Tretman;
                model.TretmanID = g.TretmanId;
                await model.RezervacijaTask();
                await Navigation.PushAsync(new UposleniciPage());
            }
        }
    }
}