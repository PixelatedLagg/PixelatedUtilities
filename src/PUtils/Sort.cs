using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PUtils
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
        public static int ValueAt(this int[] array, SortMethods method, int i)
        {
            if (array.Count() < i || i < 0)
            {
                return 0;
            }
            switch (method)
            {
                case SortMethods.Highest:
                    return Sort.ByHighest(array)[i];
                case SortMethods.Lowest:
                    return Sort.ByLowest(array)[i];
                default:
                    return 0;
            }
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
        public static double ValueAt(this double[] array, SortMethods method, int i)
        {
            if (array.Count() < i || i < 0)
            {
                return 0;
            }
            switch (method)
            {
                case SortMethods.Highest:
                    return Sort.ByHighest(array)[i];
                case SortMethods.Lowest:
                    return Sort.ByLowest(array)[i];
                default:
                    return 0;
            }
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
        public static decimal ValueAt(this decimal[] array, SortMethods method, int i)
        {
            if (array.Count() < i || i < 0)
            {
                return 0;
            }
            switch (method)
            {
                case SortMethods.Highest:
                    return Sort.ByHighest(array)[i];
                case SortMethods.Lowest:
                    return Sort.ByLowest(array)[i];
                default:
                    return 0;
            }
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
        public static int ValueAt(this List<int> list, SortMethods method, int i)
        {
            if (list.Count() < i || i < 0)
            {
                return 0;
            }
            switch (method)
            {
                case SortMethods.Highest:
                    return Sort.ByHighest(list)[i];
                case SortMethods.Lowest:
                    return Sort.ByLowest(list)[i];
                default:
                    return 0;
            }
        }
        public static Dictionary<string, ulong> ByHighest(this Dictionary<string, ulong> dict)
        {
            Dictionary<string, ulong> result = new Dictionary<string, ulong>();
            do
            {
                var pair = dict.Aggregate((l, r) => l.Value > r.Value ? l : r);
                result.Add(pair.Key, pair.Value);
                dict.Remove(pair.Key);
            }
            while (dict.Count != 0);
            return result;
        }
    }
    public enum SortMethods
    {
        Highest,
        Lowest
    }
    public class test
    {
        public test this[int i]
        {
            get
            {
                return new test();
            }
        }
    }
}