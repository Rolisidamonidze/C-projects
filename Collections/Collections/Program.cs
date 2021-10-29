using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main()
        {
            ArrayList Fibonacci = new ArrayList();
            Console.WriteLine("Enter upperbound number: ");
            var bound = Convert.ToInt32(Console.ReadLine());

            int first = 0;
            int second = 1;
            int sum;

            while (first <= bound)
            {
                Fibonacci.Add(first);
                sum = first + second;
                first = second;
                second = sum;
            }

            var index = 0;

            foreach (var item in Fibonacci)
            {
                Console.WriteLine(Fibonacci[index]);
                index++;
            }


            // gadavxedot am klasis funqciebs 

            // gavaketot chveni sakutari listi. (araoficialurad)

            //gadavaketot fibonachis amocana arraylistze (oficialuri)
        }
    }
}
