using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using ApiClient.Models;

namespace ApiClient.Controllers
{
    [RoutePrefix("api/database")]
    public class DatabaseController : ApiController
    {
        [Route("GetAllDatabases/{instancename:length(1,16)}")]
        public HttpResponseMessage GetAllDatabases(string instancename)
        {
            Console.WriteLine("GetAllDatabases called with instancename {0} called", instancename);

            Databases dbs = new Databases(instancename);

            var result = dbs.GetAllDatabasesPerInstance(instancename).ToArray();

            if (result.Any())
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }

            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}
