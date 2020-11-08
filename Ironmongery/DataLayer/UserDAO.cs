using EntityLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserDAO
    {
        Util util = new Util();
        private Connection connect = new Connection();

        //public EUser SignIn(EUser user)
        //{
        //    string query = "EXEC SIGN_IN @code, @pass";
        //    SqlCommand cmd = new SqlCommand(query);
        //    cmd.Connection = connect.BeginConnection();
        //    cmd.Parameters.AddWithValue("@code", user.Code);
        //    cmd.Parameters.AddWithValue("@pass", user.Password);
        //    SqlDataReader rs = cmd.ExecuteReader();

        //    if (rs.Read())
        //    {
        //        user = Load(rs);
        //    }
        //    cmd.Connection = connect.CloseConnection();
        //    return user;
        //}

        //public bool Insert(EUser user)
        //{
        //    bool ins = false;
        //    try
        //    {
        //        string query = "EXEC SETNEW_USER @Code, @Username, @Password, @Type, @Admin";
        //        SqlCommand cmd = new SqlCommand(query);
        //        cmd.Connection = connect.BeginConnection();
        //        cmd.Parameters.AddWithValue("@Code", user.Code);
        //        cmd.Parameters.AddWithValue("@Username", user.Username);
        //        cmd.Parameters.AddWithValue("@Password", user.Password);
        //        cmd.Parameters.AddWithValue("@Type", user.Type);
        //        cmd.Parameters.AddWithValue("@Admin", user.Admin);
        //        ins = cmd.ExecuteNonQuery() > 0;
        //        cmd.Parameters.Clear();
        //        cmd.Connection = connect.CloseConnection();
                
        //    }
        //    catch (SqlException sq)
        //    {

        //        util.showError(sq.Message + " Imposible to connect to the database", "Connection");
        //    }
        //    return ins;
        //}

        //public bool Update(EUser user)
        //{
        //    bool ins = false;
        //    try
        //    {
        //        string query = "";
        //        SqlCommand cmd = new SqlCommand(query);
        //        cmd.Connection = connect.BeginConnection();
        //        cmd.Parameters.AddWithValue("@Id", user.Id);
        //        cmd.Parameters.AddWithValue("@Code", user.Code);
        //        cmd.Parameters.AddWithValue("@Username", user.Username);
        //        cmd.Parameters.AddWithValue("@Password", user.Password);
        //        cmd.Parameters.AddWithValue("@Type", user.Type);
        //        cmd.Parameters.AddWithValue("@Admin", user.Admin);
        //        ins = cmd.ExecuteNonQuery() > 0;
        //        cmd.Parameters.Clear();
        //        cmd.Connection = connect.CloseConnection();

        //    }
        //    catch (SqlException sq)
        //    {

        //        util.showError(sq.Message + " Imposible to connect to the database", "Connection");
        //    }
        //    return ins;
        //}

        //public bool Delete(EUser user)
        //{
        //    bool ins = false;
        //    try
        //    {
        //        string query = "";
        //        SqlCommand cmd = new SqlCommand(query);
        //        cmd.Connection = connect.BeginConnection();
        //        cmd.Parameters.AddWithValue("@Id", user.Id);
        //        ins = cmd.ExecuteNonQuery() > 0;
        //        cmd.Parameters.Clear();
        //        cmd.Connection = connect.CloseConnection();

        //    }
        //    catch (SqlException sq)
        //    {

        //        util.showError(sq.Message + " Imposible to connect to the database", "Connection");
        //    }
        //    return ins;
        //}

        //private EUser Load(SqlDataReader rd)
        //{
        //    EUser user = new EUser();
        //    try
        //    {
                
        //        user.Id = rd.GetInt32(1);
        //        user.Code = rd.GetString(2);
        //        user.Username = rd.GetString(3);
        //        user.Password = rd.GetString(4);
        //        user.Type = rd.GetString(5);
        //        user.Admin = rd.GetBoolean(6);
        //    }
        //    catch (SqlException)
        //    {

        //        util.showError("Imposible to connect to the database", "Connection");
        //    }
        //    return user;
        //}
    }
}
