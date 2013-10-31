namespace FluentRegex.Tests
{
    using FluentRegex.Formatters;

    using Xunit;

    public class WhenUsingAsFormatters
    {
        [Fact]
        public void ShouldCreateGroupForExpression()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]", As.Group());

            // Assert
            Assert.Equal(@"([\w])", pattern);
        }

        [Fact]
        public void ShouldCreateNamedGroupForExpression()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]", As.Name("letter"));

            // Assert
            Assert.Equal(@"(?<letter>[\w])", pattern);
        }

        [Fact]
        public void ShouldCreateNamedNonMatchingGroupWithStringBoundaryForExpression()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]", As.Name("letter"), As.WordBoundary(), As.NonMatching(), As.String());

            // Assert
            Assert.Equal(@"^(?:\b(?<letter>[\w])\b)$", pattern);
        }

        [Fact]
        public void ShouldCreateNonMatchingGroupForExpression()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]", As.NonMatching());

            // Assert
            Assert.Equal(@"(?:[\w])", pattern);
        }

        [Fact]
        public void ShouldCreateStringMatchingForExpression()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]", As.String());

            // Assert
            Assert.Equal(@"^[\w]$", pattern);
        }

        [Fact]
        public void ShouldCreateWordBoundaryForExpression()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]", As.WordBoundary());

            // Assert
            Assert.Equal(@"\b[\w]\b", pattern);
        }
    }
}