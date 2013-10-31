namespace FluentRegex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Represents a pattern expression part.
    /// </summary>
    public class PatternExpression : IEquatable<PatternExpression>
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
        /// Operator overload for equality.
        /// </summary>
        /// <param name="left">Left <see cref="PatternExpression"/>.</param>
        /// <param name="right">Right <see cref="PatternExpression"/>.</param>
        /// <returns>Returns true if the value properties are equal.</returns>
        public static bool operator ==(PatternExpression left, PatternExpression right)
        {
            string leftValue = object.ReferenceEquals(null, left) ? null : left.Build();
            string rightValue = object.ReferenceEquals(null, right) ? null : right.Build();

            return string.Equals(leftValue, rightValue);
        }

        /// <summary>
        /// Operator overload for inequality.
        /// </summary>
        /// <param name="left">Left <see cref="PatternExpression"/>.</param>
        /// <param name="right">Right <see cref="PatternExpression"/>.</param>
        /// <returns>Returns true if the value properties are not equal.</returns>
        public static bool operator !=(PatternExpression left, PatternExpression right)
        {
            string leftValue = object.ReferenceEquals(null, left) ? null : left.Build();
            string rightValue = object.ReferenceEquals(null, right) ? null : right.Build();

            return !string.Equals(leftValue, rightValue);
        }

        /// <summary>
        /// Implicit type conversion to string.
        /// </summary>
        /// <param name="instance">Instance of an existing <see cref="PatternExpression"/>.</param>
        /// <returns>Key property or null.</returns>
        public static implicit operator string(PatternExpression instance)
        {
            return object.Equals(instance, null) ? null : instance.Build();
        }

        /// <summary>
        /// Implicit type conversion from string.
        /// </summary>
        /// <param name="value">Key of the login string.</param>
        /// <returns><see cref="PatternExpression"/> with the Key property set to the parameter.</returns>
        public static implicit operator PatternExpression(string value)
        {
            return new PatternExpression(value);
        }

        /// <summary>
        /// Builds an expression string.
        /// </summary>
        /// <returns>Returns the string representing the expression.</returns>
        public string Build()
        {
            return this.formatters.Aggregate(this.Expression, (current, formatter) => formatter.Format(current));
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

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        /// <param name="obj">The object to compare with the current object. </param>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == this.GetType() && this.Equals(((PatternExpression)obj).Build());
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(PatternExpression other)
        {
            return this.Build() == other.Build();
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        public override int GetHashCode()
        {
            return string.IsNullOrWhiteSpace(this.Expression) ? 0 : this.Expression.GetHashCode();
        }
    }
}