﻿using AproReportsClient.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace AproReportsClient.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
