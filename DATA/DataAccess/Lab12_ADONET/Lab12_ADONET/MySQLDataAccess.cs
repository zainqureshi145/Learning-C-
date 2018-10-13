using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Lab12_ADONET
{
    class MySQLDataAccess
    {

        private string ConnectionString = "Server=localhost;Database=student;Uid=root;Pwd=1234";

        // get all records from database
        public void GetStudentInfoInReader()
        {
            string query = "select * from student";
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = ConnectionString;
                con.Open();
                Console.WriteLine("Connection Established....");

                MySqlDataReader rdr = null;
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr["Student_Name"].ToString());
                    Console.WriteLine(rdr["Student_FName"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        // insert student information
        public void InsertStudentInfo()
        {
            string name = "ijaz ahmed three";
            string fatherName = "ahmed nauman three";
            string reg_no = "1103922";
            int age = 23;

            string query = "Insert Into Employee(Name,username,password) Values('" + name + "','" + fatherName + "','" + reg_no + "'," + age + ")";

            //string query = "Insert Into student(Name,father_name,reg_no) Values('" + name + "','" + fatherName + "','" + reg_no + "')";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConnectionString;
            con.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = query;
            cmd.Connection = con;

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Console.WriteLine("data has been inserted");
            }

        }

        // get student count
        public void GetStudentCount()
        {
            string query = "select count(1) from Employee";
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = ConnectionString;
                con.Open();

                //MySqlDataReader rdr = null;
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;
                cmd.Connection = con;

                object objValue = cmd.ExecuteScalar();

                if (objValue != null)
                {
                    int studentCount = (int)objValue;

                    Console.WriteLine("No of Employee in class = " + studentCount);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // get all records from database
        public void GetOneStuentInfo()
        {
            int student_id = 5;

            string query = "select * from Employee where student_id= " + student_id + "";
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = ConnectionString;
                con.Open();

                MySqlDataReader rdr = null;
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine("Name = " + rdr["name"].ToString());
                    Console.WriteLine("Fahter Name = " + rdr["father_name"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // insert student information
        public void UpdateStudentInfo()
        {
            string name = "new name";
            int student_id = 5;

            string query = "update Employee set name = '" + name + "' where student_id = " + student_id + "";

            //string query = "Insert Into student(Name,father_name,reg_no) Values('" + name + "','" + fatherName + "','" + reg_no + "')";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConnectionString;
            con.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = query;
            cmd.Connection = con;

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Console.WriteLine("data has been updated");
            }

        }

    }
}
