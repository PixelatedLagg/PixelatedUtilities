using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelatedUtilities.Numbers
{
    public static class Number
    {
        /// <summary>
        /// Generates a random number within the lowest value and highest value.
        /// Note: The random number can include both the lowest value AND the highest value.
        /// </summary>
        /// <param name="lowestValue"></param>
        /// <param name="highestValue"></param>
        /// <returns></returns>
        public static int RandomInt(int lowestValue, int highestValue)
        {
            highestValue++;
            Random r = new Random();
            return r.Next(lowestValue, highestValue);
        }
        /// <summary>
        /// Generates a random number with the specified digits.
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static ulong RandomNumber(int digits)
        {
            Random r = new Random();
            string answer = "";
            for (int i = 0; i < digits; i++) { answer = $"{answer}{r.Next(0, 10)}"; }
            return Convert.ToUInt64(answer);
        }
        /// <summary>
        /// Generates a random double between 0 and 1.
        /// </summary>
        /// <returns></returns>
        public static double RandomDouble()
        {
            Random r = new Random();
            return r.NextDouble();
        }
        /// <summary>
        /// Returns "even" if value is even and "odd" if value is odd.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string EvenOrOdd(int value) { if (value % 2 == 0) { return "even"; } else { return "odd"; } }
    }
}
