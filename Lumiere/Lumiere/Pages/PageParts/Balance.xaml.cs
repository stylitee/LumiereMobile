using Lumiere.Model;
using Lumiere.Pages.IntroPage;
using Lumiere.Pages.PageFunctions;
using SQLite;
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
        public static string currentBalance;
        public static string transactDesc;
        public Balance()
        {
            InitializeComponent();
            
            var assembly = typeof(Balance);

            loadData();
            loadHistory();
            imgCashin.Source = ImageSource.FromResource("Lumiere.Assets.Images.Cash-in.png", assembly);
            imgBuyLoad.Source = ImageSource.FromResource("Lumiere.Assets.Images.Buy-load.png", assembly);
            imgPayBills.Source = ImageSource.FromResource("Lumiere.Assets.Images.Pay-Bills.png", assembly);
            imgSendMoney.Source = ImageSource.FromResource("Lumiere.Assets.Images.Send-money.png", assembly);
            
            imgBankTransfer.Source = ImageSource.FromResource("Lumiere.Assets.Images.Bank-Transfer.png", assembly);
            imgGamingPins.Source = ImageSource.FromResource("Lumiere.Assets.Images.game.png", assembly);
            imgPayQR.Source = ImageSource.FromResource("Lumiere.Assets.Images.qr-code.png", assembly);
            imgShowMore.Source = ImageSource.FromResource("Lumiere.Assets.Images.ellipsis.png", assembly);
        }

        public void loadData()
        {
            //remove user table later here
            SQLiteConnection conn = new SQLiteConnection(App.database_location);
            conn.CreateTable<Users>();
            var result = conn.Query<Users>("Select * FROM Users WHERE user_id = ?", LoginPage.userEntered_ID);
            foreach (var s in result)
            {
                lblBalance.Text = "₱"+s.balance;
            }
            conn.Close();
            currentBalance = lblBalance.Text;
        }

        public void loadHistory()
        {
            btnSeeHistory.IsEnabled = false;
            SQLiteConnection conn = new SQLiteConnection(App.database_location);
            conn.CreateTable<Transaction>();
            var result = conn.Table<Transaction>().ToList();

            if(result.Count() == 0)
            {
                lblHistoryData.Text = "No History Data";
            }
            else
            {
                if (result.Count() == 1)
                {
                    lblHistoryData.Text = result[result.Count() - 1].description;
                    lblHistoryData1.Text = "";
                    lblHistoryData2.Text = "";
                }
                else if(result.Count() == 2)
                {
                    lblHistoryData.Text = result[result.Count() - 1].description;
                    lblHistoryData1.Text = result[result.Count() - 2].description;
                    lblHistoryData2.Text = "";
                }
                else if(result.Count() == 3)
                {
                    lblHistoryData.Text = result[result.Count() - 1].description;
                    lblHistoryData1.Text = result[result.Count() - 2].description;
                    lblHistoryData2.Text = result[result.Count() - 3].description;
                }
                else if(result.Count() == 4)
                {
                    lblHistoryData.Text = result[result.Count() - 1].description;
                    lblHistoryData1.Text = result[result.Count() - 2].description;
                    lblHistoryData2.Text = result[result.Count() - 3].description;
                    lblHistoryData3.Text = result[result.Count() - 4].description;
                }
                else
                {
                    btnSeeHistory.IsEnabled = true;
                }
                    
            }
            
            conn.Close();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            loadData();
            loadHistory();
        }


        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //CASHIN
            transactDesc = "Cash in through ";
            Navigation.PushAsync(new CashinPage());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            ///SEND MONEY
            transactDesc = "Sent money to ";
            Navigation.PushAsync(new SendMoneyPage());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            //paybills
            transactDesc = "Payed Bills in ";
            Navigation.PushAsync(new PayBillsPage());
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            //buyload
            transactDesc = "Bought load in ";
            Navigation.PushAsync(new ChooseLoadPage());
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            //banktransfer
            transactDesc = "Transfered Money in ";
            Navigation.PushAsync(new BankTransferPage());
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            //gamingpins

        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            //payQR
            Navigation.PushAsync(new PayQr());
        }
    }
}