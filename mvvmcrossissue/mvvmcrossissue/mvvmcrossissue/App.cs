using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using mvvmcrossissue.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvvmcrossissue
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IMvxCommandHelper, MvxStrongCommandHelper>();

            RegisterAppStart<RootViewModel>();
        }
    }
}
