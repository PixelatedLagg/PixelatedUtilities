using System;
using PixelatedUtilities;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Testing PixelatedUtilities...");
            //Dictionary:
            //Random KeyValuePair
            //Get key by value
            //
            //Numbers:
            Dictionary<string, int> dict = new();
            dict.Add("a", 1);
            dict.Add("b", 2);
            dict.Add("c", 3);

            Pack<int, int> pack = new(); //Stores 2 unique values (inspired by KeyValuePair)
            pack.SetValues(1, 2); //Sets both values

            Console.WriteLine(pack.Value1 + pack.Value2);
            Console.WriteLine(pack.GetType()); //Finds type
            Console.WriteLine(dict.KeyHasValue(2)); //Finds key by value
            Console.WriteLine(dict.RandomPair()); //Finds random pair
        }
    }
}
