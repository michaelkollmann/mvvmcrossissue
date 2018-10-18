using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace mvvmcrossissue.ViewModels
{
    public class RootViewModel : MvxNavigationViewModel
    {
        public RootViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService)
            : base(logProvider, navigationService) { }

        public override async void ViewAppeared()
        {
            await NavigationService.Navigate<NavigationViewModel>();
        }
    }
}
