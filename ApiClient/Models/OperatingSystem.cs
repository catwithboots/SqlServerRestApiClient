using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ApiClient.Models
{
    public static class OperatingSystem
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public static bool IsOs64Bit()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                _logger.Debug("Operating System is 64 Bit");
                return true;
            }

            _logger.Debug("Operating System is 32 Bit");
            return false;
        }

        public static string GetHostName()
        {
            _logger.Debug("Hostname is {0}", Environment.MachineName);
            return Environment.MachineName;
        }
    }
}
