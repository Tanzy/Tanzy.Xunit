using System;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories
{
    /// <summary>
    /// Apply this attribute to your test method to specify a bug.
    /// </summary>
    [TraitDiscoverer(BugDiscoverer.FullyQualifiedName, NamespaceUtil.Namespace)]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class BugAttribute : Attribute, ITraitAttribute
    {
        public BugAttribute(string bug)
        {
            BugId = bug;
        }
        
        public BugAttribute(int bug)
        {
            BugId = bug.ToString();
        }

        public BugAttribute() { }
        
        public string BugId { get; private set; }
    }
}