using System;
using AutoFixture;

namespace Tanzy.Xunit.AutoFixture.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CustomizationFixtureAttribute : Attribute
    {
        public Type Type { get; }

        public CustomizationFixtureAttribute(Type type)
        {
            if (!typeof(ICustomization).IsAssignableFrom(type))
                throw new ArgumentException("Type should be of ICustomization type.", nameof(type));

            Type = type;
        }
    }
}