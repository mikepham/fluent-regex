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
        /// <returns>Returns a <see cref="PatternFormat"/>.</returns>
        public static PatternFormat AtLeastOnce()
        {
            return new PatternFormat("{0}+");
        }
    }
}