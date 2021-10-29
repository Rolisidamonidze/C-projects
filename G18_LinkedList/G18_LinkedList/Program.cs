using System;
using System.Collections.Generic;

namespace G18_LinkedList
{
    class Program
    {
        static void Main()
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            linkedList.AddFirst(6);
            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);

            linkedList.AddLast(7);
            linkedList.AddLast(8);
            linkedList.AddLast(9);
            linkedList.AddLast(10);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
