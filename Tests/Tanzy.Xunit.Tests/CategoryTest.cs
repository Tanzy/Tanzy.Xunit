using System;
using System.Linq;
using Tanzy.Xunit.Tests.DummyTests;
using Xunit;
using Xunit.Sdk;

namespace Tanzy.Xunit.Tests
{
    [Trait("Category","Category Tests")]
    public class CategoryTest
    {
        [Fact]
        public void GivenCategoryTrait_WhenAttributeAdded_ThenCorrectTraitReturned()
        {
            var method = typeof(TraitDummyTest).GetMethod("CategorySampleTest");

            var traits = TraitHelper.GetTraits(method!);

            Assert.Collection(
                traits.Select(kvp => $"{kvp.Key} = {kvp.Value}").OrderBy(_ => _, StringComparer.OrdinalIgnoreCase),
                value => Assert.Equal("Category = Sample", value)
            );
        }
        
        [Fact]
        public void GivenBugTrait_WhenBugHasNoName_ThenCorrectTraitReturned()
        {
            var method = typeof(TraitDummyTest).GetMethod("BugNoNameTest");

            var traits = TraitHelper.GetTraits(method!);

            Assert.Collection(
                traits.Select(kvp => $"{kvp.Key} = {kvp.Value}").OrderBy(_ => _, StringComparer.OrdinalIgnoreCase),
                value => Assert.Equal("Category = Bug", value)
            );
        }
        
        [Fact]
        public void GivenBugTrait_WhenBugHasHasNumber_ThenCorrectTraitReturned()
        {
            var method = typeof(TraitDummyTest).GetMethod("BugNumberTest");

            var traits = TraitHelper.GetTraits(method!);

            Assert.Collection(
                traits.Select(kvp => $"{kvp.Key} = {kvp.Value}").OrderBy(_ => _, StringComparer.OrdinalIgnoreCase),
                value => Assert.Equal("Bug = 88", value),
                value => Assert.Equal("Category = Bug", value)
            );
        }
        
        [Fact]
        public void GivenBugTrait_WhenBugHasHasName_ThenCorrectTraitReturned()
        {
            var method = typeof(TraitDummyTest).GetMethod("BugNameTest");

            var traits = TraitHelper.GetTraits(method!);

            Assert.Collection(
                traits.Select(kvp => $"{kvp.Key} = {kvp.Value}").OrderBy(_ => _, StringComparer.OrdinalIgnoreCase),
                value => Assert.Equal("Bug = Something", value),
                value => Assert.Equal("Category = Bug", value)
            );
        }
        
        [Fact]
        public void GivenUserStoryTrait_WhenUserStoryHasNumber_ThenCorrectTraitReturned()
        {
            var method = typeof(TraitDummyTest).GetMethod("UserStoryNumberTest");

            var traits = TraitHelper.GetTraits(method!);

            Assert.Collection(
                traits.Select(kvp => $"{kvp.Key} = {kvp.Value}").OrderBy(_ => _, StringComparer.OrdinalIgnoreCase),
                value => Assert.Equal("Category = UserStory", value),
                value => Assert.Equal("UserStory = 33", value)
            );
        }
        
        [Fact]
        public void GivenUserStoryTrait_WhenUserStoryHasName_ThenCorrectTraitReturned()
        {
            var method = typeof(TraitDummyTest).GetMethod("UserStoryNameTest");

            var traits = TraitHelper.GetTraits(method!);

            Assert.Collection(
                traits.Select(kvp => $"{kvp.Key} = {kvp.Value}").OrderBy(_ => _, StringComparer.OrdinalIgnoreCase),
                value => Assert.Equal("Category = UserStory", value),
                value => Assert.Equal("UserStory = A Story", value)
            );
        }
        
        [Fact]
        public void GivenUserStoryTrait_WhenUserStoryHasNoName_ThenCorrectTraitReturned()
        {
            var method = typeof(TraitDummyTest).GetMethod("UserStoryNoNameTest");

            var traits = TraitHelper.GetTraits(method!);

            Assert.Collection(
                traits.Select(kvp => $"{kvp.Key} = {kvp.Value}").OrderBy(_ => _, StringComparer.OrdinalIgnoreCase),
                value => Assert.Equal("Category = UserStory", value)
            );
        }

        [Fact]
        public void GivenUnitTestTrait_WhenUserStoryHasNoName_ThenCorrectTraitReturned()
        {
            var @class = typeof(UnitTestSample);

            var traits = TraitHelper.GetTraits(@class!);

            Assert.Collection(
                traits.Select(kvp => $"{kvp.Key} = {kvp.Value}").OrderBy(_ => _, StringComparer.OrdinalIgnoreCase),
                value => Assert.Equal("Category = Unit", value)
            );
        }

        [Fact]
        public void GivenIntegrationTestTrait_WhenUserStoryHasNoName_ThenCorrectTraitReturned()
        {
            var @class = typeof(IntegrationTestSample);

            var traits = TraitHelper.GetTraits(@class!);

            Assert.Collection(
                traits.Select(kvp => $"{kvp.Key} = {kvp.Value}").OrderBy(_ => _, StringComparer.OrdinalIgnoreCase),
                value => Assert.Equal("Category = Integration", value)
            );
        }

        [Fact]
        public void GivenSystemTestTrait_WhenUserStoryHasNoName_ThenCorrectTraitReturned()
        {
            var @class = typeof(SystemTestSample);

            var traits = TraitHelper.GetTraits(@class!);

            Assert.Collection(
                traits.Select(kvp => $"{kvp.Key} = {kvp.Value}").OrderBy(_ => _, StringComparer.OrdinalIgnoreCase),
                value => Assert.Equal("Category = System", value)
            );
        }
    }
}
