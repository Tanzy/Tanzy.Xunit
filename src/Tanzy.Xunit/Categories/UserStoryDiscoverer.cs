using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories
{
    // <summary>
    /// This class discovers all of the tests and test classes that have
    /// applied the Bug attribute
    /// </summary>
    public class UserStoryDiscoverer : ITraitDiscoverer
    {
        /// <summary>
        /// The fully qualified name of this class
        /// </summary>
        internal const string FullyQualifiedName = NamespaceUtil.Namespace + "." + nameof(Categories) + "." + nameof(UserStoryDiscoverer);

        /// <summary>
        /// Gets the trait values from the UserStory attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the trait values.</param>
        /// <returns>The trait values.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            var storyId = traitAttribute.GetNamedArgument<string>("UserStoryId");

            yield return new KeyValuePair<string, string>("Category", "UserStory");
            
            if (!string.IsNullOrWhiteSpace(storyId))
            {
                yield return new KeyValuePair<string, string>("UserStory", storyId);
            }
        }
    }
}