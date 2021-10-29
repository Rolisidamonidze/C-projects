using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericMyList
{
    class Program
    {
        static void Main()
        {
            MyList<string> bands = new MyList<string>();
            bands.Add("The Beatles");
            bands.Add("Radiohead");
            bands.Add("The Strokes");
            bands.Add("Led Zeppelin");
            bands.Add("The Doors");
            bands.Add("Nirvana");

            bands.Remove("The Strokes");

            foreach (var band in bands)
            {
                Console.WriteLine(band);
            }
        }
    }
}
