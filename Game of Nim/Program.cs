using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            int Total;

            Console.WriteLine("Enter max size of piles");
            string temp = Console.ReadLine();
            int Max = int.Parse(temp);

            Total = Max;

            var Pile1 =  new Pile(Max);
            Max -= Pile1.amount;

            var Pile2 = new Pile(Max);
            Max -= Pile2.amount;

            var Pile3 = new Pile(Max, false);

            List<int> Piles = new List<int>();

            Piles.Add(Pile1.amount);
            Piles.Add(Pile2.amount);
            Piles.Add(Pile3.amount);

            var Player1 = new Player();
            var Player2 = new Player();

            while (Player1.getStones + Player2.getStones <= Total)
            {
                Player1.playerRandom(Piles);
                Player2.playerLow(Piles);
            }


            Console.WriteLine(Player1.getStones + "/" + Player2.getStones);
        }
    }
}
