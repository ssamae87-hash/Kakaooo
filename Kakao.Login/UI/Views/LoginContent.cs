using System.Windows;

namespace Kakao.Login.UI.Views
{
    public class LoginContent : Window
    {
        static LoginContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoginContent), new FrameworkPropertyMetadata(typeof(LoginContent)));
        }
    }
}
