using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS_1112114
{
    class DataDb
    {

        string connectionString = @"Server=localhost;Database=employee;Uid=root;pwd=12345678";


        public void ShowAll() {

            string query = "select * from employee_table";
            try {

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();



                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = conn;

                reader = cmd.ExecuteReader();

                while(reader.Read()){
                    Console.WriteLine("\nName of employee is= "+reader["name"]);
                    Console.WriteLine("Father Name of employee is= " + reader["father_name"]);
                    Console.WriteLine("CNIC  of employee is= " + reader["cnic"]);
                    Console.WriteLine("Mobile No  of employee is= " + reader["mobile_no"]);
                    Console.WriteLine("Current Address of employee is= " + reader["current_address"]);
                    Console.WriteLine("Permanent Address of employee is= " + reader["permanent_address"]);
                    Console.WriteLine("Grade of employee is= " + reader["grade"]);
                } conn.Close();

            
            
            }
            catch (Exception i)
            
            
            { Console.WriteLine(i.Message); }
        
        
        }

        public void Insert(Employee emp)
        {


            string name = emp.name;
            string fname = emp.father_name;
            string cnic = emp.cnic;
            string mNo = emp.mobile_no;
            string Caddress = emp.current_address;
            string Paddress = emp.prmanent_address;
            int grade = emp.grade;
            string type = emp.type;

            string query = "Insert Into employee_table(name,father_name,cnic,mobile_no,current_address,permanent_address,grade,type)values('" + name + "','" + fname + "','" + cnic + "','" + mNo + "','" + Caddress + "','" + Paddress + "','" + grade + "','" + type + "')";
            try
            {

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();



               
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = conn;

                int result = cmd.ExecuteNonQuery();

               if(result==1){
                   Console.WriteLine("!!!!Data Inserted in Database!!!!");
                   Console.WriteLine("Press any key to continue...");
                   Console.ReadKey();
               
               }
                
                
                
                
                conn.Close();



            }
            catch (Exception i)


            { Console.WriteLine(i.Message); }


        }
        public void Searh(string name)
        {

            string query = "select * from employee_table where name='"+name+"'";
            try
            {

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();



                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = conn;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("\nName of employee is= " + reader["name"]);
                    Console.WriteLine("Father Name of employee is= " + reader["father_name"]);
                    Console.WriteLine("CNIC  of employee is= " + reader["cnic"]);
                    Console.WriteLine("Mobile No  of employee is= " + reader["mobile_no"]);
                    Console.WriteLine("Current Address of employee is= " + reader["current_address"]);
                    Console.WriteLine("Permanent Address of employee is= " + reader["permanent_address"]);
                    Console.WriteLine("Grade of employee is= " + reader["grade"]);
                    Console.WriteLine("Type of employee is= " + reader["type"]);
                } conn.Close();



            }
            catch (Exception i)


            { Console.WriteLine(i.Message); }


        }
        public void Update(string cnic,string name)
        {


            
            string query = "Update employee_table set name='"+name+"'where cnic='"+cnic+"'";
            try
            {

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();




                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = conn;

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Console.WriteLine("Data Updated");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();

                }




                conn.Close();



            }
            catch (Exception i)


            { Console.WriteLine(i.Message); }


        }
        public void Delete(string cnic)
        {





            string query = "delete from employee_table where cnic='"+cnic+"'";
            try
            {

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();




                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = conn;

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Console.WriteLine("Deleted");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();

                }




                conn.Close();



            }
            catch (Exception i)


            { Console.WriteLine(i.Message); }


        }
        public void Count()
        {

            string query = "select count(1) from employee_table";
            try
            {

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();



                //MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = conn;

                Object value = cmd.ExecuteScalar();
                if(value!=null){
                    Console.WriteLine("Count of Db is= "+value);
                
                }

              conn.Close();



            }
            catch (Exception i)


            { Console.WriteLine(i.Message); }


        }

    }
}
