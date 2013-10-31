namespace FluentRegex.Formatters
{
    /// <summary>
    /// Helper class for defining pattern formats that match the "is" keyword.
    /// </summary>
    public static class Is
    {
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