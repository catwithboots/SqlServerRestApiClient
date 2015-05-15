using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ConsoleClient.Startup))]

namespace ConsoleClient
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();

            //  Enable attribute based routing
            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);
        }
    }
}
