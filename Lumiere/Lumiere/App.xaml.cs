using Lumiere.Pages;
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
            MainPage = new Home();

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
