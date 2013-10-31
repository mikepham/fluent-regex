namespace FluentRegex
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a pattern expression part.
    /// </summary>
    public class PatternExpression
    {
        /// <summary>
        /// Maintains the user-defined expression.
        /// </summary>
        private readonly string expression;

        /// <summary>
        /// Maintains a collection of expression formatting options.
        /// </summary>
        private readonly IEnumerable<PatternFormat> expressions;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatternExpression"/> class.
        /// </summary>
        /// <param name="format">The expression.</param>
        public PatternExpression(string format)
            : this(format, Enumerable.Empty<PatternFormat>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatternExpression"/> class.
        /// </summary>
        /// <param name="format">The expression.</param>
        /// <param name="expressions">The expressions.</param>
        public PatternExpression(string format, IEnumerable<PatternFormat> expressions)
        {
            this.expression = format;
            this.expressions = expressions;
        }

        /// <summary>
        /// Gets the expression.
        /// </summary>
        protected string Expression
        {
            get
            {
                return this.expression;
            }
        }

        /// <summary>
        /// Builds an expression string.
        /// </summary>
        /// <returns>Returns the string representing the expression.</returns>
        public string Build()
        {
            return this.expressions.Aggregate(this.Expression, (current, ex) => ex.Build(current));
        }
    }
}