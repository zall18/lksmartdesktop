using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lksmart
{
    static class connection
    {

        public static SqlConnection conn;
        public static string Connection = "Data Source=ERPEEL\\SQLEXPRESS;Initial Catalog=lksmart;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True";

        public static SqlConnection Connect()
        {
            if(conn == null)
            {
                conn = new SqlConnection(Connection);
            }
            return  conn;
        }

    }
}
