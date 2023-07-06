using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories;

/// This class discovers all of the tests and test classes that have
/// applied the <see cref="IntegrationTestsAttribute"/>
/// </summary>
public class IntegrationTestsDiscoverer : ITraitDiscoverer
{
    /// <summary>
    /// The fully qualified name of this class
    /// </summary>
    internal const string FullyQualifiedName = NamespaceUtil.Namespace + "." + nameof(Categories) + "." + nameof(IntegrationTestsDiscoverer);

    /// <summary>
    /// Gets the trait values from the <see cref="IntegrationTestsAttribute"/>.
    /// </summary>
    /// <param name="traitAttribute">The trait attribute containing the trait values.</param>
    /// <returns>The trait values.</returns>
    public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
    {
        yield return new KeyValuePair<string, string>("Category", "Integration");
    }
}
