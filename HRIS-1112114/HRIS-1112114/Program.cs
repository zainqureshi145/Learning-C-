using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS_1112114
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Manager manager = new Manager();
            do{
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("!!!!!!!!!!!WELCOME TO HRIS SYSTEM!!!!!!!!!!");
                Console.WriteLine("");
                Console.WriteLine("Enter 1 to Insert Employee Info");
                Console.WriteLine("Enter 2 to Show All in Employee List");
                Console.WriteLine("Enter 3 to Show All in Employee Database");
                Console.WriteLine("Enter 4 to Search Employee In List");
                Console.WriteLine("Enter 5 to Search Employee In Database");
                Console.WriteLine("Enter 6 to Update Employee Info in List");
                Console.WriteLine("Enter 7 to Update Employee Info in Database");
                Console.WriteLine("Enter 8 to Delete Employee Info in Database");
                Console.WriteLine("Enter 9 to Count Employee in List");
                Console.WriteLine("Enter 10 to count Employee in Database");
                Console.WriteLine("Enter 11 to Calculate Pay");
                Console.WriteLine("Enter 12 to Clear Console");
                Console.WriteLine("Enter 13 to Exit Console");
                i = Convert.ToInt32(Console.ReadLine());

                switch(i){
                    case 1:
                        manager.Insert();

                        break;
                    case 2:
                        foreach(Employee emp in Utility.employeeList){

                            manager.ShowAllList(emp);
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                        break;
                    case 3:
                        manager.ShowAllD();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();


                        break;
                    case 4:
                        Console.WriteLine("Enter name to search");
                        String name = Console.ReadLine();
                        Employee emp1 = manager.SearchList(name);
                        manager.ShowAllList(emp1);


                        break;
                    case 5:
                        Console.WriteLine("Enter name to search");
                        String namee = Console.ReadLine();
                        manager.SearchDB(namee);

                        break;
                    case 6:
                         Console.WriteLine("Enter Cnic  to Update");
                        String cnic = Console.ReadLine();
                         Console.WriteLine("Enter  new name");
                        String name1 = Console.ReadLine();
                        manager.UpdateEmployeeList(cnic,name1);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case 7:
                         Console.WriteLine("Enter Cnic  to Update");
                        String cnic1 = Console.ReadLine();
                         Console.WriteLine("Enter  new name");
                        String name2 = Console.ReadLine();
                        manager.UpdateDB(cnic1,name2);



                        break;
                    case 8:
                         Console.WriteLine("Enter Cnic  to delete");
                        String cnic2 = Console.ReadLine();
                        manager.deleteDB(cnic2);

                        break;
                    case 9:
                        manager.CountList();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();


                        break;
                    case 10:
                        manager.countDb();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();


                        break;

                    case 11:

                        manager.CountPay();

                        break;

                    case 12:

                        manager.clear();
                        break;
                
                
                }
            
            
            
            
            
            }while(i!=13);
            Console.WriteLine("Exit");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();




        }
    }
}
