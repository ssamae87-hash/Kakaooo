using Kakao.Setting;
using System.Configuration;

namespace Kakao
{
    internal class Starter 
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddInversionModule<ViewModules>()
                .AddInversionModule<DirectModules>()
                .Run();
        }
    }
}
