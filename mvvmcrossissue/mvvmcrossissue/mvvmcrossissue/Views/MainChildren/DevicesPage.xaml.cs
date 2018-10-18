using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using mvvmcrossissue.ViewModels.MainChildren;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvmcrossissue.Views.MainChildren
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Detail, NoHistory = true)]
    public partial class DevicesPage : MvxContentPage<DevicesViewModel>
    {
        public DevicesPage()
        {
            InitializeComponent();
        }
    }
}