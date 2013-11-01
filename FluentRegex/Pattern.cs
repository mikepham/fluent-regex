namespace FluentRegex
{
    using System.Collections.Generic;

    /// <summary>
    /// Static helper class to begin new pattern expressions.
    /// </summary>
    public static partial class Pattern
    {
        /// <summary>
        /// Matches any of the provided values.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="formatters">The formatters.</param>
        /// <returns>Returns a <see cref="PatternExpression" />.</returns>
        public static PatternExpression Any(IEnumerable<string> values, params PatternFormatter[] formatters)
        {
            return new PatternExpression(string.Join("|", values), formatters);
        }

        /// <summary>
        /// Matches any of the provided values.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="values">The values.</param>
        /// <param name="formatters">The formatters.</param>
        /// <returns>Returns a <see cref="PatternExpression" />.</returns>
        public static PatternExpression Any(
            this PatternExpression expression,
            IEnumerable<string> values,
            params PatternFormatter[] formatters)
        {
            return new PatternExpression(expression.Build() + string.Join("|", values), formatters);
        }

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
        /// Matches the specified expression.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="formatters">The formatters.</param>
        /// <returns>Returns a <see cref="PatternExpression"/>.</returns>
        public static PatternExpression Match(this PatternExpression pattern, string expression, params PatternFormatter[] formatters)
        {
            return new PatternExpression(pattern.Build() + expression, formatters);
        }

        /// <summary>
        /// Matches previous expression or new expression.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="formatters">The formatters.</param>
        /// <returns>Returns a <see cref="PatternExpression" />.</returns>
        public static PatternExpression Or(this PatternExpression pattern, string expression, params PatternFormatter[] formatters)
        {
            return new PatternExpression(pattern.Build() + "|" + expression, formatters);
        }
    }
}