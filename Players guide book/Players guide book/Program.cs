using System;
using System.Threading;

namespace Players_guide_book
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DieRollGame());
        }

        static int DieRollGame()
        {
            Random random = new Random();

            int Roll(int sides = 6)
            {
                return random.Next(sides) + 1;
            }

            return Roll(sides: 3);
        }

    }
}
