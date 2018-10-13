using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSoftware
{
    class Inventory
    {
        /*String Name;
        int Qty;
        float Price;
        DateTime ManufacturingDate;
        DateTime ExpiryDate;*/


        public String Name { get; set; }
        public int Qty { get; set; }
        public float Price { get; set; }
        //public DateTime ManufacturingDate { get; set; }
        //public DateTime ExpiryDate { get; set; }

        public Inventory(String s, int y, float z)
        {

        }

    }


    class PointOfSale
    {
        static void Main(string[] args)
        {
            Console.Title = "Point Of Sale Software";
            List<Inventory> Items = new List<Inventory>();
            /*{
                new Inventory() { Name = "Sugar", Qty = 500, Price = 50 };
                new Inventory() { Name = "Salt", Qty = 700, Price = 35 };
                new Inventory() { Name = "Pepper", Qty = 600, Price = 75 };
                new Inventory() { Name = "All Spice", Qty = 900, Price = 55 };
            };*/
            Console.WriteLine("Here");
            Items.Add(new Inventory("Sugar", 500, 50));
   
            Console.WriteLine("Here");
            foreach (Inventory a in Items)
            System.Console.WriteLine("Name is {0}",a.Name);
            Console.WriteLine("Here");
            Console.ReadLine();
        }
    }
}