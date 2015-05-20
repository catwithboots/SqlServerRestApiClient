using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace ConsoleClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Hardcoded listen address for now, will be configurable later on
            string baseAddress = "http://*:9000";

            Console.WriteLine("Starting SQL Server Rest API Client");

            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Operating System: {0}", Environment.OSVersion);
                Console.WriteLine("SQL API running at {0} - press Enter to quit. ", baseAddress);

                Console.ReadLine();

            }
        }
    }
}
