using Tanzy.Xunit.v3.Categories;
using Xunit;

namespace Tanzy.Xunit.v3.Tests.DummyTests;

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
