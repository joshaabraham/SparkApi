using Microsoft.Owin.Security.OAuth;
//using OauthApi.Models;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ApiSpark.Provider
{
    public class OAuthProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            await Task.Run(() => context.Validated());
        }

        //public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        //{
        //    var identity = new ClaimsIdentity(context.Options.AuthenticationType);

        //    //using (var db = new ApiSpark.Dal.LogInfo.Login())
        //    //{

        //    ApiSpark.Dal.LogInfo.Login db = new Dal.LogInfo.Login();
        //    try
        //    {
        //        if (db != null)
        //        {
        //            var user = db..Where(o => o.UserName == context.UserName && o.UserPasswd == context.Password).FirstOrDefault();
        //            if (user != null)
        //            {
        //                identity.AddClaim(new Claim(ClaimTypes.Role, user.UserRole));
        //                identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
        //                identity.AddClaim(new Claim("LoggedOn", DateTime.Now.ToString()));
        //                await Task.Run(() => context.Validated(identity));
        //            }
        //            else
        //            {
        //                context.SetError("Wrong Crendtials", "Provided username and password is incorrect");
        //            }
        //        }
        //        else
        //        {
        //            context.SetError("Wrong Crendtials", "Provided username and password is incorrect");
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
                          
        //}
    }
}