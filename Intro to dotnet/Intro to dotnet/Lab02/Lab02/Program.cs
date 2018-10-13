using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    struct Product
    {
        public string Name;
        public double UnitPrice;
        public int Quantity;
        public DateTime ManDate;
        public DateTime ExpiryDate;
        public string ProductType;
        public string Units;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ".: Inventory Management System :.";
            Console.WriteLine("\n--------Welcome to BSCS inventory managment system--------\n");
            //Console.BackgroundColor = ConsoleColor.Gray;
           // Console.ForegroundColor = ConsoleColor.Red;
           
            Product product = new Product();
            List<Product> productsList = new List<Product>();
            string option = string.Empty;

            do
            {   
                Console.WriteLine("Press 1 to add product");
                Console.WriteLine("Press 2 to view products");
                Console.WriteLine("Press 3 to search a product");
                Console.WriteLine("Press 4 to search a edit");
                Console.WriteLine("Press 9 to sign out");
                option = Console.ReadLine();

                if (option == "1")
                {

                    Console.WriteLine("Please enter product name");
                    string name = Console.ReadLine();
                    product.Name = name;

                    Console.WriteLine("Please enter product unit price");
                    string sUnitPrice = Console.ReadLine();
                    product.UnitPrice = Convert.ToDouble(sUnitPrice);

                    Console.WriteLine("Please enter product expiry date");
                    string sExpiryDate = Console.ReadLine();
                    product.ExpiryDate = Convert.ToDateTime(sExpiryDate);


                    Console.WriteLine("Product has been added successfully");

                    productsList.Add(product);
                }


                if (option == "2")
                {
                    int counter = 1;

                    Console.WriteLine("\n showing with foreach loop\n");
                    foreach (Product p in productsList)
                    {
                        Console.WriteLine("Produect No. " + counter.ToString());

                        Console.WriteLine("Produect Name = " + p.Name);
                        Console.WriteLine("Produect Name = " + p.UnitPrice);
                        Console.WriteLine("Produect Name = " + p.ExpiryDate);
                        counter++;
                    }

                    Console.WriteLine("\n showing with for loop\n");
                    for (int i = 0; i < productsList.Count; i++)
                    {
                        Product p = new Product();
                        p = productsList[i];

                        Console.WriteLine("Produect No. " + i);
                        Console.WriteLine("Produect Name = " + p.Name);
                        Console.WriteLine("Produect Name = " + p.UnitPrice);
                        Console.WriteLine("Produect Name = " + p.ExpiryDate);
                    }

                }


                if (option == "3")
                {
                    Console.WriteLine("\n Enter product name to search\n");
                    string name = Console.ReadLine();
                                        
                    foreach (Product p in productsList)
                    {
                        if (p.Name.Contains(name))
                        {
                            Console.WriteLine("Produect Name = " + p.Name);
                            Console.WriteLine("Produect Name = " + p.UnitPrice);
                            Console.WriteLine("Produect Name = " + p.ExpiryDate);
                        }
                    }
                }

                if (option == "4")
                {
                    Console.WriteLine("\n Enter product name to edit\n");
                    string name = Console.ReadLine();
                    Product p2 = new Product();

                    for (int i = 0; i < productsList.Count; i++)
                    {
                        Product p = new Product();
                        p = productsList[i];
                        if (p.Name.Contains(name))
                        {
                            Console.WriteLine("Please enter product unit price of " + p.Name);
                            string sUnitPrice = Console.ReadLine();
                            p.UnitPrice = Convert.ToDouble(sUnitPrice);

                            Console.WriteLine("New price value =  " + p.UnitPrice);
                            productsList[i] = p;
                            break;
                        }                        
                    }

                }

                if (option == "9")
                {
                    break;
                }

            } while (option != "9");

            Console.Clear();            
            Console.WriteLine("\nYou have been signed out\n");

            
        }
    }
}
