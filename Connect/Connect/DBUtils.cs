using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
namespace Connect
{
    class DBUtils
    {
        public static OracleConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 1521;
            string sid = "coin";
            string user = "system";
            string password = "123";

            return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }
    }
}
