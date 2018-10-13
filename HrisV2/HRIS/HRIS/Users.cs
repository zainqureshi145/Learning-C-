using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS
{
    class Users
    {
        public string connectionString = @"Server=localhost;Database=Users;Uid=root;Pwd=1234";
        public bool CheckLogin(string UserName, string Password)
        {
            bool result = false;
            MySqlConnection connection = new MySqlConnection();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.ConnectionString = connectionString;
            connection.Open();
            string queryString = "select count(1) from user where UserName = '"+ UserName +"' and Password = '"+Password+"'";
            command.CommandText = queryString;
            object OBJ = command.ExecuteScalar();
            if (OBJ != null)
            {
                int Count = Convert.ToInt32(OBJ);
                if (Count > 0)
                {
                    result = true;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
