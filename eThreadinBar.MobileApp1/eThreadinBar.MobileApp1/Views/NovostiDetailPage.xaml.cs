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
    public partial class NovostiDetailPage : ContentPage
    {
        private NovostiDetailViewModel novostiDetail = null;
        private Clanak c = null;
        public NovostiDetailPage(Clanak _clanak)
        {
            InitializeComponent();
            BindingContext = novostiDetail = new NovostiDetailViewModel()
            {
               clanak = _clanak
            };
            c= _clanak;
        }
    }
}