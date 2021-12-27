using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Collections.ObjectModel;

namespace PUtils
{
    public static class Dictionary
    {
        /// <summary>
        /// Returns key by value.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TKey KeyHasValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TValue value)
        {
            foreach (KeyValuePair<TKey, TValue> kvp in dictionary)
            {
                if ((object)kvp.Value == (object)value)
                {
                    return kvp.Key;
                }
            }
            return default(TKey);
        }
        /// <summary>
        /// Returns a random pair from a dictionary.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static KeyValuePair<TKey, TValue> RandomPair<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            Random rnd = new Random();
            return dictionary.ElementAt(rnd.Next(0, dictionary.Count + 1));
        }
        /// <summary>
        /// Returns the sum of all values in a dictionary with numeric values.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static TValue ValueSum<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            if (dictionary.Values.First() as double? != null)
            {
                double result = 0;
                foreach (KeyValuePair<TKey, TValue> kvp in dictionary)
                {
                    result += (double)(object)kvp.Value;
                }
                return (TValue)(object)result;
            }
            return default(TValue);
        }
    }
}
