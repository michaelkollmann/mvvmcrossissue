using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using mvvmcrossissue.ViewModels.MainChildren;
using Xamarin.Forms.Xaml;

namespace mvvmcrossissue.Views.MainChildren
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Detail, NoHistory = true)]
    public partial class DataManagementPage : MvxContentPage<DataManagementViewModel>
    {
        public DataManagementPage()
        {
            InitializeComponent();
        }
    }
}