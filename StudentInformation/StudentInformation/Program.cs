using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    class Program
    {
        public static void DBChoice()
        {
            DBManager DBMO = new DBManager();
            string choice3;
            Console.WriteLine("\nEnter Choice\n1 To Register\n2 To Display\n3 To Search\n");
            choice3 = Console.ReadLine();
            switch (choice3)
            {
                case "1":
                    {
                        DBMO.Register();
                        break;
                    }
                case "2":
                    {
                        DBMO.Display();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Enter Name To Search\n");
                        string Stu = Console.ReadLine();
                        DBMO.Search(Stu);
                        break;
                    }
            }
        }
        public static void ListChoice()
        {
            Manager MO = new Manager();
            string choice;
            Console.WriteLine("\nEnter Choice\n1 To Register\n2 To Display\n3 To Search\n");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        MO.Register();
                        break;
                    }
                case "2":
                    {
                        MO.Display();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Enter Name To Search\n");
                        string Stu = Console.ReadLine();
                        MO.Search(Stu);
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {


            int x = 100;
            while (x == 100)
            {
                Console.WriteLine("\nEnter 1 To Use Lists\nEnter 2 To Use Database\n");
                string choice2;
                choice2 = Console.ReadLine();
                switch (choice2)
                {
                    case "1":
                        {
                            ListChoice();
                            break;
                        }
                    case "2":
                        {
                            DBChoice();
                            break;
                        }
                }
            }
        }
                
    }
}