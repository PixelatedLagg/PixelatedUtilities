using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PixelatedUtilities
{
    public static class Order
    {
        internal static object[] IByHighest(this object[] array)
        {
            object[] result = array;
            Array.Sort(result);
            return result;
        }
        public static int[] ByHighest(this int[] array)
        {
            /*List<int> duplicate = array.ToList();
            List<int> result = new List<int>();
            do
            {
                result.Add(duplicate.Max());
                duplicate.RemoveAt(duplicate.IndexOf(duplicate.Max()));
            }
            while (duplicate.Count != 0);
            return result.ToArray();*/
            Array.Sort(array);
            return array;
        }
        public static int[] ByLowest(this int[] array)
        {
            List<int> duplicate = array.ToList();
            List<int> result = new List<int>();
            do
            {
                result.Add(duplicate.Min());
                duplicate.RemoveAt(duplicate.IndexOf(duplicate.Max()));
            }
            while (duplicate.Count != 0);
            return result.ToArray();
        }
        public static List<int> ByHighest(this List<int> array)
        {
            /*List<int> result = new List<int>();
            do
            {
                result.Add(array.Max());
                array.RemoveAt(array.IndexOf(array.Max()));
            }
            while (array.Count != 0);
            return result;*/
            array.Sort();
            return array;
        }
        public static string[] ByHighest(this string[] array)
        {
            string[] result = array;
            Array.Sort(result);
            return result;
        }
        public static double[] ByHighest(this double[] array)
        {
            double[] result = array;
            Array.Sort(result);
            return result;
        }
        public static decimal[] ByHighest(this decimal[] array)
        {
            decimal[] result = array;
            Array.Sort(result);
            return result;
        }
        public static char[] ByHighest(this char[] array)
        {
            char[] result = array;
            Array.Sort(result);
            return result;
        }
    }
}