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
		public PayQr ()
		{
			InitializeComponent ();
		}

        private void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
			Device.BeginInvokeOnMainThread(() =>
			{
				lblResult.Text = "BARCODE SCANNI COMPLETE: " + result.Text + Environment.NewLine +
				"(type: " + result.BarcodeFormat.ToString() + ")";
			});
        }
    }
}