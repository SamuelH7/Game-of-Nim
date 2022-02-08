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
                int Max = 100;

                Piles piles = new Piles(Max, 3);

                while (piles.getCount() > 0)
                {
                    foreach  (Player p in players)
                    {
                        p.Strategy(piles.getPiles());

                        piles.zeroValuePiles();

                        if (piles.getCount() == 0)
                        {
                            p.addWinner();
                            break;
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
