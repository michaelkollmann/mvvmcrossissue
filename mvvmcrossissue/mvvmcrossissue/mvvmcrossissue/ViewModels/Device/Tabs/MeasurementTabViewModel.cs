using MvvmCross.Commands;
using MvvmCross.Localization;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using mvvmcrossissue.ViewModels.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvvmcrossissue.ViewModels.Device.Tabs
{
    public class MeasurementTabViewModel : MvxNavigationViewModel, IMvxLocalizedTextSourceOwner
    {
        #region Properties
        public IMvxLanguageBinder LocalizedTextSource => new MvxLanguageBinder("", nameof(DeviceTabsRootViewModel));
        #endregion

        #region Constructor
        public MeasurementTabViewModel(
            IMvxLogProvider logProvider,
            IMvxNavigationService navigationService)
            : base(logProvider, navigationService)
        {
        }
        #endregion

        #region Commands
        private IMvxCommand _startMeasurement;

        public IMvxCommand StartMeasurement
        {
            get
            {
                if (_startMeasurement == null)
                {
                    _startMeasurement = new MvxCommand(DoStartMeasurement);
                }
                return _startMeasurement;
            }
        }

        async void DoStartMeasurement()
        {
            await NavigationService.Navigate<StartMeasurementViewModel>();
        }
        #endregion
    }
}
