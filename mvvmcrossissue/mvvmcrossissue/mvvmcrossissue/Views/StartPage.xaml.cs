using MvvmCross.Forms.Views;
using mvvmcrossissue.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvmcrossissue.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartView : MvxContentPage<StartViewModel>
	{
		public StartView ()
		{
			InitializeComponent ();
		}
	}
}
