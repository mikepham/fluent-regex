namespace FluentRegex
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Represents a pattern expression part.
    /// </summary>
    public class PatternExpression
    {
        /// <summary>
        /// Defines an empty pattern expression.
        /// </summary>
        private static readonly PatternExpression EmptyExpression = new PatternExpression(string.Empty);

        /// <summary>
        /// Maintains a collection of expression formatting options.
        /// </summary>
        private readonly IEnumerable<PatternFormatter> formatters;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatternExpression" /> class.
        /// </summary>
        /// <param name="expression">The expression.</param>
        public PatternExpression(string expression)
            : this(expression, Enumerable.Empty<PatternFormatter>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatternExpression" /> class.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="formatters">The formatters.</param>
        public PatternExpression(string expression, IEnumerable<PatternFormatter> formatters)
        {
            this.Expression = expression;
            this.formatters = formatters;
        }

        /// <summary>
        /// Gets the empty expression.
        /// </summary>
        public static PatternExpression Empty
        {
            get
            {
                return EmptyExpression;
            }
        }

        /// <summary>
        /// Gets the expression.
        /// </summary>
        public string Expression { get; private set; }

        /// <summary>
        /// Builds an expression string.
        /// </summary>
        /// <returns>Returns the string representing the expression.</returns>
        public string Build()
        {
            return this.formatters.Aggregate(this.Expression, (current, ex) => ex.Build(current));
        }

        /// <summary>
        /// Compiles the expression with the specified options.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns>Returns a <see cref="Regex"/>.</returns>
        public Regex Compile(RegexOptions options = RegexOptions.None)
        {
            return new Regex(this.Build(), options);
        }
    }
}