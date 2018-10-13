using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    class Manager:Student
    {
        Student SO = new Student();

        public void Register()
        {
            Console.WriteLine("Enter Student Name");
            SO.StudentName = Console.ReadLine();
            Console.WriteLine("Enter Father's Name");
            SO.FName = Console.ReadLine();
            Console.WriteLine("Enter Roll Number");
            SO.RollNo = Console.ReadLine();

            DS.SL.Add(SO);
        }
        public void Display()
        {
                Console.WriteLine("Name is " + SO.StudentName);
                Console.WriteLine("Father's Name is "+SO.FName);
                Console.WriteLine("Roll Number is "+SO.RollNo);
        }
        public void Search(string Stu)
        {
            foreach (Student S in DS.SL)
            {
                if (SO.StudentName == Stu)
                {
                    Console.WriteLine("Name " + SO.StudentName);
                    Console.WriteLine("FName " + SO.FName);
                    Console.WriteLine("RollNo " + SO.RollNo);
                }
            }
        }
    }
}
