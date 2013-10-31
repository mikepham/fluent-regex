namespace FluentRegex
{
    /// <summary>
    /// Static helper class for defining existence matches.
    /// </summary>
    public static class Exists
    {
        /// <summary>
        /// Ensures that the match exists at least once.
        /// </summary>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter AtLeastOnce()
        {
            return new PatternFormatter("{0}+");
        }

        /// <summary>
        /// Ensures that the match exists just once.
        /// </summary>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter Once()
        {
            return new PatternFormatter("{0}{{1,1}}");
        }

        /// <summary>
        /// Optionally matches the expression.
        /// </summary>
        /// <returns>Returns a <see cref="PatternFormatter"/>.</returns>
        public static PatternFormatter Optional()
        {
            return new PatternFormatter("{0}?");
        }
    }
}