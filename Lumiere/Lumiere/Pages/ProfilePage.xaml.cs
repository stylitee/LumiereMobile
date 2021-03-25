using Lumiere.Model;
using Lumiere.Pages.IntroPage;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumiere.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        string fullNames = "", isVerifieds = "", passwords = "", addresss = "", phonenumbers = "", balance = "", image = null;

        

        public ProfilePage()
        {
            InitializeComponent();
            
            SQLiteConnection conn = new SQLiteConnection(App.database_location);
            var rows = conn.Query<Users>("Select * FROM Users WHERE user_id = ?", LoginPage.userEntered_ID);

            foreach (var x in rows)
            {
                fullNames = x.fullName;
                isVerifieds = x.isVerified;
                passwords = x.password;
                addresss = x.address;
                phonenumbers = x.phoneNumber;
                balance = x.balance;
                image = x.profile_image;
            }
            conn.Close();

            if(image != null)
            {
                byte[] byteArray = Encoding.ASCII.GetBytes(image);
                MemoryStream stream = new MemoryStream(byteArray);
                imgProfile.Source = ImageSource.FromStream(() => stream);

                txtFullName.Text = fullNames;
                txtAddress.Text = addresss;
                txtPassword.Text = passwords;
                txtPhoneNumber.Text = phonenumbers;
            }
            else
            {
                var assembly = typeof(ProfilePage);
                imgProfile.Source = ImageSource.FromResource("Lumiere.Assets.Images.image_unavailable.png", assembly);
                txtFullName.Text = fullNames;
                txtAddress.Text = addresss;
                txtPassword.Text = passwords;
                txtPhoneNumber.Text = phonenumbers;
            }
        }

        async void btnAddImage_Clicked(object sender, EventArgs e)
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Please pick profile picture"
            });

            var stream = await result.OpenReadAsync();
            StreamReader reader = new StreamReader(stream);
            string text = reader.ReadToEnd();
            image = text;
            imgProfile.Source = ImageSource.FromStream(() => stream);

           
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            try
            {

                Users user = new Users()
                {
                    user_id = LoginPage.userEntered_ID,
                    fullName = txtFullName.Text,
                    password = txtPassword.Text,
                    address = txtAddress.Text,
                    phoneNumber = txtPhoneNumber.Text,
                    balance = balance,
                    profile_image = image
                };
                
                SQLiteConnection connection = new SQLiteConnection(App.database_location);
                connection.Update(user);
                connection.Close();

                DisplayAlert("Confirmation", "Account changes succesful", "Okay");
                Navigation.PushAsync(new Home());
            }
            catch (Exception)
            {

                throw;
            }
            


        }
    }
}