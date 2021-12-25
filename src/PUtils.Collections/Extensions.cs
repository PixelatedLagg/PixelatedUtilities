namespace PUtils.Collections
{
    public static class CollectionsExtensions
    {
        public static pulist ToPulist(this Special[] val)
        {
            pulist result = new pulist();
            foreach (Special s in val)
            {
                result.Add(s);
            }
            return result;
        }
    }
}