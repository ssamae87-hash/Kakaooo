using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Kakao.Setting
{
    internal class DirectModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegionManager regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MainRegion", "LoginContent");

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
