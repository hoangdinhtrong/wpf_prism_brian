using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;
using WPF_Prism_Brian.Commands;
using WPF_Prism_Brian.Modules;
using WPF_Prism_Brian.Views;

namespace WPF_Prism_Brian
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationCommand, ApplicationCommand>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<ModuleAModule>();
        }
    }
}
