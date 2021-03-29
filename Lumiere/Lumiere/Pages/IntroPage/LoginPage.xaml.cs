using Lumiere.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumiere.Pages.IntroPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public static int userEntered_ID;
        public LoginPage()
        {
            InitializeComponent();
            var assembly = typeof(IntroPage);

            imgLogo.Source = ImageSource.FromResource("Lumiere.Assets.Images.Logo.png", assembly);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //loginButton
            
            bool phoneNumber = string.IsNullOrEmpty(txtPassword.Text);
            bool passWord = string.IsNullOrEmpty(txtPassword.Text);
            string dbPhoneNumber = "", dbpass = "";


            if (phoneNumber || passWord) { DisplayAlert("Ops", "Please complete all the fields", "Okay"); }
            else
            {
                //try
                //{
                    SQLiteConnection conn = new SQLiteConnection(App.database_location);
                    var result = conn.Query<Users>("Select * FROM Users WHERE phoneNumber = ?",txtPhoneNumber.Text);
                    foreach(var s in result)
                    {
                        dbPhoneNumber = s.phoneNumber;
                        dbpass = s.password;
                        userEntered_ID = s.user_id;
                    }
                    conn.Close();
                    if (txtPhoneNumber.Text == dbPhoneNumber && txtPassword.Text == dbpass)
                    {
                        Navigation.PushAsync(new Home());
                    }
                    else
                    {
                        DisplayAlert("Ops", "Invalid credentials", "Try again");
                        txtPhoneNumber.Text = "";
                        txtPassword.Text = "";
                    }

                //}
                //catch (Exception ex)
                /*{
                    DisplayAlert("Ops", "Invalid credentials", "Try again");
                    txtPhoneNumber.Text = "";
                    txtPassword.Text = "";
                }*/
            }
          
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}