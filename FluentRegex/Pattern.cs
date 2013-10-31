namespace FluentRegex
{
    /// <summary>
    /// Static helper class to begin new patterns.
    /// </summary>
    public static class Pattern
    {
        /// <summary>
        /// Matches the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="expressions">The expressions.</param>
        /// <returns>Returns a <see cref="PatternExpression"/>.</returns>
        public static PatternExpression Match(string expression, params PatternFormat[] expressions)
        {
            return new PatternExpression(expression, expressions);
        }
    }
}