using Xamarin.Forms;
using Microsoft.Identity.Client;

namespace BestSongs
{
    public partial class App : Application
    {
        public static PublicClientApplication AuthClient = null;
        public static UIParent UiParent = null;

        public App()
        {
            InitializeComponent();

            TabbedPage overallTab;
            overallTab = new TabbedPage();

            overallTab.Children.Add(new NavigationPage(new NoAuthPage()) { Title = "No Auth" });
            overallTab.Children.Add(new NavigationPage(new LoginPage()) { Title = "Login" });

            MainPage = overallTab;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
