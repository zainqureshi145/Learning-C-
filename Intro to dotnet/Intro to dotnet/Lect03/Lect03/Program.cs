using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Welcome to lecture 3----");

            Console.WriteLine("Please enter your name");

            string name = Console.ReadLine();

            
            Console.WriteLine("Please enter your age");

            string age = Console.ReadLine();

            int new_age = Convert.ToInt32(age);

            int ageinSeconds = new_age * 365 * 24 * 60 * 60;

            Console.WriteLine("Welcome " + name);
            Console.WriteLine("you have seen  " + ageinSeconds + " seconds in your life");

            Console.ReadLine();
        }
    }
}
