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
            RegisterAppStart<StartViewModel>();
        }
    }
}
