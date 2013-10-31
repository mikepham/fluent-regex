namespace FluentRegex.Tests
{
    using Xunit;

    public class WhenUsingPattern
    {
        [Fact]
        public void ShouldBuildRegularExpressionPattern()
        {
            var pattern = Pattern.Match(@"[\w]*", Group.ByName("name"), Exists.AtLeastOnce()).Build();
            Assert.Equal(@"(?<name>[\w]*)?", pattern);
        }
    }
}