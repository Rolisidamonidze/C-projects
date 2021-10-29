using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public delegate bool MyCompare(object obj1, object obj2);
    static class Tools
    {
        static public void Sort(object[] array, MyCompare _compare)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (_compare(array[j], array[j + 1]))
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}