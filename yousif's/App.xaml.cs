using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using yousif_s.Services;
using yousif_s.Views;

namespace yousif_s
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
