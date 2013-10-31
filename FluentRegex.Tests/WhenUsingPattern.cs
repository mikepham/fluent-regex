namespace FluentRegex.Tests
{
    using Xunit;

    public class WhenUsingPattern
    {
        [Fact]
        public void ShouldBuildNamedGroupExpressionWithAtLeastOneMatch()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]*", As.Name("name"), Has.AtLeastOne());

            // Assert
            Assert.Equal(@"(?<name>[\w]*)+", pattern);
        }

        [Fact]
        public void ShouldBuildOptionalExpression()
        {
            // Arrange, Act
            string pattern = Pattern.Match(@"[\w]", Has.Optional());

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
    }
}