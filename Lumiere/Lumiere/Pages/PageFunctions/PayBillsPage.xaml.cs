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
    public partial class PayBillsPage : ContentPage
    {
        public PayBillsPage()
        {
            InitializeComponent();

            cmbCompany.Items.Add("Globe");
            cmbCompany.Items.Add("Smart");
            cmbCompany.Items.Add("PLDT");
            cmbCompany.Items.Add("Converge");
            cmbCompany.Items.Add("DITO");
            cmbCompany.Items.Add("Metropolitan Naga Water District");
            cmbCompany.Items.Add("Casureco");
        }
    }
}