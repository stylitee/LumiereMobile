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

            imgCashin.Source = ImageSource.FromResource("Lumiere.Assets.Images.Cash-in.png", assembly);
            imgBuyLoad.Source = ImageSource.FromResource("Lumiere.Assets.Images.Buy-load.png", assembly);
            imgPayBills.Source = ImageSource.FromResource("Lumiere.Assets.Images.Pay-Bills.png", assembly);
            imgSendMoney.Source = ImageSource.FromResource("Lumiere.Assets.Images.Send-money.png", assembly);
        }
    }
}