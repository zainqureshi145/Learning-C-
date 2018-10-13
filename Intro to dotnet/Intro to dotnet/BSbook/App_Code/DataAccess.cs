using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
/// <summary>
/// Summary description for DataAccess
/// </summary>
namespace BSbook
{
    public class DataAccess
    {
        private string ConnectionString = @"Server=localhost;Database=zabbook;Uid=root;Pwd=123";

        public int AddUser(ZabUser objUser)
        {
            int rowsUpdated = 0;
            try
            {
                string query = "Insert Into users(Name,email,password) Values('" + objUser.Name + "','" + objUser.Email + "','" + objUser.Password + "')";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = ConnectionString;
                con.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;
                cmd.Connection = con;

                rowsUpdated = cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return rowsUpdated;
        }

        public DataSet GetUsers()
        {
            try
            {
                string query = "select * from Users";

                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, ConnectionString);
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }

        public DataSet GetUsers(DateTime date)
        {
            try
            {
                string query = "select * from Users where DATE(insertion_timestamp) = '"+date.ToString("yyyy-MM-dd")+"' ";

                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, ConnectionString);
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataSet SearchUsers(string name)
        {
            try
            {
                string query = "select * from Users where name like '%" + name + "%' ";

                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, ConnectionString);
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int UpdateUser(string id, string name)
        {
            int rowsUpdated = 0;
            try
            {
                string query = "update users set name = '" + name + "' where user_id = " + id + " ";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = ConnectionString;
                con.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;
                cmd.Connection = con;

                rowsUpdated = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return rowsUpdated;

        }
    }
}