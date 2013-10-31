namespace FluentRegex
{
    /// <summary>
    /// Static helper for grouping matches.
    /// </summary>
    public static class Group
    {
        /// <summary>
        /// Creates a named group.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Returns a <see cref="PatternFormat"/>.</returns>
        public static PatternFormat ByName(string name)
        {
            return new PatternFormat("(?<" + name + ">{0})");
        }
    }
}