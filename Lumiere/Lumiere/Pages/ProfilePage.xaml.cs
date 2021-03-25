using System;
using System.Collections.Generic;
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
        public ProfilePage()
        {
            InitializeComponent();
            var assembly = typeof(ProfilePage);
            imgProfile.Source = ImageSource.FromResource("Lumiere.Assets.Images.image_unavailable.png", assembly);
        }

        async void btnAddImage_Clicked(object sender, EventArgs e)
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Please pick profile picture"
            });

            var stream = await result.OpenReadAsync();
            imgProfile.Source = ImageSource.FromStream(() => stream);
        }
    }
}