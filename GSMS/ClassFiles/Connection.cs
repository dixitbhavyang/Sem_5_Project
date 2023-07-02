using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GSMS
{
    class Connection
    {
        public static string connectionString()
        {
            return ConfigurationManager.ConnectionStrings["SuperMarketMSCS"].ConnectionString;
        }
    }
}
