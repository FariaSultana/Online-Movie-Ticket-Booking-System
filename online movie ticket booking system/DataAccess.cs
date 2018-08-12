using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace online_movie
{
    class DataAccess
    {
        public SqlConnection conn;
        public SqlCommand comm;

        public DataAccess()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["studentdbconnection"].ConnectionString);
            comm = new SqlCommand();
            comm.Connection = conn;
            
        }
    }
}
