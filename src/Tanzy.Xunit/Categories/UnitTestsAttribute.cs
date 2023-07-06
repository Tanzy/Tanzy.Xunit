using System;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories;

/// <summary>
/// Apply this attribute to your test method to specify a Unit test, can only be applied to a class.
/// </summary>
[TraitDiscoverer(UnitTestsDiscoverer.FullyQualifiedName, NamespaceUtil.Namespace)]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class UnitTestsAttribute : Attribute, ITraitAttribute
{
    public UnitTestsAttribute() { }

}
