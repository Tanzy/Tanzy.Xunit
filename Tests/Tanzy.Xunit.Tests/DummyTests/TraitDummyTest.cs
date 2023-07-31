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
            Assert.True(true);
        }

        [Fact]
        [Bug]
        public void BugNoNameTest()
        {
            Assert.True(true);
        }

        [Fact]
        [Bug(88)]
        public void BugNumberTest()
        {
            Assert.True(true);
        }

        [Fact]
        [Bug("Something")]
        public void BugNameTest()
        {
            Assert.True(true);
        }

        [Fact]
        [UserStory()]
        public void UserStoryNoNameTest()
        {
            Assert.True(true);
        }

        [Fact]
        [UserStory(33)]
        public void UserStoryNumberTest()
        {
            Assert.True(true);
        }

        [Fact]
        [UserStory("A Story")]
        public void UserStoryNameTest()
        {
            Assert.True(true);
        }

        [Fact]
        [Task()]
        public void TaskNoNameTest()
        {
            Assert.True(true);
        }

        [Fact]
        [Task(33)]
        public void TaskNumberTest()
        {
            Assert.True(true);
        }

        [Fact]
        [Task("A Story")]
        public void TaskNameTest()
        {
            Assert.True(true);
        }

    }
}
