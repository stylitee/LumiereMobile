using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumiere.Pages.PageFunctions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseLoadPage : ContentPage
    {
        public static string loadPromo;
        public static string loadAmount;
        public ChooseLoadPage()
        {
            InitializeComponent();

            var assembly = typeof(ChooseLoadPage);

            imgGlobeLogo.Source = ImageSource.FromResource("Lumiere.Assets.CompanyPartnersImages.globe_logo.png", assembly);
            imgSmartLogo.Source = ImageSource.FromResource("Lumiere.Assets.CompanyPartnersImages.logo_smart.png", assembly);
        }
        

        private void btnGlobeReg10_Clicked(object sender, EventArgs e)
        {
            loadAmount = "10";
            loadPromo = "Globe Regular 10";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnGlobeReg20_Clicked(object sender, EventArgs e)
        {
            loadAmount = "20";
            loadPromo = "Globe Regular 20";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnGlobeReg50_Clicked(object sender, EventArgs e)
        {
            loadAmount = "50";
            loadPromo = "Globe Regular 50";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnGlobeReg100_Clicked(object sender, EventArgs e)
        {
            loadAmount = "100";
            loadPromo = "Globe Regular 100";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnGlobeReg300_Clicked(object sender, EventArgs e)
        {
            loadAmount = "300";
            loadPromo = "Globe Regular 300";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnGlobeReg500_Clicked(object sender, EventArgs e)
        {
            loadAmount = "500";
            loadPromo = "Globe Regular 500";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnGlobeReg1000_Clicked(object sender, EventArgs e)
        {
            loadAmount = "1000";
            loadPromo = "Globe Regular 1000";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnSmartReg10_Clicked(object sender, EventArgs e)
        {
            loadAmount = "10";
            loadPromo = "Smart Regular 10";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnSmartReg20_Clicked(object sender, EventArgs e)
        {
            loadAmount = "20";
            loadPromo = "Smart Regular 20";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnSmartReg50_Clicked(object sender, EventArgs e)
        {
            loadAmount = "50";
            loadPromo = "Smart Regular 50";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnSmartReg100_Clicked(object sender, EventArgs e)
        {
            loadAmount = "100";
            loadPromo = "Smart Regular 100";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnSmartReg300_Clicked(object sender, EventArgs e)
        {
            loadAmount = "300";
            loadPromo = "Smart Regular 300";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnSmartReg500_Clicked(object sender, EventArgs e)
        {
            loadAmount = "500";
            loadPromo = "Smart Regular 500";
            Navigation.PushAsync(new PhoneLoadInfo());
        }

        private void btnSmartReg1000_Clicked(object sender, EventArgs e)
        {
            loadAmount = "1000";
            loadPromo = "Smart Regular 1000";
            Navigation.PushAsync(new PhoneLoadInfo());
        }
    }
}