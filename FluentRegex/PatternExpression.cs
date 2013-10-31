namespace FluentRegex
{
    using System.Collections.Generic;
    using System.Linq;

    public class PatternExpression
    {
        private readonly string expression;

        private readonly IEnumerable<PatternFormat> expressions;

        public PatternExpression(string expression)
            : this(expression, Enumerable.Empty<PatternFormat>())
        {
        }

        public PatternExpression(string expression, IEnumerable<PatternFormat> expressions)
        {
            this.expression = expression;
            this.expressions = expressions;
        }

        protected string Expression
        {
            get
            {
                return this.expression;
            }
        }

        public string Build()
        {
            return this.expressions.Aggregate(this.Expression, (current, ex) => ex.Build(current));
        }
    }
}