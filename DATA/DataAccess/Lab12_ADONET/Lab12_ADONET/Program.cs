﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab12_ADONET
{
    class Program
    {
        static void Main(string[] args)
        {

            MySQLDataAccess da = new MySQLDataAccess();

            da.GetStudentInfoInReader();
            Console.ReadLine();
        }
    }
}
