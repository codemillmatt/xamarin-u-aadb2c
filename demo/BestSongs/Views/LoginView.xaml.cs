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
            var token = await AuthenticationService.GetSignInUpToken();

            if (!string.IsNullOrWhiteSpace(token))
            {
                var authReqView = new AuthRequiredView();
                App.Secured.Content = authReqView;
                return;
            }

            await Application.Current.MainPage
                             .DisplayAlert("Login Error", "An error occurred while logging in", "OK");
        }
    }
}
