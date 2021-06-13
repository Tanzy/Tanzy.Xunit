using Tanzy.Xunit.Categories;
using Xunit;

namespace Tanzy.Xunit.Tests.DummyTests
{
    public class TraitDummyTest
    {
        [Fact]
        [Category("Sample")]
        public void CategorySampleTest()
        {
        }

        [Fact]
        [Bug]
        public void BugNoNameTest()
        {
        }

        [Fact]
        [Bug(88)]
        public void BugNumberTest()
        {
        }

        [Fact]
        [Bug("Something")]
        public void BugNameTest()
        {
        }

        [Fact]
        [UserStory()]
        public void UserStoryNoNameTest()
        {
        }

        [Fact]
        [UserStory(33)]
        public void UserStoryNumberTest()
        {
        }

        [Fact]
        [UserStory("A Story")]
        public void UserStoryNameTest()
        {
        }
    }
}