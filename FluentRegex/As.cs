namespace FluentRegex
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
        public static PatternExpression NonMatching()
        {
            return new PatternExpression("(?:{0})");
        }

        /// <summary>
        /// Creates a string boundary.
        /// </summary>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternExpression String()
        {
            return new PatternExpression("^{0}$");
        }

        /// <summary>
        /// Creates word boundary.
        /// </summary>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternExpression WordBoundary()
        {
            return new PatternExpression("\\b{0]\\b");
        }
    }
}