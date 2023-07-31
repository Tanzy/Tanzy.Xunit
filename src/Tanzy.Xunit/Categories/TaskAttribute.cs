using System;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories
{
    /// <summary>
    /// Apply this attribute to your test method to specify a task.
    /// </summary>
    [TraitDiscoverer(TaskDiscoverer.FullyQualifiedName, NamespaceUtil.Namespace)]
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
    }
}
