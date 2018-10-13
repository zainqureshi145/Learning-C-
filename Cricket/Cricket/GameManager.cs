using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class GameManager:Player
    {
        public void Toss()
        {
            Random r = new Random();
            int n = r.Next(1, 50);
            if ((n % 2) != 0)//Check Even Or Odd if Even Head Wins, else Tail Wins
            {
                Console.WriteLine("Congrats Tails");
                Console.WriteLine(n % 2);
            }
            else
            {
                Console.WriteLine("Congrats Heads");
                Console.WriteLine(n % 2);
            }
            Console.ReadLine();
        }

        public void PlayGame()
        {
            
        }
        public void EnterTeamA()
        {
            Player TeamA = new Player();
            Console.WriteLine("Enter 11 Players\n");
            for (int x = 0; x < 10; x++)
            {
                TeamA.Name = Console.ReadLine();
                Utility.TeamA.Add(TeamA);
            }
            Console.WriteLine("Player Names Added");
            foreach (Player p in Utility.TeamA)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadLine();
        }
        public void EnterTeamB()
        {
            Player TeamB = new Player();
            Console.WriteLine("Enter 11 Players\n");
            for (int x = 0; x < 10; x++)
            {
                TeamB.Name = Console.ReadLine();
                Utility.TeamB.Add(TeamB);
            }
            Console.WriteLine("Player Names Added");
            foreach (Player p in Utility.TeamA)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadLine();
        }
    }
}
