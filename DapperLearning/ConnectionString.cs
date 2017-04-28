using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperLearning
{
    public static class AppConnectionString
    {
        private const string server = "localhost";
        private const string instance = "DEV2014";
        private const string database = "AdventureWorks2014";

        public static string GetConnectionString()
        {
            return string.Format(@"Server={0}\{1};Database={2};Trusted_Connection=True;", 
                server, instance, database);
        }
    }
}
