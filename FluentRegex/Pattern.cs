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
        /// <param name="formatters">The formatters.</param>
        /// <returns>Returns a <see cref="PatternExpression" />.</returns>
        public static PatternExpression Match(string expression, params PatternFormatter[] formatters)
        {
            return new PatternExpression(expression, formatters);
        }

        /// <summary>
        /// Matches the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="formatters">The formatters.</param>
        /// <returns>Returns a <see cref="PatternExpression"/>.</returns>
        public static PatternExpression Match(this PatternExpression pattern, string expression, params PatternFormatter[] formatters)
        {
            return new PatternExpression(pattern.Build() + expression, formatters);
        }
    }
}