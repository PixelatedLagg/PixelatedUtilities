using System;
using System.Text;

namespace PUtils
{
    public struct sbool
    {
        private static bool _val;
        public int Size
        {
            get
            {
                return sizeof(bool);
            }
        }
        public sbool(bool val)
        {
            _val = val;
        }
        public int ToInt()
        {
            if (_val)
            {
                return 1;
            }
            return 0;
        }
        public static implicit operator sbool(bool val)
        {
            return new sbool(val);
        }
        public static implicit operator bool(sbool val)
        {
            return _val;
        }
    }
}