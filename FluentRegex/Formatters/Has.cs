namespace FluentRegex.Formatters
{
    /// <summary>
    /// Static helper class for defining existence matches.
    /// </summary>
    public static class Has
    {
        /// <summary>
        /// Ensures the expression matches exactly the specified count.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter Count(int count)
        {
            return new PatternFormatter("{0}{{" + count + "}}");
        }

        /// <summary>
        /// Ensures that the match exists just once.
        /// </summary>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter One()
        {
            return Count(1);
        }

        /// <summary>
        /// Ensures that the match exists at least once.
        /// </summary>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter OneOrMore()
        {
            return new PatternFormatter("{0}+");
        }
    }
}