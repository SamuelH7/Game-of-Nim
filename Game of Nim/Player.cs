using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Nim
{
    public abstract class Player
    {
        private int winner;

        private int Stones;

        public int getStones { get { return Stones; } }
        public void addStones(int x) { Stones += x; }

        public int getWinner { get { return winner; } }

        public void addWinner()
        {
            winner += 1;
        }
        public Player()
        {
            Stones = 0;
        }

        public abstract void Strategy(List<int> ls);
    }

    class playerRandom : Player
    {
        public override void Strategy(List<int> ls)
        {
            Random pile = new Random();
            Random amount = new Random();

            int index = pile.Next(0, ls.Count - 1);
            int gain = amount.Next(1, 2);

            if (ls[index] == 0)
            {
            }
            else if (ls[index] == 1)
            {
                ls[index] -= 1;
                addStones(1);
            }
            else
            {
                ls[index] -= gain;
                addStones(gain);
            }
        }
    }

    class playerLow : Player
    {
        public override void Strategy(List<int> ls)
        {
            int temp;
            if (ls.Min() == 1)
            {
                addStones(1);
                temp = ls.Min();
                temp = ls.FindIndex(x => x.Equals(temp));
                ls[temp] -= 1;
            }
            else if (ls.Min() >= 2)
            {
                addStones(2);
                temp = ls.Min();
                temp = ls.FindIndex(x => x.Equals(temp));
                ls[temp] -= 2;
            }
            else
            {

            }

            if (ls.Count == 0)
            {
                addWinner();
            }
        }
    }
}
