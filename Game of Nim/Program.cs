using System;

namespace Game_of_Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter max size of piles");
            string temp = Console.ReadLine();
            int Max = int.Parse(temp);

            var Pile1 =  new Pile(Max);
            Max -= Pile1.amount;

            var Pile2 = new Pile(Max);
            Max -= Pile2.amount;

            var Pile3 = new Pile(Max, false);

            Console.WriteLine(Pile1.amount + "/" + Pile2.amount + "/" + Pile3.amount + "/" + Pile1.amount);
        }
    }
}
