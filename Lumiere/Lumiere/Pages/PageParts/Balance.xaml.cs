using Lumiere.Pages.PageFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumiere.Pages.PageParts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Balance : ContentPage
    {
        public Balance()
        {
            InitializeComponent();
            
            var assembly = typeof(Balance);

            //firstpart
            
            imgCashin.Source = ImageSource.FromResource("Lumiere.Assets.Images.Cash-in.png", assembly);
            imgBuyLoad.Source = ImageSource.FromResource("Lumiere.Assets.Images.Buy-load.png", assembly);
            imgPayBills.Source = ImageSource.FromResource("Lumiere.Assets.Images.Pay-Bills.png", assembly);
            imgSendMoney.Source = ImageSource.FromResource("Lumiere.Assets.Images.Send-money.png", assembly);
            /*secondpart
            imgBankTransfer.Source = ImageSource.FromResource("Lumiere.Assets.Images.Bank-Transfer.png", assembly);
            imgGamingPins.Source = ImageSource.FromResource("Lumiere.Assets.Images.game.png", assembly);
            imgPayQR.Source = ImageSource.FromResource("Lumiere.Assets.Images.qr-code.png", assembly);
            imgShowMore.Source = ImageSource.FromResource("Lumiere.Assets.Images.ellipsis.png", assembly);*/
        }


        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //CASHIN
            Navigation.PushAsync(new CashinPage());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            ///SEND MONEY
            ///
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            //paybills
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            //buyload
        }
    }
}