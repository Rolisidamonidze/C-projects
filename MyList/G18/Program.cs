using System;
using System.Collections;
using System.Diagnostics;

namespace G18
{
    class Program
    {
        static void Main()
        {
            MyList myList = new MyList();
            myList.Add("Shako");
            myList.Add("Guga");
            myList.Add("Madona");
            myList.Add("Lasha");
            myList.Add("Shako");
          
            foreach(var item in myList)
            {
                Console.WriteLine(item);
            }

            //Stopwatch stopwatch = new Stopwatch();
            //const int steps = 1000000;

            //MyList myList = new MyList();
            //Console.WriteLine("My list begin...");
            //stopwatch.Start();
            //for (int i = 0; i < steps; i++)
            //{
            //    myList.Add(i);
            //}
            //stopwatch.Stop();

            //Console.WriteLine("My list completed !");
            //Console.WriteLine($"Milliseconds: {stopwatch.ElapsedMilliseconds}");
            //Console.WriteLine($"Ticks: {stopwatch.ElapsedTicks}");

            //stopwatch.Reset();
            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine("ArrayList begin...");
            //stopwatch.Start();
            //for (int i = 0; i < steps; i++)
            //{
            //    arrayList.Add(i);
            //}
            //stopwatch.Stop();
            //Console.WriteLine("ArrayList completed !");
            //Console.WriteLine($"Milliseconds: {stopwatch.ElapsedMilliseconds}");
            //Console.WriteLine($"Ticks: {stopwatch.ElapsedTicks}");
        }
    }
}
