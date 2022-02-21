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
            List<int> winner = new List<int>();

            int Temp;

            List<Player> players = new List<Player>();

            players.Add(new playerRandom());
            players.Add(new playerLow());

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
            foreach (Player p in players)
            {
                winner.Add(p.getWinner);
            }

            Temp = winner.IndexOf(winner.Max());

            Console.WriteLine("Player {0} won with {1} wins", players[Temp], players[Temp].getWinner);

            /*if (Player1.getWinner > Player2.getWinner)
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
            }*/
        }
    }
}
