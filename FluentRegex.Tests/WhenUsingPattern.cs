namespace FluentRegex.Tests
{
    using FluentRegex.Formatters;

    using Xunit;

    public class WhenUsingPattern
    {
        [Fact]
        public void ShouldBuildNamedGroupExpressionWithAtLeastOneMatch()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]*", As.Name("name"), Has.OneOrMore());

            // Assert
            Assert.Equal(@"(?<name>[\w]*)+", pattern);
        }

        [Fact]
        public void ShouldBuildWithOrderedPatternFormatters()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]", Has.OneOrMore(), As.Name("name"));

            // Assert
            Assert.Equal(@"(?<name>[\w]+)", pattern);
        }

        [Fact]
        public void ShouldBuildOptionalExpression()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]", Is.Optional());

            // Assert
            Assert.Equal(@"[\w]?", pattern);
        }

        [Fact]
        public void ShouldComposeTwoExpressions()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]*").Match(@"[\s]+");

            // Assert
            Assert.Equal(@"[\w]*[\s]+", pattern);
        }

        [Fact]
        public void ShouldBuildMatchOrExpression()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]").Or(@"[\s]");

            // Assert
            Assert.Equal(@"[\w]|[\s]", pattern);
        }
    }
}