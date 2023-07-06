using Tanzy.Xunit.Categories;
using Xunit;

namespace Tanzy.Xunit.Tests.DummyTests;

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
