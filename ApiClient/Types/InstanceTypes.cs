using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient.Types
{
    public class InstanceTypes
    {
        public class LocalSqlServerInfo
        {
            public string InstanceName { get; set; }
            public string Version { get; set; }
            public string Edition { get; set; }
            public bool IsClustered { get; set; }
            public string Collation { get; set; }

        }

    }
}
