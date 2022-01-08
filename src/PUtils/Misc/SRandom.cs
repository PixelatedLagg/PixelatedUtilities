using System;
using System.Text;

namespace PUtils
{
    public class SRandom
    {
        //SRandom() and Long() credited to: ekepes (github)
        private const long m = 4294967296;
        private const long a = 1664525;
        private const long c = 1013904223;
        private long _last;
        public SRandom() 
        {
            _last = DateTime.Now.Ticks % m;
        }
        public long Long()
        {
            _last = ((a * _last) + c) % m;
            return _last;
        }
        public long Range(long min, long max)
        {
            return Long() % (max - min) + min;
        }
        public int Single()
        {
            return (int)Range(0, 9);
        }
        public double Double()
        {
            return Convert.ToDouble($"0.{Range(0, 99)}");
        }
        public int Int()
        {
            return (int)Range(-2147483648, 2147483647);
        }
        public ushort UShort()
        {
            return (ushort)Range(0, 65535);
        }
        public long Length(int length)
        {
            if (length <= 0)
            {
                return 0;
            }
            StringBuilder top = new StringBuilder(length);
            StringBuilder bottom = new StringBuilder(length);
            bottom.Append('1');
            for (int x = 0; x < length; x++)
            {
                top.Append('9');
                if (bottom.Length == length)
                {
                    continue;
                }
                bottom.Append('0');
            }
            return Range(Convert.ToInt64(bottom.ToString()), Convert.ToInt64(top.ToString()));
        }
    }
}