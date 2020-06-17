using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using ApiSpark.Provider;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ApiSpark.hubs;

[assembly: OwinStartup(typeof(ApiSpark.App_Start.Startup))]

namespace ApiSpark.App_Start
{
    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {

           // ConfigureAuth(app);
           // GlobalConfiguration.Configure(WebApiConfig.Register);

            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            // app.MapSignalR("/signalr", new HubConfiguration());

            app.MapSignalR();

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            var myProvider = new AuthentificationService();
            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = myProvider
            };
            app.UseOAuthBearerTokens(options);
            app.UseOAuthAuthorizationServer(options);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());


            HttpConfiguration config = new HttpConfiguration();
           // WebApiConfig.Register(config);
        }

        //public void ConfigureAuth(IAppBuilder app)
        //{
        //   // ConfigureAuth(app);
        //    GlobalConfiguration.Configure(WebApiConfig.Register);

        //    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        //    // app.MapSignalR("/signalr", new HubConfiguration());

        //    app.MapSignalR();

        //    //this is very important line cross orgin source(CORS)it is used to enable cross-site HTTP requests  
        //    //For security reasons, browsers restrict cross-origin HTTP requests  
        //    app.UseCors(CorsOptions.AllowAll);

        //    var OAuthOptions = new OAuthAuthorizationServerOptions
        //    {
        //        AllowInsecureHttp = true,
        //        TokenEndpointPath = new PathString("/token"),
        //        AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),//token expiration time  
        //        Provider = new OAuthProvider()
        //    };

        //    app.UseOAuthBearerTokens(OAuthOptions);
        //    app.UseOAuthAuthorizationServer(OAuthOptions);
        //    app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        //    HttpConfiguration config = new HttpConfiguration();
        //    WebApiConfig.Register(config);//register the request  
        //}
    }
}