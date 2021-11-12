using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PixelatedUtilities
{
    public static class Sort
    {
        public static int[] ByHighest(int[] array)
        {
            List<int> duplicate = array.ToList();
            List<int> result = new List<int>();
            do
            {
                result.Add(duplicate.Max());
                duplicate.RemoveAt(duplicate.IndexOf(duplicate.Max()));
            }
            while (duplicate.Count != 0);
            return result.ToArray();
        }
        public static int[] ByLowest(int[] array)
        {
            List<int> duplicate = array.ToList();
            List<int> result = new List<int>();
            do
            {
                result.Add(duplicate.Min());
                duplicate.RemoveAt(duplicate.IndexOf(duplicate.Min()));
            }
            while (duplicate.Count != 0);
            return result.ToArray();
        }
        public static int ValueAt(this int[] array, int i)
        {
            if (array.Count() < i || i < 0)
            {
                return 0;
            }
            return array[i];
        }
        public static double[] ByHighest(double[] array)
        {
            List<double> duplicate = array.ToList();
            List<double> result = new List<double>();
            do
            {
                result.Add(duplicate.Max());
                duplicate.RemoveAt(duplicate.IndexOf(duplicate.Max()));
            }
            while (duplicate.Count != 0);
            return result.ToArray();
        }
        public static double[] ByLowest(double[] array)
        {
            List<double> duplicate = array.ToList();
            List<double> result = new List<double>();
            do
            {
                result.Add(duplicate.Min());
                duplicate.RemoveAt(duplicate.IndexOf(duplicate.Min()));
            }
            while (duplicate.Count != 0);
            return result.ToArray();
        }
        public static double ValueAt(this double[] array, int i)
        {
            if (array.Count() < i || i < 0)
            {
                return 0;
            }
            return array[i];
        }
        public static decimal[] ByHighest(decimal[] array)
        {
            List<decimal> duplicate = array.ToList();
            List<decimal> result = new List<decimal>();
            do
            {
                result.Add(duplicate.Max());
                duplicate.RemoveAt(duplicate.IndexOf(duplicate.Max()));
            }
            while (duplicate.Count != 0);
            return result.ToArray();
        }
        public static decimal[] ByLowest(decimal[] array)
        {
            List<decimal> duplicate = array.ToList();
            List<decimal> result = new List<decimal>();
            do
            {
                result.Add(duplicate.Min());
                duplicate.RemoveAt(duplicate.IndexOf(duplicate.Min()));
            }
            while (duplicate.Count != 0);
            return result.ToArray();
        }
        public static decimal ValueAt(this decimal[] array, int i)
        {
            if (array.Count() < i || i < 0)
            {
                return 0;
            }
            return array[i];
        }
        public static List<int> ByHighest(List<int> array)
        {
            List<int> result = new List<int>();
            do
            {
                result.Add(array.Max());
                array.RemoveAt(array.IndexOf(array.Max()));
            }
            while (array.Count != 0);
            return result;
        }
        public static List<int> ByLowest(List<int> array)
        {
            List<int> result = new List<int>();
            do
            {
                result.Add(array.Max());
                array.RemoveAt(array.IndexOf(array.Max()));
            }
            while (array.Count != 0);
            return result;
        }
    }
}