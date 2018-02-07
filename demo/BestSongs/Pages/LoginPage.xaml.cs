using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Microsoft.Identity.Client;
using System.Diagnostics;

namespace BestSongs
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected async void Login_Clicked(object sender, EventArgs e)
        {
            try
            {
                //var result = await App.AuthClient.AcquireTokenAsync(B2CConstants.Scopes,
                //(IUser)null,
                //UIBehavior.SelectAccount,
                //null, null,
                //B2CConstants.SignUpInAuthority,
                //App.UiParent).ConfigureAwait(false);
                try
                {
                    var r1 = await App.AuthClient.AcquireTokenSilentAsync(B2CConstants.Scopes, (IUser)null);
                }
                catch (Exception ex1)
                {
                    Debug.WriteLine($"**** ERROR {ex1.Message}");
                }

                var result = await App.AuthClient.AcquireTokenAsync(B2CConstants.Scopes, (IUser)null, App.UiParent);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"**** ERROR!!!! {ex.Message}");
            }
        }
    }
}
