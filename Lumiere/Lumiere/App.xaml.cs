using Lumiere.Pages;
using Lumiere.Pages.IntroPage;
using Lumiere.Pages.PageFunctions;
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
            MainPage = new NavigationPage(new GamingPins());
            database_location = databaseLocation;

            //to prevent user going to the loginpage whenver they pressed the back butoon in android
            //Application.Current.MainPage = new Home();
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
