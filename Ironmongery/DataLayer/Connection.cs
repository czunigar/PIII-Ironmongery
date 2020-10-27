using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class Connection
    {
        private SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["conndb"].ConnectionString);

        public SqlConnection BeginConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            return connect;
        }

        public SqlConnection CloseConnection()
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            return connect;
        }
    }
}
