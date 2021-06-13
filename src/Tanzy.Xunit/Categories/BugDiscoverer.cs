using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories
{
    // <summary>
    /// This class discovers all of the tests and test classes that have
    /// applied the Bug attribute
    /// </summary>
    public class BugDiscoverer : ITraitDiscoverer
    {
        /// <summary>
        /// The fully qualified name of this class
        /// </summary>
        internal const string FullyQualifiedName = NamespaceUtil.Namespace + "." + nameof(Categories) + "." + nameof(BugDiscoverer);

        /// <summary>
        /// Gets the trait values from the Bug attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the trait values.</param>
        /// <returns>The trait values.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            var bugId = traitAttribute.GetNamedArgument<string>("BugId");

            yield return new KeyValuePair<string, string>("Category", "Bug");
            
            if (!string.IsNullOrWhiteSpace(bugId))
            {
                yield return new KeyValuePair<string, string>("Bug", bugId);
            }
        }
    }
}