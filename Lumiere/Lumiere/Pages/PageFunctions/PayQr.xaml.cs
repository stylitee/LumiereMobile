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
	public partial class PayQr : ContentPage
	{
		public static string Company;
		int company_id;
		public PayQr ()
		{
			InitializeComponent ();
		}

        private void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
			Device.BeginInvokeOnMainThread(() =>
			{
                try
                {
					company_id = int.Parse(result.Text);

					if (company_id == 1)
					{
						Company = "Globe";
						Navigation.PushAsync(new QRAmountPage());
					}
					else if (company_id == 2)
					{
						Company = "SM City Naga";
						Navigation.PushAsync(new QRAmountPage());
					}
					else if (company_id == 3)
					{
						Company = "Smart";
						Navigation.PushAsync(new QRAmountPage());
					}
					else if (company_id == 4)
					{
						Company = "Puregold";
						Navigation.PushAsync(new QRAmountPage());
					}
					else
					{
						DisplayAlert("Ops", "Sorry, company is not yet registered!", "Okay");
					}
				}
                catch (Exception)
                {
					DisplayAlert("Ops", "Result unknown please use a different QR Code", "Okay");
				}
				
			});
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new Home());
        }
    }
}