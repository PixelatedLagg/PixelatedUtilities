using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Collections.ObjectModel;

namespace PixelatedUtilities
{
    public static class PL
    {
        /// <summary>
        /// Returns a key that has a value equivalent of the entered value.
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        /**public static string StringHasInt(this Dictionary<string,int>dict,int value){ return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static string StringHasDouble(this Dictionary<string, double> dict, double value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static string StringHasUlong(this Dictionary<string, ulong> dict, ulong value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static string StringHasString(this Dictionary<string, string> dict, string value) { return dict.FirstOrDefault(x => x.Value == value).Key; }**/
        public static string KeyHasValue(this Dictionary<string, int> dict, int value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static int IntHasDouble(this Dictionary<int, double> dict, double value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static int IntHasUlong(this Dictionary<int, ulong> dict, ulong value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static int IntHasString(this Dictionary<int, string> dict, string value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static double DoubleHasInt(this Dictionary<double, int> dict, int value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static double DoubleHasDouble(this Dictionary<double, double> dict, double value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static double DoubleHasUlong(this Dictionary<double, ulong> dict, ulong value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static double DoubleHasString(this Dictionary<double, string> dict, string value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static ulong UlongHasInt(this Dictionary<ulong, int> dict, int value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static ulong UlongHasDouble(this Dictionary<ulong, double> dict, double value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static ulong UlongHasUlong(this Dictionary<ulong, ulong> dict, ulong value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
        public static ulong UlongHasString(this Dictionary<ulong, string> dict, string value) { return dict.FirstOrDefault(x => x.Value == value).Key; }
    }
    public static class Dict
    {
        /**public static void KeyHasValue<TKey, TValue>(this Dictionary<TKey, TValue> dict, object value)
        {
            Console.WriteLine(value);
            Console.WriteLine();
            return dict.FirstOrDefault(x => x.Value == value).Key;
        }
        public static object KeyHasValue<TKey, TValue>(this Dictionary<TKey, TValue> d, object value) where TKey : TValue, IConvertible
        {
            Dictionary<object, object> dict = new Dictionary<object, object>();
            foreach (KeyValuePair<TKey, TValue> p in d)
            {
                dict.Add((object)p.Key, (object)p.Value);
            }
            return dict.FirstOrDefault(x => x.Value == value).Key;
        }**/
        public static KeyValuePair<TKey, TValue> RandomPair<TKey, TValue>(this Dictionary<TKey, TValue> dict)
        {
            Random rnd = new Random();
            return dict.ElementAt(rnd.Next(0, dict.Count));
        }
        public static double ValueSum<TKey>(this Dictionary<TKey, Int16> dict)
        { double i = 0; foreach (KeyValuePair<TKey, Int16> p in dict) { i += Convert.ToDouble(p.Value); } return i; }
        public static double ValueSum<TKey>(this Dictionary<TKey, Int32> dict)
        { double i = 0; foreach (KeyValuePair<TKey, Int32> p in dict) { i += Convert.ToDouble(p.Value); } return i; }
        public static double ValueSum<TKey>(this Dictionary<TKey, Int64> dict)
        { double i = 0; foreach (KeyValuePair<TKey, Int64> p in dict) { i += Convert.ToDouble(p.Value); } return i; }
        public static double ValueSum<TKey>(this Dictionary<TKey, UInt16> dict)
        { double i = 0; foreach (KeyValuePair<TKey, UInt16> p in dict) { i += Convert.ToDouble(p.Value); } return i; }
        public static double ValueSum<TKey>(this Dictionary<TKey, UInt32> dict)
        { double i = 0; foreach (KeyValuePair<TKey, UInt32> p in dict) { i += Convert.ToDouble(p.Value); } return i; }
        public static double ValueSum<TKey>(this Dictionary<TKey, UInt64> dict)
        { double i = 0; foreach (KeyValuePair<TKey, UInt64> p in dict) { i += Convert.ToDouble(p.Value); } return i; }
    }
    /**public readonly struct Pack : IComparable, IComparable<Int32>, IConvertible, IEquatable<Int32>, IFormattable
    {
        readonly ObservableCollection<Pack> pack = new ObservableCollection<Pack>();
    }**/
}
