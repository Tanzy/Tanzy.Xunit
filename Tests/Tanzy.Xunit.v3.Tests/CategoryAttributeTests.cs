using System;
using System.Collections.Generic;
using System.Linq;
using Tanzy.Xunit.v3.Categories;
using Xunit;
using Xunit.v3;

namespace Tanzy.Xunit.v3.Tests;

[UnitTests]
public class CategoryAttributeTests
{
    [Fact]
    public void CategoryReturnsCategoryTrait()
    {
        AssertTraits(new CategoryAttribute("Sample"), "Category = Sample");
    }

    [Fact]
    public void EmptyCategoryReturnsNoTraits()
    {
        Assert.Empty(new CategoryAttribute(" ").GetTraits());
    }

    [Fact]
    public void BugWithoutIdReturnsCategoryTrait()
    {
        AssertTraits(new BugAttribute(), "Category = Bug");
    }

    [Fact]
    public void BugWithNumberReturnsBugAndCategoryTraits()
    {
        AssertTraits(new BugAttribute(88), "Bug = 88", "Category = Bug");
    }

    [Fact]
    public void BugWithNameReturnsBugAndCategoryTraits()
    {
        AssertTraits(new BugAttribute("Something"), "Bug = Something", "Category = Bug");
    }

    [Fact]
    public void UserStoryWithoutIdReturnsCategoryTrait()
    {
        AssertTraits(new UserStoryAttribute(), "Category = UserStory");
    }

    [Fact]
    public void UserStoryWithNumberReturnsUserStoryAndCategoryTraits()
    {
        AssertTraits(new UserStoryAttribute(33), "Category = UserStory", "UserStory = 33");
    }

    [Fact]
    public void UserStoryWithNameReturnsUserStoryAndCategoryTraits()
    {
        AssertTraits(new UserStoryAttribute("A Story"), "Category = UserStory", "UserStory = A Story");
    }

    [Fact]
    public void TaskWithoutIdReturnsCategoryTrait()
    {
        AssertTraits(new TaskAttribute(), "Category = Task");
    }

    [Fact]
    public void TaskWithNumberReturnsTaskAndCategoryTraits()
    {
        AssertTraits(new TaskAttribute(33), "Category = Task", "Task = 33");
    }

    [Fact]
    public void TaskWithNameReturnsTaskAndCategoryTraits()
    {
        AssertTraits(new TaskAttribute("A Task"), "Category = Task", "Task = A Task");
    }

    [Fact]
    public void ClassLevelAttributesReturnExpectedCategories()
    {
        AssertTraits(new UnitTestsAttribute(), "Category = Unit");
        AssertTraits(new IntegrationTestsAttribute(), "Category = Integration");
        AssertTraits(new SystemTestsAttribute(), "Category = System");
    }

    private static void AssertTraits(ITraitAttribute attribute, params string[] expected)
    {
        var actual = attribute
            .GetTraits()
            .Select(FormatTrait)
            .OrderBy(value => value, StringComparer.OrdinalIgnoreCase);

        Assert.Equal(expected, actual);
    }

    private static string FormatTrait(KeyValuePair<string, string> trait)
    {
        return $"{trait.Key} = {trait.Value}";
    }
}
