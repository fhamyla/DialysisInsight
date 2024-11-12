using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialysisInsight
{
    internal class DialysisInsight
    {
        public static string ConnectionString
        {
            get
            {
                string databasePath = @"db\user.mdb";
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, databasePath);

                string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\DialysisInsight\\DialysisInsight\\db\\user.mdb;Jet OLEDB:Database Password=AllTooWell";

                return connectionString;
            }
        }
    }
}
