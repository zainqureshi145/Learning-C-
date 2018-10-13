using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    class User
    {
        string connectionString = "Server=localhost,Database=users,Uid=root,Pwd=1234";
        //public string UserName { get; set; }
        //public string Password { get; set; }
        public bool CheckLogin(string UserName, string Password)
        {
            bool result = false;
           MySqlConnection connection = new MySqlConnection();
           MySqlCommand command = new MySqlCommand();
           connection.ConnectionString = connectionString;
           connection.Open();
           string queryString = "select count(1) from user where UserName='"+UserName+"',Password='"+Password+"'";
           command.CommandText = queryString;
           command.Connection = connection;
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
