using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerfumeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            int i;
            do{
                
                Console.WriteLine("Enter 1 to Insert Perfume  into List");
                Console.WriteLine("Enter 2 to ShowAll Perfumes ");
                Console.WriteLine("Enter 3 to Search Perfumes ");
                string c=Console.ReadLine();
                i = Convert.ToInt32(c);

            switch(i){
                case 1:
            //insertinList
            manager.InsertInList();
                
            break;
            case 2:
                    //showAll
                    foreach(Perfume p in Utility.perfumeList){
                    manager.ShowAllList(p);
                    }
                    break;
            
                case 3:
            //searchinList
            Console.WriteLine("Enter serial number to search");
            string serial=Console.ReadLine();
             Perfume perfume1=manager.SearchList(serial);
             manager.ShowAllList(perfume1);
                Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            break;
           


        }
            }while(i!=5);
            
            
        }
        }
    }

