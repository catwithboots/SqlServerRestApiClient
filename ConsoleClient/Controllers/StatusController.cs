using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleClient.Controllers
{
    [RoutePrefix("api/console")]
    public class StatusController : ApiController
    {
        [Route("IsAlive")]
        public HttpResponseMessage IsAlive()
        {
            IEnumerable<string> response = new string[] {"IsAlive", "True"};

            Console.WriteLine("IsAlive called");

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}
