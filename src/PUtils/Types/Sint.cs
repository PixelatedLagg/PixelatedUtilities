namespace PUtils 
{
    public sealed class sint : SpecialObject
    {
        private static int _val;
        public sint(int val)
        {
            _val = val;
        }
        public static sint operator +(sint val)
        {
            return _val + val.ToInt();
        }
        public static sint operator -(sint val)
        {
            return _val - val.ToInt();
        }
        public static bool operator ==(sint val1, sint val2)
        {
            return val1.ToInt() == val2.ToInt();
        }
        public static bool operator !=(sint val1, sint val2)
        {
            return val1.ToInt() != val2.ToInt();
        }
        public object ToNative()
        {
            return _val;
        }
        public static implicit operator sint(int val)
        {
            return new sint(val);
        }
        public static implicit operator int(sint val)
        {
            return _val;
        }
        public override bool Equals(object obj)
        {
            if (obj as sint != null)
            {
                if ((sint)obj == _val)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return _val.GetHashCode();
        }
        public object ToObject()
        {
            return _val;
        }
        public int ToInt()
        {
            return _val;
        }
    }
}