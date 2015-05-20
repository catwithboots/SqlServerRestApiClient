using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using ApiClient.Models;

namespace ApiClient.Controllers
{
    [RoutePrefix("api/instance")]
    public class InstanceController : ApiController
    {
        [Route("GetLocalSqlServers")]
        public HttpResponseMessage GetLocalSqlServers()
        {
            Console.WriteLine("GetSqlServers called");

            Instances instances = new Instances();

            var result = instances.GetLocalSqlServers().ToArray();

            if (result.Any())
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }

            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

        [Route("GetLocalSqlServerInfo")]
        public HttpResponseMessage GetLocalSqlServerInfo()
        {
            Console.WriteLine("GetLocalSqlServerInfo called");

            Instances instances = new Instances();

            var result = instances.GetLocalSqlServerInfo().ToArray();

            if (result.Any())
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }

            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}
