using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using mvvmcrossissue.ViewModels.Device;
using Xamarin.Forms.Xaml;

namespace mvvmcrossissue.Views.Device
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxTabbedPagePresentation(TabbedPosition.Root)]
    public partial class DevicePage : MvxTabbedPage<DeviceTabsRootViewModel>
    {
        public DevicePage()
        {
            InitializeComponent();
        }
    }
}