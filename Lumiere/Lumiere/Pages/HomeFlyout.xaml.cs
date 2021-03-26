using Lumiere.Pages.PageFunctions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumiere.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeFlyout : ContentPage
    {
        public ListView ListView;

        public HomeFlyout()
        {
            InitializeComponent();

            BindingContext = new HomeFlyoutViewModel();
            ListView = MenuItemsListView;

            var assembly = typeof(HomeFlyout);
        }

        class HomeFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomeFlyoutMenuItem> MenuItems { get; set; }

            public HomeFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<HomeFlyoutMenuItem>(new[]
                {
                    new HomeFlyoutMenuItem { Id = 0, Title = "Home",TargetType = typeof(Home)},
                    new HomeFlyoutMenuItem { Id = 1, Title = "Profile", TargetType = typeof(ProfilePage) },
                    new HomeFlyoutMenuItem { Id = 2, Title = "Settings", TargetType = typeof(Unavailable)},
                    new HomeFlyoutMenuItem { Id = 3, Title = "About" , TargetType = typeof(AboutPage)},
                    new HomeFlyoutMenuItem { Id = 4, Title = "Logout", TargetType = typeof(LogoutPage) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}