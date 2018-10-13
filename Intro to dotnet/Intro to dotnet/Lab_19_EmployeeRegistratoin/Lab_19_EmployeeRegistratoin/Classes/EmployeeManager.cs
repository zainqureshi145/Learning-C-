using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Lab_19_EmployeeRegistratoin.Classes
{
    class EmployeeManager
    {
        private string ConnectionString = @"Server=localhost;Database=bankingsystem;Uid=root;Pwd=123";          

        public DataSet GetEmployee()
        {
            DataSet dsEmployee = new DataSet();
            try
            {
                string query = "select * from employee";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = ConnectionString;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query,con);
                dataAdapter.Fill(dsEmployee);

            }
            catch (Exception ex)
            {
                throw;
            }

            return dsEmployee;
        }
        
        public DataSet SearchEmployee(string employee_id)
        {
            DataSet dsEmployee = new DataSet();
            try
            {
                string query = "select * from employee where EmployeeID = " + employee_id + "";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = ConnectionString;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, con);
                dataAdapter.Fill(dsEmployee);

            }
            catch (Exception ex)
            {
                throw;
            }

            return dsEmployee;
        }

        public bool AddEmployee(Employee objEmployee)
        {
            bool result = false;

            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }

            return result;
        }

        public int UpdateEmployee(string name, string father_name, string emp_id)
        {
            int rowsUpdated = 0;
            try
            {
                string query = "update employee " +
                               " set  " +
                               " name = '" + name + "' " +
                               " , username = '" + father_name + "' " +
                               " where employeeID = " + emp_id + "";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = ConnectionString;
                con.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;

                rowsUpdated = cmd.ExecuteNonQuery();
                     

            }
            catch(Exception ex)
            {
                throw ex;
            }

            return rowsUpdated;
        }
    }
}
