using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Forms.Local.ViewModels
{
    public class KakaoViewModels : IViewLoadable
    {
        private readonly IRegionManager _rigionManager;
        private readonly IContainerProvider _containerProvider;

        public KakaoViewModels(IRegionManager reionManager, IContainerProvider containerProvider)
        {
            _rigionManager = reionManager;
            _containerProvider = containerProvider;
        }

        public void OnLoaded(IViewable view)
        {
            IRegion mainRegion = _rigionManager.Regions["MainRegion"];
            IViewable loginContent = _containerProvider.Resolve<IViewable>("LoginContent");

            if (!mainRegion.Views.Contains(loginContent))
            {
                mainRegion.Add(loginContent);

            }

            mainRegion.Activate(loginContent);
        }
    }
}
