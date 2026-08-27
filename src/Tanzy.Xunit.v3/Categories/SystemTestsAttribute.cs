using System;
using System.Collections.Generic;
using Xunit.v3;

namespace Tanzy.Xunit.v3.Categories;

/// <summary>
/// Apply this attribute to a class that contains system tests.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class SystemTestsAttribute : Attribute, ITraitAttribute
{
    /// <inheritdoc />
    public IReadOnlyCollection<KeyValuePair<string, string>> GetTraits()
    {
        return new[] { new KeyValuePair<string, string>("Category", "System") };
    }
}
