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
            List<Player> players = new List<Player>();

            Player Player1 = new playerRandom();
            Player Player2 = new playerLow();

            players.Add(Player1);
            players.Add(Player2);

            for (int i = 0; i < 100; i++)
            {
                int token = 0;
                int Total;
                int Max = 100;

                Total = Max;

                var Pile1 = new Pile(Max);
                Max -= Pile1.amount;

                var Pile2 = new Pile(Max);
                Max -= Pile2.amount;

                var Pile3 = new Pile(Max, false);

                List<int> Piles = new List<int>();

                Piles.Add(Pile1.amount);
                Piles.Add(Pile2.amount);
                Piles.Add(Pile3.amount);

                for (int x = 0; x < Piles.Count; x++)
                {
                    if (Piles[x] == 0)
                    {
                        Piles.RemoveAt(x);
                    }
                }

                while (Piles.Count > 0)
                {
                    Player1.Strategy(Piles);

                    if (Piles.Count == 1 && Piles[0] == 0 )
                    {
                        Player1.addWinner();
                        token = 1;
                    }

                    Player2.Strategy(Piles);

                    if (Piles[0] == 0 && token == 0 && Piles.Count == 1)
                    {
                        Player2.addWinner();
                    }

                    for (int a = 0; a < Piles.Count; a++)
                    {
                        if (Piles[a] == 0)
                        {
                            Piles.RemoveAt(a);
                        }
                    }
                }
            }
            if (Player1.getWinner > Player2.getWinner)
            {
                Console.WriteLine("Player 1 won with {0} wins", Player1.getWinner);
            }
            else if(Player2.getWinner > Player1.getWinner)
            {
                Console.WriteLine("PLayer 2 won with {0} wins", Player2.getWinner);
            }
            else
            {
                Console.WriteLine("It was even");
            }
        }
    }
}
