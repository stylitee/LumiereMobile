using Lumiere.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Nobile-Bold.ttf")]
[assembly: ExportFont("Nobile-BoldItalic.ttf")]
[assembly: ExportFont("Nobile-Italic.ttf")]
[assembly: ExportFont("Nobile-Medium.ttf")]
[assembly: ExportFont("Nobile-MediumItalic.ttf")]
[assembly: ExportFont("Nobile-Regular.ttf")]
[assembly: ExportFont("Pacifico.ttf")]


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