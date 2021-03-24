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
                Users user = new Users()
                {
                    user_id = LoginPage.userEntered_ID,
                    balance = totalBalance.ToString() + ".00",
                };

                SQLiteConnection conn = new SQLiteConnection(App.database_location);
                conn.Update(user);
                conn.Close();
                DisplayAlert("Confirmation", "The amount " + txtAmountCashin.Text +" has been succesfully added to your account!", "okay");
                Navigation.PushAsync(new Home());
            }
            catch (Exception)
            {
                DisplayAlert("Error","Error","Okay");
            }
        }
    }
}