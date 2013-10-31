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
        public static PatternExpression Phone(PhoneNumberKind kind = PhoneNumberKind.Default)
        {
            return PatternExpression.Empty.Phone(kind);
        }

        /// <summary>
        /// Matches a phone number.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="kind">The kind.</param>
        /// <returns>Returns a <see cref="PatternExpression"/>.</returns>
        public static PatternExpression Phone(this PatternExpression pattern, PhoneNumberKind kind = PhoneNumberKind.Default)
        {
            switch (kind)
            {
                default:
                    return new PatternExpression(pattern.Build() + @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$");
            }
        }
    }
}