using System;
using AutoFixture.Kernel;

namespace Tanzy.Xunit.AutoFixture.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class SpecimenBuilderFixtureAttribute : Attribute
    {
        public Type Type { get; }

        public SpecimenBuilderFixtureAttribute(Type type)
        {
            if (!typeof(ISpecimenBuilder).IsAssignableFrom(type))
                throw new ArgumentException("Type should be of ISpecimenBuilder type.", nameof(type));

            Type = type;
        }
    }
}