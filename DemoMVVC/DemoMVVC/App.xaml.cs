using DemoMVVC.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoMVVC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.Task();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
