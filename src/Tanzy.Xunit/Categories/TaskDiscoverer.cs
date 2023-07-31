using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories
{
    // <summary>
    /// This class discovers all of the tests and test classes that have
    /// applied the Task attribute
    /// </summary>
    public class TaskDiscoverer : ITraitDiscoverer
    {
        /// <summary>
        /// The fully qualified name of this class
        /// </summary>
        internal const string FullyQualifiedName = NamespaceUtil.Namespace + "." + nameof(Categories) + "." + nameof(TaskDiscoverer);

        /// <summary>
        /// Gets the trait values from the Task attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the trait values.</param>
        /// <returns>The trait values.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            var taskId = traitAttribute.GetNamedArgument<string>("TaskId");

            yield return new KeyValuePair<string, string>("Category", "Task");
            
            if (!string.IsNullOrWhiteSpace(taskId))
            {
                yield return new KeyValuePair<string, string>("Task", taskId);
            }
        }
    }
}
