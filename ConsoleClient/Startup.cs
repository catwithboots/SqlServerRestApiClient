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
        //  Hack from http://stackoverflow.com/a/17227764/19020 to load controllers in 
        //  another assembly.  Another way to do this is to create a custom assembly resolver
        Type _instanceControllerType = typeof(ApiClient.Controllers.InstanceController);

        public void Configuration(IAppBuilder app)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();

            //  Enable attribute based routing
            config.MapHttpAttributeRoutes();
            config.EnsureInitialized();

            app.UseWebApi(config);
        }
    }
}
