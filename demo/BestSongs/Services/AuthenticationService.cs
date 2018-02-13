using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

using Microsoft.Identity.Client;
using Newtonsoft.Json.Linq;

namespace BestSongs
{
    public class AuthenticationService
    {
        static PublicClientApplication AuthClient;

        static void Init()
        {
            if (AuthClient != null)
                return;

            AuthClient = new PublicClientApplication(B2CConstants.ClientId);
            AuthClient.ValidateAuthority = false;
            AuthClient.RedirectUri = B2CConstants.MSALRedirectUri;
        }

        public async static Task<UserInfo> GetSignInUpToken()
        {
            Init();

            UserInfo returnUser = null;

            returnUser = await GetCachedSignInToken();

            if (returnUser != null)
                return returnUser;

            try
            {
                // Get token from B2C

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** ERROR: {ex.Message}");
            }

            return returnUser;
        }

        public async static Task<bool> IsLoggedIn()
        {
            Init();

            var cachedToken = await GetCachedSignInToken();

            return !string.IsNullOrWhiteSpace(cachedToken?.AccessToken);
        }

        public async static Task<UserInfo> GetCachedSignInToken()
        {
            Init();

            UserInfo userInfo = null;

            try
            {
                // This checks to see if there's already a user in the cache



            }
            catch (MsalUiRequiredException ex)
            {
                // happens if the user hasn't logged in yet & isn't in the cache
                Debug.WriteLine($"*** ERROR: {ex.Message}");
            }

            return userInfo;
        }

        public static void Logout()
        {
            Init();

            foreach (var user in AuthClient.Users)
            {
                AuthClient.Remove(user);
            }
        }

        static IUser GetUserByPolicy(IEnumerable<IUser> users, string policy)
        {
            foreach (var user in users)
            {
                string userIdentifier = Base64UrlDecode(user.Identifier.Split('.')[0]);

                if (userIdentifier.EndsWith(policy.ToLower(), StringComparison.OrdinalIgnoreCase)) return user;
            }

            return null;
        }

        static string Base64UrlDecode(string s)
        {
            s = s.Replace('-', '+').Replace('_', '/');
            s = s.PadRight(s.Length + (4 - s.Length % 4) % 4, '=');
            var byteArray = Convert.FromBase64String(s);
            var decoded = Encoding.UTF8.GetString(byteArray, 0, byteArray.Count());
            return decoded;
        }

        static JObject ParseIdToken(string idToken)
        {
            // Get the piece with actual user info
            idToken = idToken.Split('.')[1];
            idToken = Base64UrlDecode(idToken);
            return JObject.Parse(idToken);
        }

    }
}
