using Prism.Ioc;
using Prism.Mvvm;
using System;
using System.Reflection;
using System.Windows;
using WPF_Prism_Brian.Pages;

namespace WPF_Prism_Brian
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainPage>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                var prefix = viewType.FullName.Replace(".Pages.", ".PageModels.");
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                var viewModelName = $"{prefix}ViewModel, {viewAssemblyName}";

                return Type.GetType(viewModelName);
            });
        }
    }
}
