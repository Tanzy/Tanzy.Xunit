using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories;

// <summary>
/// This class discovers all of the tests and test classes that have
/// applied the <see cref="SystemTestAttribute"/>
/// </summary>
public class SystemTestsDiscoverer : ITraitDiscoverer
{
    /// <summary>
    /// The fully qualified name of this class
    /// </summary>
    internal const string FullyQualifiedName = NamespaceUtil.Namespace + "." + nameof(Categories) + "." + nameof(SystemTestsDiscoverer);

    /// <summary>
    /// Gets the trait values from the <see cref="SystemTestsAttribute"/>.
    /// </summary>
    /// <param name="traitAttribute">The trait attribute containing the trait values.</param>
    /// <returns>The trait values.</returns>
    public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
    {
        yield return new KeyValuePair<string, string>("Category", "System");
    }
}
