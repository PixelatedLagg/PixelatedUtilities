using System;
using System.Collections.Generic;
using System.Text;

namespace PUtils
{
    public class sstring : Special
    {
        private int _length;
        private static string _val;
        public string Native
        {
            get
            {
                return _val;
            }
        }
        public int Size
        {
            get
            {
                return ASCIIEncoding.Unicode.GetByteCount(_val);
            }
        }
        private int RefreshLength()
        {
            int length = 0;
            foreach (char c in _val)
            {
                length++;
            }
            _length = length;
            return length;
        }
        public int Length
        {
            get
            {
                return RefreshLength();
            }
        }
        public sstring(string val)
        {
            _val = val;
            if (val == null)
            {
                _length = 0;
                return;
            }
            int length = 0;
            foreach (char c in _val)
            {
                length++;
            }
            _length = length;
        }
        public sstring Concat(string val)
        {
            _val += val;
            return _val;
        }
        public int ToInt()
        {
            int result;
            if (!Int32.TryParse(_val, out result))
            {
                return 0;
            }
            return Int32.Parse(_val);
        }
        public bool TryToInt()
        {
            int result;
            if (!Int32.TryParse(_val, out result))
            {
                return false;
            }
            return true;
        }
        public bool IsEmpty()
        {
            if (String.IsNullOrEmpty(_val) || String.IsNullOrWhiteSpace(_val))
            {
                return true;
            }
            return false;
        }
        public sstring[] Split(int place)
        {
            char[] array = ToCharArray();
            string left = "";
            string right = "";
            for (int i = 0; i < _val.Length; i++)
            {
                if (i < place)
                {
                    left += array[i];
                    continue;
                }
                else if (i > place)
                {
                    right += array[i];
                    continue;
                }
            }
            return new sstring[] {left, right};
        }
        public sstring[] SplitByStep(int step)
        {
            char[] array = ToCharArray();
            sstring[] result = new sstring[(int)(_val.Length / step)];
            int stringPlace = 0;
            int place = 0;
            foreach (char c in _val)
            {
                if (place == step)
                {
                    stringPlace++;
                    place = 0;
                }
                Console.WriteLine(stringPlace);
                result[stringPlace] += c;
                place++;
            }
            return result;
        }
        public char[] ToCharArray()
        {
            char[] result = new char[_val.Length];
            int place = 0;
            foreach (char c in _val)
            {
                result[place] = c;
                place++;
            }
            return result;
        }
        public IEnumerator<char> GetEnumerator()
        {
            foreach (char c in _val)
            {
                yield return c;
            }
        }
        public object ToNative()
        {
            return _val;
        }
        public static implicit operator sstring(string val)
        {
            return new sstring(val);
        }
        public static implicit operator string(sstring val)
        {
            return _val;
        }
        public static explicit operator int(sstring val)
        {
            int result;
            if (!Int32.TryParse(_val, out result))
            {
                return 0;
            }
            return Int32.Parse(_val);
        }
    }
}