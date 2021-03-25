using Lumiere.Pages;
using Lumiere.Pages.IntroPage;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumiere
{
    public partial class App : Application
    {
        public static string database_location = string.Empty;
        public App(string databaseLocation)
        {
            InitializeComponent();
            //MainPage = new LoginPage();
            MainPage = new NavigationPage(new IntroPage());
            database_location = databaseLocation;
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
