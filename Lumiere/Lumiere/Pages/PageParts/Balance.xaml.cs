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
            //secondpart
            imgBankTransfer.Source = ImageSource.FromResource("Lumiere.Assets.Images.Bank-Transfer.png", assembly);
            imgGamingPins.Source = ImageSource.FromResource("Lumiere.Assets.Images.game.png", assembly);
            imgPayQR.Source = ImageSource.FromResource("Lumiere.Assets.Images.qr-code.png", assembly);
            imgShowMore.Source = ImageSource.FromResource("Lumiere.Assets.Images.ellipsis.png", assembly);
        }
    }
}