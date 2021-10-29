using System;

namespace G_18._2
{
    class Program
    {
        static void Main()
        {
            Group group = new Group();

            foreach(string item in group)
            {
                Console.WriteLine(item);
            }

            //for (int i = 0; i < group.Count; i++)
            //{
            //    Console.WriteLine(group[i]);
            //}

            //amocana :  
            // amave kodshi shecvalet koleqcia ise ro enumeratoris 
            // implementacia ar iyos gatanili calke klasshi, aramed
            // titon group klasi uketebdes implementacias.
            //
            // amocana 2 :
            // aseve gauketet enumerables implementacia tqvens mylist
            // klashsi. enumeratori gaitanet calke klasshi
        }
    }
}
