using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Collections.ObjectModel;

namespace PUtils
{
    public static class Dict
    {
        /// <summary>
        /// Returns key by value.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="d"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object KeyHasValue<TKey, TValue>(this Dictionary<TKey, TValue> d, object value)
        {
            Dictionary<object, object> dict = new Dictionary<object, object>();
            foreach (KeyValuePair<TKey, TValue> p in d) { dict.Add((object)p.Key, (object)p.Value); }
            return dict.FirstOrDefault(x => x.Value == value).Key;
        }
        /// <summary>
        /// Returns a random pair from a dictionary.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static KeyValuePair<TKey, TValue> RandomPair<TKey, TValue>(this Dictionary<TKey, TValue> dict)
        {
            Random rnd = new Random();
            return dict.ElementAt(rnd.Next(0, dict.Count));
        }
        /// <summary>
        /// Returns the sum of all values in a dictionary with numeric values.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static object ValueSum<TKey, TValue>(this Dictionary<TKey, TValue> dict) where TValue : IConvertible
        {
            try
            {
                double i = 0;
                foreach (KeyValuePair<TKey, TValue> p in dict) { i += Convert.ToDouble(p.Value); }
                return i;
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"{ex.Source.GetType()} is an invalid type for this operation!");
            }
        }
    }
}
