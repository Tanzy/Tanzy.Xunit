using System;
using Xunit.Sdk;

namespace Tanzy.Xunit.Categories
{
    /// <summary>
    /// Apply this attribute to your test method to specify a user story.
    /// </summary>
    [TraitDiscoverer(UserStoryDiscoverer.FullyQualifiedName, NamespaceUtil.Namespace)]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class UserStoryAttribute : Attribute, ITraitAttribute
    {
        public UserStoryAttribute(string userStoryId)
        {
            UserStoryId = userStoryId;
        }
        public UserStoryAttribute(long userStoryId)
        {
            UserStoryId = userStoryId.ToString();
        }
        
        public UserStoryAttribute()
        {
        }
        
        public string UserStoryId { get; private set; }
    }
}