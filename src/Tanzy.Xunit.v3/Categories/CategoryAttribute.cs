using System;
using System.Collections.Generic;
using Xunit.v3;

namespace Tanzy.Xunit.v3.Categories;

/// <summary>
/// Applies a category trait to a test.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class CategoryAttribute : Attribute, ITraitAttribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryAttribute"/> class.
    /// </summary>
    /// <param name="category">The category of the test (for example, Unit or Integration).</param>
    public CategoryAttribute(string category)
    {
        Category = category;
    }

    /// <summary>
    /// Gets the value of the Category trait.
    /// </summary>
    public string Category { get; private set; }

    /// <inheritdoc />
    public IReadOnlyCollection<KeyValuePair<string, string>> GetTraits()
    {
        if (string.IsNullOrWhiteSpace(Category))
        {
            return Array.Empty<KeyValuePair<string, string>>();
        }

        return new[] { new KeyValuePair<string, string>("Category", Category) };
    }
}
