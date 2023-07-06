using Tanzy.Xunit.Categories;
using Xunit;

namespace Tanzy.Xunit.Tests.DummyTests;

[SystemTests]
public class SystemTestSample
{
    [Fact]
    [UserStory()]
    public void UserStoryNoNameTest()
    {
        Assert.True(true);
    }
}
