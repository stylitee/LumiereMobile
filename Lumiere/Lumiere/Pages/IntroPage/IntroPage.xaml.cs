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
    public partial class IntroPage : ContentPage
    {
        public IntroPage()
        {
            InitializeComponent();

            var assembly = typeof(IntroPage);

            imgLogo.Source = ImageSource.FromResource("Lumiere.Assets.Images.Logo.png",assembly);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(5000);
            await this.Navigation.PushAsync(new LoginPage());
        }
    }
}