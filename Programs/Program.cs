//CopyRight... Zain & Suli's Point Of Sale Software... Don't Delete This Line...God is Watching...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication6
{
struct Products  // Products Datatype
        {
            public string Name;          //Property Name
            public double UnitPrice;     //Property Unit Price
            public int Qty;              //Property Quantity
            public DateTime ManufacturingDate; //Property Manufactoring Date
            public DateTime ExpiryDate;        //Property Expiry date
            public string Unit;

        }


    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            //Console.Beep(1000,500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Title = "Zain & Suli's Point Of Sale Software";

                           Products Item = new Products();

                List<Products> ItemList = new List<Products>(); //As List<DataType> ObjectName = new List<DataType>();

                string Choice = string.Empty;
                do
                {
                    Console.SetWindowSize(120,40);
                    Console.CursorLeft = 50;
                    Console.WriteLine("Press 1 To Add Item\n");
                    Console.CursorLeft = 50;
                    Console.WriteLine("Press 2 To Remove All Items\n");
                    Console.CursorLeft = 50;
                    Console.WriteLine("Press 3 To Display All Items\n");
                    Console.CursorLeft = 50;
                    Console.WriteLine("Press 4 To Listen To Music\n");
                    Console.CursorLeft = 50;
                    Console.WriteLine("Press 5 To See Lightning Show\n");
                    Console.CursorLeft = 50;
                    Console.WriteLine("Press 6 To See Important Info\n");
                    Console.CursorLeft = 50;
                    Console.WriteLine("Write Exit To Exit\n");


                    Console.CursorLeft = 50;
                    Choice = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (Choice == "1")
                    {
                        Console.CursorLeft = 50;
                        Console.WriteLine("Enter Item Name\n");
                        Console.CursorLeft = 50;
                        string Name = Console.ReadLine();
                        Item.Name = Name;
                        Console.WriteLine("\n");

                        Console.CursorLeft = 50;
                        Console.WriteLine("Enter Item Quantity\n");
                        Console.CursorLeft = 50;
                        string Qty = Console.ReadLine();
                        Item.Qty = Convert.ToInt32(Qty);
                        Console.WriteLine("\n");

                        Console.CursorLeft = 50;
                        Console.WriteLine("Enter Item's Unit Price\n");
                        Console.CursorLeft = 50;
                        string UnitPrice = Console.ReadLine();
                        Item.UnitPrice = Convert.ToDouble(UnitPrice);
                        Console.WriteLine("\n");

                        Console.CursorLeft = 50;
                        Console.WriteLine("Enter Item's Unit i.e. KiloGrams or Grams\n");
                        Console.CursorLeft = 50;
                        string Unit = Console.ReadLine();
                        Item.Unit = Unit;
                        Console.WriteLine("\n");

                        Console.CursorLeft = 50;
                        Console.WriteLine("Enter Item's Manufacturing Date\n");
                        Console.CursorLeft = 50;
                        string ManufacturingDate = Console.ReadLine();
                        Item.ManufacturingDate = Convert.ToDateTime(ManufacturingDate);
                        Console.WriteLine("\n");

                        Console.CursorLeft = 50;
                        Console.WriteLine("Enter Item's Expiry Date\n");
                        Console.CursorLeft = 50;
                        string ExpiryDate = Console.ReadLine();
                        Item.ExpiryDate = Convert.ToDateTime(ExpiryDate);
                        Console.WriteLine("\n");

                       ItemList.Add(Item);

                       Console.CursorLeft = 50;
                        Console.WriteLine("Item Added...\n");
                        Console.WriteLine("\n");
                        //roductlist.ToString();


                        // Console.WriteLine("press 2 to remove");
                        //string opt2=Console.ReadLine();
                    }
                    if (Choice == "2")
                    {

                        ItemList.Remove(Item);

                        Console.CursorLeft = 50;
                        Console.WriteLine("item Removed");
                        Console.CursorLeft = 50;
                        Console.ReadLine();
                        Console.WriteLine("\n");

                    }
                    if (Choice == "3")
                    {

                        int counter = 1;
                        foreach (Products items in ItemList)
                        {
                            Console.CursorLeft = 50;
                            Console.WriteLine("Item's Number " + counter.ToString());
                            Console.CursorLeft = 50;
                            Console.WriteLine("Item's Name " + Item.Name);
                            Console.CursorLeft = 50;
                            Console.WriteLine("Item's Unit Price " + Item.UnitPrice);
                            Console.CursorLeft = 50;
                            Console.WriteLine("Item's Quantity " + Item.Qty);
                            Console.CursorLeft = 50;
                            Console.WriteLine("Item's Units " + Item.Unit);
                            counter++;
                            Console.WriteLine("\n");
                        }


                    }
                    if (Choice == "4")
                    {
                        //Super Mario Music
                        Console.Beep(659, 125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(523, 125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(784, 125);
                        Thread.Sleep(375);
                        Console.Beep(392, 125);
                        Thread.Sleep(375);
                        Console.Beep(523, 125);
                        Thread.Sleep(250);
                        Console.Beep(392, 125);
                        Thread.Sleep(250);
                        Console.Beep(330, 125);
                        Thread.Sleep(250);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);
                        Console.Beep(494, 125);
                        Thread.Sleep(125);
                        Console.Beep(466, 125);
                        Thread.Sleep(42);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);
                        Console.Beep(392, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(784, 125);
                        Thread.Sleep(125);
                        Console.Beep(880, 125);
                        Thread.Sleep(125);
                        Console.Beep(698, 125);
                        Console.Beep(784, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(587, 125);
                        Console.Beep(494, 125);
                        Thread.Sleep(125);
                        Console.Beep(523, 125);
                        Thread.Sleep(250);
                        Console.Beep(392, 125);
                        Thread.Sleep(250);
                        Console.Beep(330, 125);
                        Thread.Sleep(250);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);
                        Console.Beep(494, 125);
                        Thread.Sleep(125);
                        Console.Beep(466, 125);
                        Thread.Sleep(42);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);
                        Console.Beep(392, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(784, 125);
                        Thread.Sleep(125);
                        Console.Beep(880, 125);
                        Thread.Sleep(125);
                        Console.Beep(698, 125);
                        Console.Beep(784, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(587, 125);
                        Console.Beep(494, 125);
                        Thread.Sleep(375);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(415, 125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(698, 125);
                        Thread.Sleep(125);
                        Console.Beep(698, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(625);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(415, 125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(622, 125);
                        Thread.Sleep(250);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(523, 125);
                        Thread.Sleep(1125);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(415, 125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(698, 125);
                        Thread.Sleep(125);
                        Console.Beep(698, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(625);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(415, 125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(622, 125);
                        Thread.Sleep(250);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(523, 125);
                        Thread.Sleep(625);
                    }
                    if (Choice == "5")
                    {
                        //Lights
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Thread.Sleep(200);
                        Console.Clear();
                    }
                    if (Choice == "6")
                    {
                        Console.Clear();
                        Console.CursorLeft = 50;
                        Console.WriteLine("Copyright");
                        Console.CursorLeft = 37;
                        Console.WriteLine("Zain & Suli's Point Of Sale Software\n");
                        Console.ReadLine();
                        return;
                    }
                } while (Choice != "Exit");
                Console.Clear();
                Console.Beep(1000, 500);
            }
        }
    }
