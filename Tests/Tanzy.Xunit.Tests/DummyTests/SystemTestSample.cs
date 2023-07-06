using Tanzy.Xunit.Categories;
using Xunit;

namespace Tanzy.Xunit.Tests.DummyTests;

[SystemTest]
public class SystemTestSample
{
    [Fact]
    [UserStory()]
    public void UserStoryNoNameTest()
    {
        Assert.True(true);
    }
}