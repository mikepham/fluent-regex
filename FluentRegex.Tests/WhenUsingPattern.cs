namespace FluentRegex.Tests
{
    using Xunit;

    public class WhenUsingPattern
    {
        [Fact]
        public void ShouldBuildNamedGroupExpressionWithAtLeastOneMatch()
        {
            // Arrange, Act
            var pattern = Pattern.Match(@"[\w]*", Group.ByName("name"), Exists.AtLeastOnce()).Build();

            // Assert
            Assert.Equal(@"(?<name>[\w]*)+", pattern);
        }

        [Fact]
        public void ShouldBuildOptionalExpression()
        {
            // Arrange, Act
            var pattern = Pattern.Match(@"[\w]", Exists.Optional()).Build();

            // Assert
            Assert.Equal(@"[\w]?", pattern);
        }

        [Fact]
        public void ShouldComposeTwoExpressions()
        {
            // Arrange, Act
            var pattern = Pattern.Match(@"[\w]*").Match(@"[\s]+").Build();

            // Assert
            Assert.Equal(@"[\w]*[\s]+", pattern);
        }
    }
}