using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_Nim
{
    public class Piles
    {
        public int amount;

        private List<int> piles = new List<int>();

        public void addPile(int Pile) { piles.Add(Pile); }
        public void subtractPile(int Index, int Amount) { piles[Index] -= Amount; }
        public int getPile(int Index) { return piles[Index]; }
        public int getCount() { return piles.Count; }
        public void removePile(int Index) { piles.RemoveAt(Index); }
        public List<int> getPiles() { return piles; }

        Random ran = new Random();

        public Piles(int MaxValue, int Piles)
        {
            for (int i = 0; i < Piles; i++)
            {
                if (i == (Piles - 1))
                {
                    addPile(pileGenerator(MaxValue, false));
                }
                else
                {
                    addPile(pileGenerator(MaxValue));
                    MaxValue -= getPile(i);
                }
            }

            for (int x = 0; x < piles.Count; x++)
            {
                if (piles[x] == 0)
                {
                    piles.RemoveAt(x);
                }
            }

        }

        public int pileGenerator(int MaxValue, bool randomize = true)
        {
            return amount = (randomize ? ran.Next(1, MaxValue) : MaxValue);
        }

        public void zeroValuePiles()
        {
            for (int x = 0; x < piles.Count; x++)
            {
                if (piles[x] == 0)
                {
                    piles.RemoveAt(x);
                }

            }
        }
    }
}
