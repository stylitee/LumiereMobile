using Lumiere.Pages.PageParts;
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
    public partial class QRAmountPage : ContentPage
    {
        public QRAmountPage()
        {
            InitializeComponent();
            lblCompany.Text = lblCompany.Text + PayQr.Company;
        }

        private void btnPay_Clicked(object sender, EventArgs e)
        {
            try
            {
                if(txtAmountPayed.Text == "0")
                {
                    DisplayAlert("Ops", "Payment cannot be zero", "Okay");
                }
                else
                {
                    string firstTry = Balance.currentBalance.Replace("₱", string.Empty);
                    if (double.Parse(firstTry) >= double.Parse(txtAmountPayed.Text))
                    {
                        DisplayAlert("Transaction Complete", "You paid ₱" + txtAmountPayed.Text + " at " + PayQr.Company, "Okay");
                    }
                    else
                    {
                        DisplayAlert("Ops", "Insufficient balance", "Okay");
                    }
                }
            }
            catch (Exception)
            {
                DisplayAlert("Ops", "Please enter digit", "Okay");
            }
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home());
        }
    }
}