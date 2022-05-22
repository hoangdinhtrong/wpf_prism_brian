using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WPF_Prism_Brian.Views;

namespace WPF_Prism_Brian.Modules
{
    public class ModuleBModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("RightRegion", typeof(MessageList));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
