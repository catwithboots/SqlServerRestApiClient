using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiClient.Types;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using NLog;
using Microsoft.SqlServer.Management.Smo.Wmi;

namespace ApiClient.Models
{
    public class Instances
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();


        public IEnumerable<InstanceTypes.LocalSqlServerInfo> GetLocalSqlServerInfo()
        {
            var result = new List<InstanceTypes.LocalSqlServerInfo>();

            _logger.Debug("Get all local SQL Server instances");
            IEnumerable<string> localsqlservers = GetLocalSqlServers().ToArray();

            if (localsqlservers.Any())
            {
                foreach (string sqlserver in localsqlservers)
                {
                    SqlConnectionInfo connection = new SqlConnectionInfo(sqlserver);
                    ServerConnection conn = new ServerConnection(connection);
                    Server srv = new Server(conn);

                    var row = new InstanceTypes.LocalSqlServerInfo
                    {
                        InstanceName = srv.InstanceName,
                        Version = Path.Combine(srv.Version.Major.ToString(), srv.Version.Minor.ToString(), srv.Version.Build.ToString()),
                        Collation = srv.Collation,
                        Edition = srv.Edition,
                        IsClustered = srv.IsClustered
                    };

                    result.Add(row);
                }

                _logger.Debug("Returning result");
                return result;
            }

            _logger.Debug("No local SQL Servers found");
            return result;
        }

        public IEnumerable<string> GetLocalSqlServers()
        {
            var result = new List<string>();

            // Using ManagedComputer because EnumAvailableSqlServers does not work with local firewall (broadcast)
            ManagedComputer mc = new ManagedComputer();

            _logger.Debug("Determine OS architecture");
            mc.ConnectionSettings.ProviderArchitecture = OperatingSystem.IsOs64Bit() ? ProviderArchitecture.Use64bit : ProviderArchitecture.Use32bit;
            
            _logger.Debug("Loop through all instances");

            foreach (ServerInstance si in mc.ServerInstances)
            {
                string name = null;
                if (si.Name == "MSSQLSERVER")
                {
                    name = si.Parent.Name;
                }
                else
                {
                    name = Path.Combine(si.Parent.Name, si.Name);
                }

                Console.WriteLine("Instance name = {0}", name);
                _logger.Debug("Instance name = {0}", name);
                result.Add(name);
            }

            _logger.Debug("Returning result");
            return result;
        }

    }
}
