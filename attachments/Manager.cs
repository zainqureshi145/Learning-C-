using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerfumeShop
{
    class Manager
    {
        public void InsertInList()
        {
            Perfume perfume = new Perfume();
            Console.WriteLine("Enter name of Perfume");
            perfume.name = Console.ReadLine();
            
            Console.WriteLine("Enter serial Number");
            perfume.serial_no = Console.ReadLine();
           
            Console.WriteLine("Enter Volume of Perfume");
            perfume.volume = Console.ReadLine();

            Console.WriteLine("Enter type of Perfume");
            perfume.type = Console.ReadLine();

            Utility.perfumeList.Add(perfume);
            

        }
        public void ShowAllList(Perfume perfume)
        {
            Console.WriteLine("\nName of Perfume is " + perfume.name);
            Console.WriteLine("\nSerial_no of Perfume is " + perfume.serial_no);
            Console.WriteLine("\nVolume of Perfume is " + perfume.volume);
            Console.WriteLine("\nType of Perfume is " + perfume.type);
        }
        public Perfume SearchList(string serial)
        {
            Perfume perfume1 = new Perfume();
            foreach (Perfume perfume in Utility.perfumeList)
            {
                if (perfume.serial_no == serial)
                {

                    perfume1 = perfume;

                }

            }
            return perfume1;


        }
    }
}
