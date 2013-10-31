namespace FluentRegex
{
    public class PatternFormat : PatternExpression
    {
        public PatternFormat(string expression)
            : base(expression)
        {
        }

        public string Build(string value)
        {
            return string.Format(this.Expression, value);
        }
    }
}