using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StudentInformation
{
    class DBManager
    {
        private string ConncetionString = "Server=localhost;Database=student;Uid=root;Pwd=1234";
        Student SO = new Student();

        public void Register()
        {
            Console.WriteLine("Enter Student Name\n");
            SO.StudentName = Console.ReadLine();
            Console.WriteLine("Enter Student Father Name\n");
            SO.FName = Console.ReadLine();
            Console.WriteLine("Enter Student's Roll Number\n");
            SO.RollNo = Console.ReadLine();

            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConncetionString;
            connection.Open();
            Console.WriteLine("Conncetion Established...");

            string queryString = "Insert Into sis(Student_Name,F_Name,S_Roll) values('" + SO.StudentName + "', '" + SO.FName + "','" + SO.RollNo + "')";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = queryString;
            command.Connection = connection;

            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                Console.WriteLine("Student Registered...");
            }
            connection.Close();
        }
        public void Display()
        {

            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConncetionString;
            connection.Open();
            Console.WriteLine("Conncetion Established...");

            string queryString = "Select * From SIS";

            MySqlCommand command = new MySqlCommand();
            MySqlDataReader reader = null;
            command.CommandText = queryString;
            command.Connection = connection;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Name is " + reader["Student_Name"].ToString());
                Console.WriteLine("Father's Name is " + reader["F_Name"].ToString());
                Console.WriteLine("Roll Number is " + reader["S_Roll"].ToString());
            }
            connection.Close();
        }
        public void Search(string Stu)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConncetionString;
            connection.Open();
            Console.WriteLine("Conncetion Established...");
            string queryString = "Select * From sis Where Student_Name = '" + Stu + "'";
            MySqlCommand command = new MySqlCommand();
            MySqlDataReader reader = null;
            command.CommandText = queryString;
            command.Connection = connection;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Name is " + reader["Student_Name"].ToString());
                Console.WriteLine("Father's Name is " + reader["F_Name"].ToString());
                Console.WriteLine("Roll Number is " + reader["S_Roll"].ToString());
            }
        }
    }
}

