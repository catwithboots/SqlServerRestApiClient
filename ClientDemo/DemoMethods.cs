using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;
using NLog;

namespace ClientDemo
{
    public class DemoMethods
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public static string ApiUrl
        {
            get { return ConfigurationManager.AppSettings["ApiPath"]; }
        }

        public static List<string> GetInstanceNames()
        {
            string url = string.Format("{0}instance/GetLocalSqlServers", ApiUrl);
            _logger.Debug(string.Format("apiurl: {0}", url));
            WebRequest request;
            try
            {
                request = WebRequest.Create(url);
                request.UseDefaultCredentials = true;
            }
            catch (Exception ex)
            {
                _logger.Error("Error creating webrequest for url {0}: {1}", url, ex);
                return new List<string>();
            }
            request.Method = "GET";
            request.ContentType = "application/json";
            try
            {
                WebResponse response = request.GetResponse();
                _logger.Debug(string.Format("response received"));
                var sr = new StreamReader(response.GetResponseStream());
                var text = sr.ReadToEnd();
                _logger.Debug(string.Format("response stream parsed to text"));
                List<string> resultobject = JsonConvert.DeserializeObject<List<string>>(text);
                _logger.Debug(string.Format("responsetext parsed to List<string> object"));
                return resultobject;
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("Error occurred: {0}", ex));
                return new List<string>();
            }
        }

        public static List<string> GetDatabaseNames(string instancename)
        {
            string url = string.Format("{0}database/GetAllDatabases/{1}", ApiUrl, instancename);
            _logger.Debug(string.Format("apiurl: {0}", url));
            WebRequest request;
            try
            {
                request = WebRequest.Create(url);
                request.UseDefaultCredentials = true;
            }
            catch (Exception ex)
            {
                _logger.Error("Error creating webrequest for url {0}: {1}", url, ex);
                return new List<string>();
            }
            request.Method = "GET";
            request.ContentType = "application/json";
            try
            {
                WebResponse response = request.GetResponse();
                _logger.Debug(string.Format("response received"));
                var sr = new StreamReader(response.GetResponseStream());
                var text = sr.ReadToEnd();
                _logger.Debug(string.Format("response stream parsed to text"));
                List<string> resultobject = JsonConvert.DeserializeObject<List<string>>(text);
                _logger.Debug(string.Format("responsetext parsed to List<string> object"));
                return resultobject;
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("Error occurred: {0}", ex));
                return new List<string>();
            }
        }
    }
}
