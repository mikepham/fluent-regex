namespace FluentRegex
{
    /// <summary>
    /// Static helper for grouping matches.
    /// </summary>
    public static class As
    {
        /// <summary>
        /// Creates a named group.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter Group(string name)
        {
            return new PatternFormatter("(?<" + name + ">{0})");
        }
    }
}