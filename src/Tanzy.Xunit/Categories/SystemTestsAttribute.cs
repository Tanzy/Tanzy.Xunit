using System;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories;

/// <summary>
/// Apply this attribute to your test method to specify a System test, can only be applied to a class.
/// </summary>
[TraitDiscoverer(SystemTestsDiscoverer.FullyQualifiedName, NamespaceUtil.Namespace)]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class SystemTestsAttribute : Attribute, ITraitAttribute
{
    public SystemTestsAttribute() { }

}
