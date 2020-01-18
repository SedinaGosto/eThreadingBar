using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eThreadinBar.MobileApp1.Services;
using eThreadinBar.MobileApp1.Views;

namespace eThreadinBar.MobileApp1
{
    public partial class App : Application
    {
        public string brojNotifikacija { get; set; }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new MainPage();
            MainPage = new LoginPage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
