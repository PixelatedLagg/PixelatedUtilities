namespace PUtils
{
    public static class Extensions
    {
        public static sstring ToSstring(this string val)
        {
            return new sstring(val);
        }
        public static sstring ToSstring(this char[] val)
        {
            string result = "";
            foreach (char c in val)
            {
                result += c;
            }
            return result.ToSstring();
        }
    }
}