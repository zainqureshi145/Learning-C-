using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Lab_DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ConnectionString = @"Data Source=AKRAM-PC\SQLEXPRESS;Initial Catalog=TestDB;User ID=sa;Password=123;";

                string query = "select * from student";

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, ConnectionString);
                da.Fill(ds);

                Console.WriteLine("Total Rows"+ds.Tables[0].Rows.Count);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Console.WriteLine("Name=" + dr["name"].ToString() );
                }
               


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
