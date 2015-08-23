using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP_OFFICE_ASSISTANCE_SYSTEM
{
    class DBconn
    {
        public void connect()
        {
            SqlConnection conn = new SqlConnection("Server=AKILAN-PC;Database=test;Trusted_Connection=yes;");
            conn.Open();

        }
    }
}
