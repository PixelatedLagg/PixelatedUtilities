using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelatedUtilities
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
        /// Returns "even" if value is even and "odd" if value is odd.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string EvenOrOdd(int value){if(value%2==0){return "even";}else{return "odd";}}
    }
}
