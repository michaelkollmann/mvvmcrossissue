using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using mvvmcrossissue.ViewModels.MainChildren;
using System.Threading.Tasks;

namespace mvvmcrossissue.ViewModels
{
    public class MainRootViewModel : MvxViewModel
    {
        public MainRootViewModel(IMvxNavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public override async void ViewAppeared()
        {
            await NavigationService.Navigate<MainNavigationViewModel>();
        }
    }
}
