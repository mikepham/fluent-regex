namespace FluentRegex
{
    public static class Pattern
    {
        public static PatternExpression Match(string expression, params PatternFormat[] expressions)
        {
            return new PatternExpression(expression, expressions);
        }
    }
}