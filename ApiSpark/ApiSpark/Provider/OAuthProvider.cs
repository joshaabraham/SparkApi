using Microsoft.Owin.Security.OAuth;
using ApiSpark.Models.BDD_contextes.UserLoginContext;
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

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            using (var db = new LoginEntities())
            {

                // UserLogin db = new Models.BDD_contextes.UserLoginContext();
                try
                {
                    if (db != null)
                    {
                        var login = db.Login.Where(o => o.Email == context.UserName && o.Password == context.Password).FirstOrDefault();
                        if (login != null)
                        {
                            identity.AddClaim(new Claim(ClaimTypes.Role, login.UserRole));
                            identity.AddClaim(new Claim(ClaimTypes.Email, login.Email));
                            identity.AddClaim(new Claim("LoggedOn", DateTime.Now.ToString()));
                            await Task.Run(() => context.Validated(identity));
                        }
                        else
                        {
                            context.SetError("Wrong Crendtials", "Provided username and password is incorrect");
                        }
                    }
                    else
                    {
                        context.SetError("Wrong Crendtials", "Provided username and password is incorrect");
                    }

                }
                catch (Exception)
                {

                    throw;
                }

            }

        }
    }
}