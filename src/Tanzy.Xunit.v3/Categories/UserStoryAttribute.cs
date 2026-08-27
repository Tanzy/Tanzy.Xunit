using System;
using System.Collections.Generic;
using Xunit.v3;

namespace Tanzy.Xunit.v3.Categories;

/// <summary>
/// Apply this attribute to a test method to specify a user story.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class UserStoryAttribute : Attribute, ITraitAttribute
{
    public UserStoryAttribute(string userStoryId)
    {
        UserStoryId = userStoryId;
    }

    public UserStoryAttribute(long userStoryId)
    {
        UserStoryId = userStoryId.ToString();
    }

    public UserStoryAttribute()
    {
    }

    public string UserStoryId { get; private set; }

    /// <inheritdoc />
    public IReadOnlyCollection<KeyValuePair<string, string>> GetTraits()
    {
        var traits = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("Category", "UserStory")
        };

        if (!string.IsNullOrWhiteSpace(UserStoryId))
        {
            traits.Add(new KeyValuePair<string, string>("UserStory", UserStoryId));
        }

        return traits;
    }
}
