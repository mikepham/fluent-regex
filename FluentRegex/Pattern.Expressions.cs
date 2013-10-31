namespace FluentRegex
{
    /// <summary>
    /// Contains common expressions.
    /// </summary>
    public static partial class Pattern
    {
        /// <summary>
        /// Matches a phone number.
        /// </summary>
        /// <param name="kind">The kind.</param>
        /// <returns>Returns a <see cref="PatternExpression"/>.</returns>
        public static PatternExpression PhoneNumber(PhoneNumberKind kind)
        {
            return PatternExpression.Empty.PhoneNumber(kind);
        }

        /// <summary>
        /// Matches a phone number.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="kind">The kind.</param>
        /// <returns>Returns a <see cref="PatternExpression"/>.</returns>
        public static PatternExpression PhoneNumber(this PatternExpression pattern, PhoneNumberKind kind)
        {
            switch (kind)
            {
                default:
                    return new PatternExpression(pattern.Build() + @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$");
            }
        }
    }
}