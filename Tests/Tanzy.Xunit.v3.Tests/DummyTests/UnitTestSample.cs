using Tanzy.Xunit.v3.Categories;
using Xunit;

namespace Tanzy.Xunit.v3.Tests.DummyTests;

[UnitTests]
public class UnitTestSample
{
    [Fact]
    [UserStory()]
    public void UserStoryNoNameTest()
    {
        Assert.True(true);
    }
}
