using System;
using System.Collections.Generic;
using Xunit.v3;

namespace Tanzy.Xunit.v3.Categories;

/// <summary>
/// Apply this attribute to a test method to specify a task.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TaskAttribute : Attribute, ITraitAttribute
{
    public TaskAttribute(string taskId)
    {
        TaskId = taskId;
    }

    public TaskAttribute(long taskId)
    {
        TaskId = taskId.ToString();
    }

    public TaskAttribute()
    {
    }

    public string TaskId { get; private set; }

    /// <inheritdoc />
    public IReadOnlyCollection<KeyValuePair<string, string>> GetTraits()
    {
        var traits = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("Category", "Task")
        };

        if (!string.IsNullOrWhiteSpace(TaskId))
        {
            traits.Add(new KeyValuePair<string, string>("Task", TaskId));
        }

        return traits;
    }
}
