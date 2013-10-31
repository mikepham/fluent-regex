namespace FluentRegex.Formatters
{
    /// <summary>
    /// Static helper for grouping matches.
    /// </summary>
    public static class As
    {
        /// <summary>
        /// Creates a group.
        /// </summary>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter Group()
        {
            return new PatternFormatter("({0})");
        }

        /// <summary>
        /// Creates a named group.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter Name(string name)
        {
            return new PatternFormatter("(?<" + name + ">{0})");
        }

        /// <summary>
        /// Creates a non-matching group.
        /// </summary>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter NonMatching()
        {
            return new PatternFormatter("(?:{0})");
        }

        /// <summary>
        /// Creates a string boundary.
        /// </summary>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter String()
        {
            return new PatternFormatter("^{0}$");
        }

        /// <summary>
        /// Creates word boundary.
        /// </summary>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter WordBoundary()
        {
            return new PatternFormatter("\\b{0}\\b");
        }
    }
}