using Lumiere.Model;
using Lumiere.Pages.IntroPage;
using Lumiere.Pages.PageParts;
using SQLite;
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
    public partial class Cashin_data : ContentPage
    {
        public Cashin_data()
        {
            InitializeComponent();
        }

        private void btnCashIn_Clicked(object sender, EventArgs e)
        {
            string firstTry = Balance.currentBalance.Replace("₱", string.Empty);
            double totalBalance = double.Parse(firstTry) + double.Parse(txtAmountCashin.Text);
            try
            {
                SQLiteConnection conn = new SQLiteConnection(App.database_location);
                var result = conn.Query<Users>("Select * FROM Users WHERE user_id = ?", LoginPage.userEntered_ID);
                string fullNames = "", isVerifieds = "", passwords = "", addresss = "", phonenumbers = "";
                foreach (var x in result)
                {
                    fullNames = x.fullName;
                    isVerifieds = x.isVerified;
                    passwords = x.password;
                    addresss = x.address;
                    phonenumbers = x.phoneNumber;
                }
                conn.Close();
                SQLiteConnection connect = new SQLiteConnection(App.database_location);
                Users user = new Users()
                {
                    user_id = LoginPage.userEntered_ID,
                    fullName = fullNames,
                    password = passwords,
                    address = addresss,
                    phoneNumber = phonenumbers,
                    balance = totalBalance.ToString() + ".00",
                };

                
                
                connect.Update(user);
                connect.Close();
                DisplayAlert("Confirmation", "The amount " + txtAmountCashin.Text +" has been succesfully added to your account!", "okay");
                


                Transaction trans = new Transaction()
                {
                    date = DateTime.Now.ToShortDateString(),
                    time = DateTime.Now.ToShortTimeString(),
                    user_id = LoginPage.userEntered_ID,
                    description = Balance.transactDesc + txtAmountCashin.Text
                };

                SQLiteConnection connected = new SQLiteConnection(App.database_location);
                connected.CreateTable<Transaction>();
                connected.Insert(trans);
                connected.Close();
                Navigation.PushAsync(new Home());

            }
            catch (Exception)
            {
                DisplayAlert("Error","Error","Okay");
            }
        }
    }
}