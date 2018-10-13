using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.Student student = new Classes.Student();

            Classes.Register studentRegister =new Classes.Register();
            
            string option="Y";

            while(option!="n"){

                Console.WriteLine("To add a student press '1' ");
                Console.WriteLine("To see list of applied students press '2' ");
                Console.WriteLine("To see list of selected students press '3' ");
                Console.WriteLine("To see list of rejected students press '4' ");
                Console.WriteLine("To terminate the program press 'n' ");

                option = Console.ReadLine();
                if (option.Equals("1")) {
                    Console.WriteLine("Enter student ID");
                    
                    string input=Console.ReadLine();

                    student.id=int.Parse(input);


                    Console.WriteLine("Enter student Name ");
                    
                    input = Console.ReadLine();
                    
                    student.name = input;

                    Console.WriteLine("Enter student Status ");

                    input = Console.ReadLine();

                    student.status = input;

                    studentRegister.addStudent(student);

                    Console.WriteLine("Student added");

                    Console.WriteLine();
                    


                }
                else if(option.Equals("2"))
                {
                    Console.WriteLine("The following Students are not eligible");
                    studentRegister.searchList("Applied");

                }
                else if (option.Equals("3"))
                {
                    Console.WriteLine("The following students are eligible");
                    studentRegister.searchList("Pass");

                }
                else if (option.Equals("4"))
                {
                    Console.WriteLine("The following Students are rejected");
                    studentRegister.searchList("Rejected");
                }
                else if (option.Equals("n"))
                {
                    Console.WriteLine("Done");
                    Console.ReadLine();

                }
            }





        }
    }
}
