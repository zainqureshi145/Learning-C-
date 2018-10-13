using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Lab_19_EmployeeRegistratoin.Classes
{
    class Users
    {
        private string ConnectionString = @"Server=localhost;Database=bankingsystem;Uid=root;Pwd=123";
        
        public bool VerifyUser(string username , string password)
        {
            bool result = false;
            try
            {
                string query = "select count(1) NoOfEmployee from users                where username = '" + username + "' and password = '" + password + "'";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = ConnectionString;
                con.Open();
                                
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;
                cmd.Connection = con;
                object objValue = cmd.ExecuteScalar();
                if (objValue != null)
                {
                    int EmpCount = Convert.ToInt32(objValue);
                    if (EmpCount > 0)
                    {
                        result = true;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
