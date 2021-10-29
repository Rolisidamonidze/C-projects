using System;

namespace Fauna
{
    class Program
    {
        
        static void Main()
        {
            Dog[] dogs = new Dog[5];
            dogs[0] = new Dog() { Name = "Jack", Weight = 20 };
            dogs[1] = new Dog() { Name = "Mikel", Weight = 35 };
            dogs[2] = new Dog() { Name = "Sam", Weight = 12 };
            dogs[3] = new Dog() { Name = "Paul", Weight = 15 };
            dogs[4] = new Dog() { Name = "John", Weight = 10 };

            MyCompare compare = dogs[0].getCompare();
            Tools.Sort(dogs, compare);
            for (int i = 0; i < dogs.Length; i++)
            {
                Console.WriteLine(dogs[i]);
            }
        }
    }
}
