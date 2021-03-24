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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            var assembly = typeof(IntroPage);

            imgLogo.Source = ImageSource.FromResource("Lumiere.Assets.Images.Logo.png", assembly);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //loginButton
            btnLogin.BackgroundColor = Color.FromRgb(179, 0, 45);
            lblLogin.BackgroundColor = Color.Gray;
            bool phoneNumber = string.IsNullOrEmpty(txtPassword.Text);
            bool passWord = string.IsNullOrEmpty(txtPassword.Text);

            if (phoneNumber || passWord) { DisplayAlert("Ops", "Please complete all the fields", "Okay"); }
            else
            {
                if (txtPhoneNumber.Text == "9100252612" && txtPassword.Text == "password")
                {
                    Navigation.PushAsync(new Home());
                }
                else
                {
                    DisplayAlert("Ops", "Invalid credentials", "Try again");
                }
            }
           
            btnLogin.BackgroundColor = Color.FromRgb(157, 0, 39);
            lblLogin.BackgroundColor = Color.White;
        }
    }
}