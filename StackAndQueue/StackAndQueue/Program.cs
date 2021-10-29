using System;
using System.Collections;

namespace StackAndQueue
{
    class Program
    {
        static void Main()
        {
            MyQueue myQueue = new MyQueue();
            myQueue.Enqueue("Zura");
            myQueue.Enqueue("Mari");
            myQueue.Enqueue("Shako");
            myQueue.Enqueue("Misho");
            myQueue.Enqueue("Lasha");

            foreach(var item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
