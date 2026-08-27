using Tanzy.Xunit.v3.Categories;
using Xunit;

namespace Tanzy.Xunit.v3.Tests.DummyTests;

[IntegrationTests]
public class IntegrationTestSample
{
    [Fact]
    [UserStory()]
    public void UserStoryNoNameTest()
    {
        Assert.True(true);
    }
}