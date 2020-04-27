using ConsoleHost.Configurations;
using Microsoft.Owin.Cors;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleHost
{
    public partial class Startup
    {
        public void AuthConfig(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            RouteConfig.RegisterRoutes(config);
            app.UseCors(CorsOptions.AllowAll);
            app.Map("signalR", map =>
            {
                HttpConfiguration hcf = new HttpConfiguration();
                map.RunSignalR();
            });
        }
    }
}
