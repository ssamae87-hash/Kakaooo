using Jamesnet.Wpf.Global.Location;
using Kakao.Chat.Local.ViewModels;
using Kakao.Chat.UI.Views;
using Kakao.Forms.Local.ViewModels;
using Kakao.Forms.UI.Views;
using Kakao.Friends.Local.ViewModels;
using Kakao.Friends.UI.Views;
using Kakao.Login.Local.ViewModels;
using Kakao.Login.UI.Views;
using Kakao.Main.Local.ViewModels;
using Kakao.Main.UI.Views;

namespace Kakao.Setting
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<KakaoWindow,KakaoViewModels>();
            items.Register<LoginContent, LoginContentViewModel>();
            items.Register<MainContent, MainContentViewModel>();
            items.Register<ChatContent, ChatContentViewModel>();
            items.Register<FriendsContent, FriendsContentViewModel>();
        }
    }
}
