using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Nim
{
    public class Player
    {
        Random pile = new Random();
        Random amount = new Random();

        int index;
        int gain;

        private int Stones;

        public int getStones { get { return Stones; } } 
        public void addStones(int x) { Stones += x; }

        public Player()
        {
            Stones = 0;
        }

        public void playerRandom(List<int> ls)
        {
            index = pile.Next(0, 2);
            gain = amount.Next(1, 2);

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

        public void playerLow(List<int> ls)
        {
            int temp;
            if (ls.Min() == 1)
            {
                addStones(1);
                temp = ls.Min();
                ls.Find(x => x.Equals(temp));
            }
            else if (ls.Min() == 2)
            {
                addStones(2);
                temp = ls.Min();
                ls.Find(x => x.Equals(temp));
            }
            else
            {

            }
        }
    }
}
