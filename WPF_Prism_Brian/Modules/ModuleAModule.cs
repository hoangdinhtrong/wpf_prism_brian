using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WPF_Prism_Brian.ViewModels;
using WPF_Prism_Brian.Views;

namespace WPF_Prism_Brian.Modules
{
    public class ModuleAModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            IRegion region = regionManager.Regions["ContentRegion"];

            var tabA = containerProvider.Resolve<TabView>();
            SetTitle(tabA, "Tab A");
            region.Add(tabA);

            var tabB = containerProvider.Resolve<TabView>();
            SetTitle(tabB, "Tab B");
            region.Add(tabB);

            var tabC = containerProvider.Resolve<TabView>();
            SetTitle(tabC, "Tab C");
            region.Add(tabC);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        void SetTitle(TabView tab, string title)
        {
            (tab.DataContext as TabViewModel).Title = title;
        }
    }
}
