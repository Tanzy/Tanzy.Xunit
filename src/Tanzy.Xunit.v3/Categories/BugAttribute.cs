using System;
using System.Collections.Generic;
using Xunit.v3;

namespace Tanzy.Xunit.v3.Categories;

/// <summary>
/// Apply this attribute to a test method to specify a bug.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class BugAttribute : Attribute, ITraitAttribute
{
    public BugAttribute(string bug)
    {
        BugId = bug;
    }

    public BugAttribute(int bug)
    {
        BugId = bug.ToString();
    }

    public BugAttribute()
    {
    }

    public string BugId { get; private set; }

    /// <inheritdoc />
    public IReadOnlyCollection<KeyValuePair<string, string>> GetTraits()
    {
        var traits = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("Category", "Bug")
        };

        if (!string.IsNullOrWhiteSpace(BugId))
        {
            traits.Add(new KeyValuePair<string, string>("Bug", BugId));
        }

        return traits;
    }
}
