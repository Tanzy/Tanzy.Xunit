using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories
{
    /// <summary>
    /// This class discovers all of the tests and test classes that have
    /// applied the Category attribute
    /// </summary>
    public class CategoryDiscoverer : ITraitDiscoverer
    {
        /// <summary>
        /// The fully qualified name of this class
        /// </summary>
        internal const string FullyQualifiedName = NamespaceUtil.Namespace + "." + nameof(Categories) + "." + nameof(CategoryDiscoverer);
        
        /// <summary>
        /// Gets the trait values from the Category attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the trait values.</param>
        /// <returns>The trait values.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            var categoryValue = traitAttribute.GetNamedArgument<string>("Category");

            if (!string.IsNullOrWhiteSpace(categoryValue))
            {
                yield return new KeyValuePair<string, string>("Category", categoryValue);
            }
        }
    }
}