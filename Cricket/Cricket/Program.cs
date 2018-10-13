using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Choice\n");
            Console.WriteLine("Enter T to Toss\nA to Enter Team A\nB to Enter Team B\n");
            string choice;
            choice = Console.ReadLine();
            switch (choice)
            {
                case "T":
                    {
                        GameManager GM = new GameManager();
                        GM.Toss();
                        break;
                    }
                case "A":
                    {
                        GameManager GA = new GameManager();
                        GA.EnterTeamA();
                        Console.ReadLine();
                        break;
                    }
                case "B":
                    {
                        GameManager GA = new GameManager();
                        GA.EnterTeamB();
                        Console.ReadLine();
                        break;
                    }
                case "C":
                    {

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
