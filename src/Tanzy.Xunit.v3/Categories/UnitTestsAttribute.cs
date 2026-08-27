using System;
using System.Collections.Generic;
using Xunit.v3;

namespace Tanzy.Xunit.v3.Categories;

/// <summary>
/// Apply this attribute to a class that contains unit tests.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class UnitTestsAttribute : Attribute, ITraitAttribute
{
    /// <inheritdoc />
    public IReadOnlyCollection<KeyValuePair<string, string>> GetTraits()
    {
        return new[] { new KeyValuePair<string, string>("Category", "Unit") };
    }
}
