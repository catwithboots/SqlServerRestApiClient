using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using NLog;

namespace ApiClient.Models
{
    public class Databases
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        private string _instance;

        public Databases(string instance)
        {
            _instance = instance;
        }

        public IEnumerable<string> GetAllDatabasesPerInstance(string instancename)
        {
            var result = new List<string>();

            try
            {
                SqlConnectionInfo connection = new SqlConnectionInfo(instancename);
                ServerConnection conn = new ServerConnection(connection);
                Server srv = new Server(conn);

                _logger.Debug("Found {0} databases on instance {1}", srv.Databases.Count, instancename);

                foreach (Database db in srv.Databases)
                {
                    result.Add(db.Name);
                }

                return result;
            }
            catch (Exception e)
            {
                _logger.Debug("Could not retrieve databases from {0}. {1}", instancename, e);    
                Console.WriteLine("Could not retrieve databases from {0}. {1}", instancename, e);
                return result;
            }

        }
    }
}
