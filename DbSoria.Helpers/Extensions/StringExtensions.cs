namespace DbSoria.Helpers.Extensions
{
    public static class StringExtensions
    {
        public static string ToSubDomain(this string name)
        {
            return name.Replace(" ", "").ToLower();
        }
    }
}