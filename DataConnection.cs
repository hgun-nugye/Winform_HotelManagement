using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    internal class DataConnection
    {
        string constr;
        public DataConnection()
        {
            constr = "Data Source = LAPTOP-0ILAPBDO; Initial Catalog = HotelManagement; Integrated Security = true";
        }

        public SqlConnection GetConnect()
        {
            return new SqlConnection(constr);
        }
    }
}
