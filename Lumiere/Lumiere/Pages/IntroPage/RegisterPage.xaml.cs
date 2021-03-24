using Lumiere.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumiere.Pages.IntroPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //labelLogin
            Navigation.PushAsync(new LoginPage());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            //ButtonRegister
            bool name = string.IsNullOrEmpty(txtFullname.Text);
            bool address = string.IsNullOrEmpty(txtAddress.Text);
            bool password = string.IsNullOrEmpty(txtPassword.Text);
            bool confirmPass = string.IsNullOrEmpty(txtConfirmPassword.Text);
            bool phoneNumber = string.IsNullOrEmpty(txtPhoneNumber.Text);
            int rows = 0;

            if(name || address || password || confirmPass || phoneNumber)
            {
                DisplayAlert("Ops","Please provide info all the fields","Okay");
            }
            else
            {
                if(txtPassword.Text != txtConfirmPassword.Text)
                {
                    DisplayAlert("Ops", "Password is not match", "okay");
                }
                else
                {
                    Users user = new Users()
                    {
                        fullName = txtFullname.Text,
                        address = txtAddress.Text,
                        phoneNumber = txtPhoneNumber.Text,
                        password = txtConfirmPassword.Text,
                        isVerified = "False",
                        balance = "0.00"
                    };

                    SQLiteConnection conn = new SQLiteConnection(App.database_location);
                    conn.CreateTable<Users>();
                    rows = conn.Insert(user);
                    conn.Close();

                    if(rows > 0)
                    {
                        DisplayAlert("Confirmation", "Account succesfully registered!", "Okay");
                    }
                    else
                    {
                        DisplayAlert("Confirmation", "Account registration failed!", "Okay");
                    }
                }
            }
            
        }
    }
}