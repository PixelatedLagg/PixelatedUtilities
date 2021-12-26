namespace PUtils.Collections
{
    public static class CollectionsExtensions
    {
        public static pulist ToPulist(this SpecialObject[] val)
        {
            pulist result = new pulist();
            foreach (SpecialObject s in val)
            {
                result.Add(s);
            }
            return result;
        }
    }
}