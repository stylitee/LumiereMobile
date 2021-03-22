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
    public partial class CashinPage : ContentPage
    {
        public CashinPage()
        {
            InitializeComponent();

            var assembly = typeof(CashinPage);

            imgPalawan.Source = ImageSource.FromResource("Lumiere.Assets.CompanyPartnersImages.palawan.png", assembly);
            imgMiniStop.Source = ImageSource.FromResource("Lumiere.Assets.CompanyPartnersImages.711.png", assembly);
            imgSevenEleven.Source = ImageSource.FromResource("Lumiere.Assets.CompanyPartnersImages.MINISTOP-LOGO.png", assembly);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //palawan
            Navigation.PushAsync(new Cashin_data());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            //711
            Navigation.PushAsync(new Cashin_data());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            //ministop
            Navigation.PushAsync(new Cashin_data());
        }
    }
}