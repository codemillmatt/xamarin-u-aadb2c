using Xamarin.Forms;
using Microsoft.Identity.Client;

namespace BestSongs
{
    public partial class App : Application
    {
        public static PublicClientApplication AuthClient = null;
        public static UIParent UiParent = null;

        public static SecuredPage Secured;

        public App()
        {
            InitializeComponent();

            //SecuredNavigationPage = new NavigationPage { Title = "Secured" };

            TabbedPage overallTab;
            overallTab = new TabbedPage();

            Secured = new SecuredPage();

            overallTab.Children.Add(new NavigationPage(new NoAuthPage()) { Title = "No Auth" });
            overallTab.Children.Add(new NavigationPage(Secured) { Title = "Secured" });

            MainPage = overallTab;
        }

        protected async override void OnStart()
        {
            // Handle when your app starts
            var isLoggedIn = await AuthenticationService.IsLoggedIn();


            if (isLoggedIn)
                Secured.Content = new AuthRequiredView();
            else
                Secured.Content = new LoginView();

            Secured.Title = isLoggedIn ? "Logged In" : "Not Logged In";
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
