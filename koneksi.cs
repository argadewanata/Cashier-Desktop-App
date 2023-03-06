using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cashier_Dekstop_App
{
    internal class koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection MicrosoftSQLConn = new SqlConnection();
            MicrosoftSQLConn.ConnectionString = "Data source=localhost;initial catalog=DB_Cashier;integrated security=true";
            return MicrosoftSQLConn;
        }
    }
}
