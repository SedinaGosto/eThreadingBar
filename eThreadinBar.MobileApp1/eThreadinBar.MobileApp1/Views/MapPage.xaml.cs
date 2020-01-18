using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
//using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace eThreadinBar.MobileApp1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            //var map = new Map(MapSpan.FromCenterAndRadius(new Position(43.3374057, 17.809149), Distance.FromMiles(0.5)))
            //{
            //    IsShowingUser = true,
            //    VerticalOptions = LayoutOptions.FillAndExpand
            //};
            //var positon = new Position(43.3374057, 43.3374057);
            //var pin = new Pin
            //{
            //    Type = PinType.Place,
            //    Position = positon,
            //    Label = "Threading bar d.o.o"
            //};
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
         
            if (Device.RuntimePlatform == Device.iOS)
            {
                // https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                await Launcher.OpenAsync("http://maps.apple.com/?q=Franjevačka+13A,+Mostar+88000");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // open the maps app directly
                await Launcher.OpenAsync("geo:0,0?q=Franjevačka 13A, Mostar 88000");
            }
            else if (Device.RuntimePlatform == Device.UWP)
            {
                await Map.OpenAsync(43.3374057, 17.809149, new MapLaunchOptions
                {
                    Name = "Threading bar d.o.o",
                    NavigationMode = NavigationMode.None
                });
            }

        }

    }
}