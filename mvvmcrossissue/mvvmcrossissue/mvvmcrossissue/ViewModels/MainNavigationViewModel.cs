using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using mvvmcrossissue.ViewModels.MainChildren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mvvmcrossissue.ViewModels
{
    public class MainNavigationViewModel : MvxViewModel
    {
        #region Fields
        private MenuItem _selectedMenuItem;
        private IMvxAsyncCommand<MenuItem> _onSelectedChangedCommand;
        #endregion

        #region Properties
        public IEnumerable<MenuItem> MenuItems { get; set; }
        public MenuItem SelectedMenuItem
        {
            get => _selectedMenuItem;
            set
            {
                if (SetProperty(ref _selectedMenuItem, value))
                {
                    OnSelectedChangedCommand.Execute(value);
                }
            }
        }
        #endregion

        #region Commands
        private IMvxAsyncCommand<MenuItem> OnSelectedChangedCommand
        {
            get
            {
                return _onSelectedChangedCommand ?? (_onSelectedChangedCommand = new MvxAsyncCommand<MenuItem>(async (item) =>
                {
                    if (item == null)
                        return;

                    await NavigationService.Navigate(item.ViewModelType);
                }));
            }
        }
        #endregion

        #region Constructor
        public MainNavigationViewModel(IMvxNavigationService navigationService)
        {
            NavigationService = navigationService;

            MenuItems = new[]
            {
                new MenuItem() { Name = "Devices", ViewModelType = typeof(DeviceViewModel)},
                new MenuItem() { Name = "Data", ViewModelType = typeof(DataManagementViewModel)},
                new MenuItem() { Name = "Settings", ViewModelType = typeof(SettingsViewModel)},
            };
        }
        #endregion

        #region Overrides
        public override void ViewAppeared()
        {
            SelectedMenuItem = MenuItems.First();
        }
        #endregion

        #region Nested Class MenuItem
        public class MenuItem
        {
            public string Name { get; set; }
            public Type ViewModelType { get; set; }
        }
        #endregion
    }
}
