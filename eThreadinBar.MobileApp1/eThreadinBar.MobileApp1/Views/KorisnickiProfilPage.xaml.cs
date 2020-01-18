using eThreadinBar.MobileApp1.ViewModels;
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
    public partial class KorisnickiProfilPage : ContentPage
    {
        private KorisnickiProfilViewModel model = null;

        public KorisnickiProfilPage()
        {
            InitializeComponent();
            BindingContext = model = new KorisnickiProfilViewModel();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KorisnickiProfilUredi());

        }
    }
}