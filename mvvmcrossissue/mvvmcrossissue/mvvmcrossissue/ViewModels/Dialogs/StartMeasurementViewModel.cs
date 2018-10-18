using MvvmCross.Commands;
using MvvmCross.Localization;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvvmcrossissue.ViewModels.Dialogs
{
    public class StartMeasurementViewModel : MvxNavigationViewModel, IMvxLocalizedTextSourceOwner
    {
        #region Properties
        public IMvxLanguageBinder LocalizedTextSource => new MvxLanguageBinder("", nameof(StartMeasurementViewModel));
        #endregion

        #region Constructor
        public StartMeasurementViewModel(
            IMvxLogProvider logProvider,
            IMvxNavigationService navigationService)
            : base(logProvider, navigationService)
        {
        }
        #endregion

        #region Commands
        private IMvxCommand _cancel;

        public IMvxCommand Cancel
        {
            get
            {
                if (_cancel == null)
                {
                    _cancel = new MvxCommand(DoCancel);
                }
                return _cancel;
            }
        }

        async void DoCancel()
        {
            await NavigationService.Close(this);
        }
        #endregion
    }
}
