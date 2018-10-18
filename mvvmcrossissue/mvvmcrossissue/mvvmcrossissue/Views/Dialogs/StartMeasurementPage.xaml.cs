using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using mvvmcrossissue.ViewModels.Dialogs;
using Xamarin.Forms.Xaml;

namespace mvvmcrossissue.Views.Dialogs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxModalPresentation(WrapInNavigationPage = false)]
    public partial class StartMeasurementPage : MvxContentPage<StartMeasurementViewModel>
    {
        public StartMeasurementPage()
        {
            InitializeComponent();
        }
    }
}