using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelatedUtilities
{
    /// <summary>
    /// A type that stores 2 values of any type. Similar to KeyValuePair. 
    /// </summary>
    /// <typeparam name="TValue1"></typeparam>
    /// <typeparam name="TValue2"></typeparam>
    public struct Pack<TValue1, TValue2> where TValue1 : notnull where TValue2 : notnull
    {
        private TValue1 value1;
        private TValue2 value2;
        /// <summary>
        /// Creates new instance of Pack.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        public Pack(TValue1 value1, TValue2 value2) //Creates new instance of Pack
        {
            this.value1 = value1;
            this.value2 = value2;
        } 
        /// <summary>
        /// Gets or sets the first value.
        /// </summary>
        public TValue1 Value1 //Gets or sets the first value
        {
            get { return value1; }
            set { this.value1 = value; }
        }
        /// <summary>
        /// Gets or sets the second value.
        /// </summary>
        public TValue2 Value2 //Gets or sets the second value
        {
            get { return value2; }
            set { this.value2 = value; }
        }
        /// <summary>
        /// Sets both values.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        public void SetValues(TValue1 value1, TValue2 value2) //Sets both values
        {
            this.value1 = value1;
            this.value2 = value2;
        }
        /// <summary>
        /// Gets the type of Pack.
        /// </summary>
        /// <returns></returns>
        public new Type GetType() //Gets the type of Pack
        {
            return typeof(Pack<TValue1, TValue2>);
        }
    }
}
