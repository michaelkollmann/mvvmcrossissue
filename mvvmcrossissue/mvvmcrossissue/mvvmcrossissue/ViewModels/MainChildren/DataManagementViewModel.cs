using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvvmcrossissue.ViewModels.MainChildren
{
    public class DataManagementViewModel : MvxNavigationViewModel
    {
        public DataManagementViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService)
            : base(logProvider, navigationService) { }
    }
}
