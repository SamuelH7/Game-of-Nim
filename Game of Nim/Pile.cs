using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_Nim
{
    public class Pile
    {
        public int amount;
        
        Random ran = new Random();

        public Pile(int MaxValue, bool randomize=true)
        {
            amount = (randomize ? ran.Next(1, MaxValue) : MaxValue);
        }
    }
}
