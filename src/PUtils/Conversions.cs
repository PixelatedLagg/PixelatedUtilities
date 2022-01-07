using System;
using System.Linq;

namespace PUtils
{
    public static class Conversions
    {
        public static bool CanConvertToBool(this string str)
        {
            if (str.ToLower() == "true" || str.ToLower() == "false")
            {
                return true;
            }
            return false;
        }
        public static bool CanConvertToInt(this string str)
        {
            if (str.Where(char.IsDigit).ToArray().Length != str.Length)
            {
                return false;
            }
            return true;
        }
        public static int? ConvertPartsToInt(this string str)
        {
            if (str.Where(char.IsNumber).ToArray().Length == 0)
            {
                return null;
            }
            return str.Where(char.IsNumber).ToArray().ConvertToInt();
        }
        public static int ConvertToInt(this char[] array)
        {
            string result = "";
            for (int x = 0; x < array.Length; x++)
            {
                result += array[x];
            }
            return Convert.ToInt32(result);
        }
    }
}