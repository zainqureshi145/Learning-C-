using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Lab12_ADONET
{
    class SQLDataAccess
    {
        private string ConnectionString = @"Data Source=AKRAM-PC\SQLEXPRESS;Initial Catalog=TestDB;User ID=sa;Password=123;";

        // get all records from database
        public void GetStudentInfoInReader()
        {
            string query = "select * from Student";
            try
            {
               SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectionString;
                con.Open();

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = query;
                cmd.Connection = con;
                                
                rdr = cmd.ExecuteReader();
                                
                while (rdr.Read())
                {
                    Console.WriteLine(rdr["father_name"].ToString());
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
            
            string query = "Insert Into student(Name,father_name,reg_no,age) Values('" + name + "','" + fatherName + "','" + reg_no + "'," + age + ")";

            //string query = "Insert Into student(Name,father_name,reg_no) Values('" + name + "','" + fatherName + "','" + reg_no + "')";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand();

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
            string query = "select count(1) from Student";
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectionString;
                con.Open();

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = query;
                cmd.Connection = con;

                object objValue = cmd.ExecuteScalar();

                if (objValue != null)
                {
                    int studentCount = (int)objValue;

                    Console.WriteLine("No of students in class = " + studentCount);
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

            string query = "select * from Student where student_id= " + student_id + "";
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectionString;
                con.Open();

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = query;
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine("Name = "+rdr["name"].ToString());
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

            string query = "update student set name = '" + name + "' where student_id = " + student_id + "";

            //string query = "Insert Into student(Name,father_name,reg_no) Values('" + name + "','" + fatherName + "','" + reg_no + "')";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand();

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
