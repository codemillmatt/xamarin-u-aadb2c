using System;
namespace BestSongs
{
    public class B2CConstants
    {
        public static readonly string Tenant = "-- YOUR TENANT NAME HERE --";
        public static readonly string ClientId = "-- YOUR CLIENT ID HERE --";

        public static readonly string SignInUpPolicy = "-- YOUR SIGN-IN/UP POLICY NAME HERE --";
        public static readonly string PasswordResetPolicy = "-- YOU PASSWORD RESET POLICY NAME HERE --";
        public static readonly string EditProfilePolicy = "YOUR EDIT PROFILE POLICY NAME HERE --";

        public static readonly string AuthorityBase = $"https://login.microsoftonline.com/tfp/{Tenant}/";
        public static readonly string SignUpInAuthority = $"{AuthorityBase}{SignInUpPolicy}";
        public static readonly string PasswordResetAuthority = $"{AuthorityBase}{PasswordResetPolicy}";
        public static readonly string EditProfileAuthority = $"{AuthorityBase}{EditProfilePolicy}";

        public static string[] Scopes = new string[] { "" };
    }
}
