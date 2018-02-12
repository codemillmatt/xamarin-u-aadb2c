using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BestSongs
{
    public partial class LoginView : ContentView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var userInfo = await AuthenticationService.GetSignInUpToken();

            if (userInfo != null)
            {
                var authReqView = new AuthRequiredView();
                await authReqView.InitializeDisplay(userInfo);
                App.Secured.Content = authReqView;
                App.Secured.Title = "Logged In";
                return;
            }

            await Application.Current.MainPage
                             .DisplayAlert("Login Error", "An error occurred while logging in", "OK");
        }
    }
}
