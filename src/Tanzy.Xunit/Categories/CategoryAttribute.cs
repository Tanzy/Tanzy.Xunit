using System;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories
{
    /// <summary>
    /// Applies a category trait to a test.
    /// </summary>
    [TraitDiscoverer(CategoryDiscoverer.FullyQualifiedName, NamespaceUtil.Namespace)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class CategoryAttribute : Attribute, ITraitAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryTraitAttribute"/> class.
        /// </summary>
        /// <param name="category">The category of the test (e.g. Unit or Integration)</param>
        public CategoryAttribute(string category)
        {
            this.Category = category;
        }

        /// <summary>
        /// Gets the value of the Category trait.
        /// </summary>
        public string Category { get; private set; }
    }
}