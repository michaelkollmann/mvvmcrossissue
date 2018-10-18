using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using mvvmcrossissue.ViewModels.Device.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvmcrossissue.Views.Device.Tabs
{
    [MvxTabbedPagePresentation(WrapInNavigationPage = false, Title = "Configuration")]
    public partial class ConfigurationTabPage : MvxContentPage<ConfigurationTabViewModel>
	{
		public ConfigurationTabPage()
		{
			InitializeComponent ();
		}
	}
}