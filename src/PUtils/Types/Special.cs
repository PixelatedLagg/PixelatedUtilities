namespace PUtils
{
    public sealed class special
    {
        private static SpecialObject _val;
        public special() {}
        public static implicit operator special(string val)
        {
            _val = new sstring(val);
            return new special();
        }
        public static implicit operator special(bool val)
        {
            _val = new sbool(val);
            return new special();
        }
        public static implicit operator special(int val)
        {
            _val = new sint(val);
            return new special();
        }
    }
}