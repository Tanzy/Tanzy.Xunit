using System;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories;

/// <summary>
/// Apply this attribute to your test method to specify an Integration test, can only be applied to a class
/// </summary>
[TraitDiscoverer(IntegrationTestsDiscoverer.FullyQualifiedName, NamespaceUtil.Namespace)]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class IntegrationTestsAttribute : Attribute, ITraitAttribute
{
    public IntegrationTestsAttribute() { }

}
