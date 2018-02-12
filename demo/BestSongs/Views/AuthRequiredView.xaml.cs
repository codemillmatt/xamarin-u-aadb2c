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
    }
}
