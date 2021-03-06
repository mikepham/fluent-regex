﻿namespace FluentRegex
{
    /// <summary>
    /// Represents a pattern formatter.
    /// </summary>
    public class PatternFormatter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatternFormatter"/> class.
        /// </summary>
        /// <param name="expressionFormat">The format.</param>
        public PatternFormatter(string expressionFormat)
        {
            this.ExpressionFormat = expressionFormat;
        }

        /// <summary>
        /// Gets the format.
        /// </summary>
        public string ExpressionFormat { get; private set; }

        /// <summary>
        /// Builds the expression based on the format.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Returns a string representing the formatted expression.</returns>
        public string Format(string value)
        {
            return string.Format(this.ExpressionFormat, value);
        }
    }
}