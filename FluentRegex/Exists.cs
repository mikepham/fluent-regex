namespace FluentRegex
{
    public static class Exists
    {
        public static PatternFormat AtLeastOnce()
        {
            return new PatternFormat("{0}?");
        }
    }
}