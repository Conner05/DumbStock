using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using DumbStock.RR.forms.Services;

namespace DumbStock.RR
{
    public partial class App : Application
    {
        public interface IAuthenticate
        {
            Task<bool> Authenticate();
        }

        public static IAuthenticate Authenticator { get; private set; }

        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<AuthService>();
            DependencyService.Register<StrategyDataStore>();

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new MainPage();
            else
                MainPage = new NavigationPage(new MainPage());
        }
    }
}
