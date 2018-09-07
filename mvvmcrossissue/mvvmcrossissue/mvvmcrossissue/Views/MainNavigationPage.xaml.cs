using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using mvvmcrossissue.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvmcrossissue.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Master)]
    public partial class MainNavigationPage : MvxContentPage<MainNavigationViewModel>
    {
        public MainNavigationPage()
        {
            InitializeComponent();
        }

        private void MenuItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (Application.Current.MainPage is MasterDetailPage mdp)
            {
                mdp.IsPresented = false;
            }
            else if (Application.Current.MainPage is NavigationPage np && np.CurrentPage is MasterDetailPage nmdp)
            {
                nmdp.IsPresented = false;
            }
        }
    }
}
