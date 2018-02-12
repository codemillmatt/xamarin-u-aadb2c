using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace BestSongs
{
    public partial class AuthRequiredView : ContentView
    {
        public AuthRequiredView()
        {
            InitializeComponent();
        }

        public async Task InitializeDisplay(UserInfo info)
        {
            BindingContext = info;

            var bestSongs = await BestSongService.GetBestSongsEver(info.AccessToken).ConfigureAwait(false);

            songList.ItemsSource = bestSongs;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            AuthenticationService.Logout();

            var login = new LoginView();
            App.Secured.Content = login;
            App.Secured.Title = "Not Logged In";
        }
    }
}
