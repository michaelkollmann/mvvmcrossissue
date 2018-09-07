using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvmcrossissue.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        #region Commands
        public ICommand NextCommand { get; }
        #endregion

        #region Constructor
        public StartViewModel(IMvxNavigationService navigationService)
        {
            NavigationService = navigationService;

            NextCommand = new MvxAsyncCommand(() => Next());
        }
        #endregion

        #region Overrides
        public override Task Initialize()
        {
            return base.Initialize();
        }
        #endregion

        #region Private Methods
        private async Task Next()
        {
            await NavigationService.Navigate<MainRootViewModel>();
        }
        #endregion
    }
}
