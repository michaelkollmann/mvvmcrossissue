using MvvmCross.Commands;
using MvvmCross.Localization;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using mvvmcrossissue.ViewModels.Device;
using System.Threading;
using System.Threading.Tasks;

namespace mvvmcrossissue.ViewModels.MainChildren
{
    public class DevicesViewModel : MvxNavigationViewModel, IMvxLocalizedTextSourceOwner
    {

        #region Properties
        public IMvxLanguageBinder LocalizedTextSource => new MvxLanguageBinder("", nameof(DevicesViewModel));
        #endregion

        #region Constructor
        public DevicesViewModel(
            IMvxLogProvider logProvider,
            IMvxNavigationService navigationService)
            : base(logProvider, navigationService)
        {
        }
        #endregion

        #region Commands
        private IMvxCommand _scan;

        public IMvxCommand Scan
        {
            get
            {
                if (_scan == null)
                {
                    _scan = new MvxCommand(DoScan);
                }

                return _scan;
            }
        }

        async void DoScan()
        {
            // navigate
            await NavigationService.Navigate<DeviceTabsRootViewModel>();
        }
        #endregion
    }
}
