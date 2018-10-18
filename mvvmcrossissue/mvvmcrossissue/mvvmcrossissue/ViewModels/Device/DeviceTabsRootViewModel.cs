using MvvmCross.Commands;
using MvvmCross.Localization;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using mvvmcrossissue.ViewModels.Device.Tabs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mvvmcrossissue.ViewModels.Device
{
    public class DeviceTabsRootViewModel : MvxNavigationViewModel, IMvxLocalizedTextSourceOwner
    {
        #region Properties
        public IMvxLanguageBinder LocalizedTextSource => new MvxLanguageBinder("", nameof(DeviceTabsRootViewModel));
        #endregion

        #region Constructor
        public DeviceTabsRootViewModel(
            IMvxLogProvider logProvider,
            IMvxNavigationService navigationService)
            : base(logProvider, navigationService)
        {
        }
        #endregion

        private bool _firstTime;

        public override async void ViewAppearing()
        {
            base.ViewAppearing();
            if (!_firstTime)
            {
                _firstTime = true;
                await NavigationService.Navigate<MeasurementTabViewModel>();
                await NavigationService.Navigate<ConfigurationTabViewModel>();
            }
        }
    }
}
