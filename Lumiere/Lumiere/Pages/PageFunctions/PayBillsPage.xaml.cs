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
    public partial class PayBillsPage : ContentPage
    {
        public PayBillsPage()
        {
            InitializeComponent();

            cmbCompany.Items.Add("Globe");
            cmbCompany.Items.Add("Smart");
            cmbCompany.Items.Add("PLDT");
            cmbCompany.Items.Add("Converge");
            cmbCompany.Items.Add("DITO");
            cmbCompany.Items.Add("Metropolitan Naga Water District");
            cmbCompany.Items.Add("Casureco");
        }

        private void btnPay_Clicked(object sender, EventArgs e)
        {
            string firstTry = Balance.currentBalance.Replace("₱", string.Empty);
            if (double.Parse(firstTry) >= double.Parse(txtAmountPayed.Text))
            {
                string descriptions = Balance.transactDesc + cmbCompany.SelectedItem.ToString() ;
                double totalBalance = double.Parse(firstTry) - double.Parse(txtAmountPayed.Text);
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
                    Users user = new Users()
                    {
                        user_id = LoginPage.userEntered_ID,
                        fullName = fullNames,
                        password = passwords,
                        address = addresss,
                        phoneNumber = phonenumbers,
                        balance = totalBalance.ToString() + ".00",
                    };

                    SQLiteConnection connection = new SQLiteConnection(App.database_location);
                    connection.Update(user);
                    connection.Close();
                    DisplayAlert("Confirmation", "The amount " + txtAmountPayed.Text + " has been succesfully payed to " + cmbCompany.SelectedItem.ToString(), "okay");
                    Navigation.PushAsync(new Home());


                    Transaction trans = new Transaction()
                    {
                        date = DateTime.Now.ToShortDateString(),
                        time = DateTime.Now.ToShortTimeString(),
                        user_id = LoginPage.userEntered_ID,
                        description = descriptions
                    };

                    SQLiteConnection connect = new SQLiteConnection(App.database_location);
                    connect.CreateTable<Transaction>();
                    connect.Insert(trans);
                    connect.Close();


                }
                catch (Exception)
                {
                    DisplayAlert("Error", "Error", "Okay");
                }
            }
            else
            {
                DisplayAlert("Ops", "Insufficient Balance please top up first", "Okay");
            }

        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home());
        }
    }
}