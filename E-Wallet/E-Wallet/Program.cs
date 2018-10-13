using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet
{
    class Program:Manager
    {
        static void Main(string[] args)
        {
            Manager MO = new Manager();
            int x = 100;
            while (x == 100)
            {
            Console.WriteLine("Enter Choice To Perform Operation\nPress 1 to Register\nPress 2 to Login\nPress 3 to Withdraw\nPress 4 to Reload\n Press 5 to Display\nPress 6 to Search\n");
            string choice = null;
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
                            Console.WriteLine("Enter Your User Name...");
                            string UserName = Console.ReadLine();
                            Console.WriteLine("Enter Your Pin Code...");
                            string PinCode = Console.ReadLine();
                            MO.Login(UserName, PinCode);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Enter Your User Name...");
                            string UserName = Console.ReadLine();
                            MO.Withdraw(UserName);
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Enter Your User Name...");
                            string UserName = Console.ReadLine();
                            MO.Reload(UserName);
                            break;
                        }
                    case "5":
                        {
                            foreach (Users user in DataStructure.User)
                            {
                                MO.Display(user);
                            }
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("Enter Your Pin Code...");
                            string PinCode = Console.ReadLine();
                            MO.Search(PinCode);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter Valid Choice...");
                            break;
                        }
                }
            }
        }
    }
}
