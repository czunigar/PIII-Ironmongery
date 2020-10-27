using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using ServiceLayer;
using EntityLayer;

namespace DataLayer
{
    public class ProductDAO
    {
        Util util = new Util();
        private Connection connect = new Connection();
        private SqlDataReader read;
        EProduct product = new EProduct();

        public DataTable tableProducts()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect.BeginConnection();
                cmd.CommandText = "EXEC GETPRODUCTS";
                read = cmd.ExecuteReader();
                dt.Load(read);
                read.Close();
                connect.CloseConnection();
            }
            catch (Exception)
            {

                util.showError("Imposible to connect to the database", "Connection");
            }
            return dt;
        }

        public bool Insert(EProduct product)
        {
            bool ins = false;
            try
            {
                string query = "EXEC SETPRODUCT @Product_Name, @Category, @Product_Description, @Price, @Units";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = connect.BeginConnection();
                cmd.Parameters.AddWithValue("@Product_Name", product.Name);
                cmd.Parameters.AddWithValue("@Category", product.Categoty);
                cmd.Parameters.AddWithValue("@Product_Description", product.Description);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Units", product.Units);
                ins = cmd.ExecuteNonQuery() > 0;
                cmd.Parameters.Clear();
                cmd.Connection = connect.CloseConnection();

            }
            catch (SqlException sq)
            {

                util.showError(sq.Message + " Imposible to connect to the database", "Connection");
            }
            return ins;
        }

        public bool Update(EProduct product)
        {
            bool ins = false;
            try
            {
                string query = "";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = connect.BeginConnection();
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Product_Name", product.Name);
                cmd.Parameters.AddWithValue("@Category", product.Categoty);
                cmd.Parameters.AddWithValue("@Product_Description", product.Description);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Units", product.Units);
                ins = cmd.ExecuteNonQuery() > 0;
                cmd.Parameters.Clear();
                cmd.Connection = connect.CloseConnection();

            }
            catch (SqlException sq)
            {

                util.showError(sq.Message + " Imposible to connect to the database", "Connection");
            }
            return ins;
        }

        public bool Delete(EProduct product)
        {
            bool ins = false;
            try
            {
                string query = "";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = connect.BeginConnection();
                cmd.Parameters.AddWithValue("@Id", product.Id);
                ins = cmd.ExecuteNonQuery() > 0;
                cmd.Parameters.Clear();
                cmd.Connection = connect.CloseConnection();

            }
            catch (SqlException sq)
            {

                util.showError(sq.Message + " Imposible to connect to the database", "Connection");
            }
            return ins;
        }

        private EProduct Load(SqlDataReader rd)
        {
            EProduct product = new EProduct();
            try
            {
                product.Id = rd.GetInt32(1);
                product.Name = rd.GetString(2);
                product.Categoty = rd.GetString(3);
                product.Description = rd.GetString(4);
                product.Price = rd.GetDouble(5);
                product.Units = rd.GetInt32(6);
            }
            catch (SqlException)
            {

                util.showError("Imposible to connect to the database", "Connection");
            }
            return product;
        }

    }
}
