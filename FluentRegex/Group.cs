namespace FluentRegex
{
    public static class Group
    {
        public static PatternFormat ByName(string name)
        {
            return new PatternFormat("(?<" + name + ">{0})");
        }
    }
}