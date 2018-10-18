using MvvmCross.Localization;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvvmcrossissue.ViewModels.Device.Tabs
{
    public class ConfigurationTabViewModel : MvxNavigationViewModel, IMvxLocalizedTextSourceOwner
    {
        #region Properties
        public IMvxLanguageBinder LocalizedTextSource => new MvxLanguageBinder("", nameof(DeviceTabsRootViewModel));
        #endregion

        #region Constructor
        public ConfigurationTabViewModel(
            IMvxLogProvider logProvider,
            IMvxNavigationService navigationService)
            : base(logProvider, navigationService)
        {
        }
        #endregion
    }
}
