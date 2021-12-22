using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoFixture;
using AutoFixture.Kernel;
using AutoFixture.Xunit2;
using Xunit.Sdk;

namespace Tanzy.Xunit.AutoFixture.Attributes
{
    [DataDiscoverer("AutoFixture.Xunit2.NoPreDiscoveryDataDiscoverer", "AutoFixture.Xunit2")]
    public class CustomAutoDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var customizations = testMethod.GetCustomAttributes<CustomizationFixtureAttribute>()
                .Select(attr => Activator.CreateInstance(attr.Type))
                .Cast<ICustomization>();

            var builders = testMethod.GetCustomAttributes<SpecimenBuilderFixtureAttribute>()
                .Select(attr => Activator.CreateInstance(attr.Type))
                .Cast<ISpecimenBuilder>();
            return new CustomizedAutoData(customizations, builders).GetData(testMethod);
        }

        private class CustomizedAutoData : AutoDataAttribute
        {
            public CustomizedAutoData(IEnumerable<ICustomization> customizations,
                IEnumerable<ISpecimenBuilder> builders)
                : base(() =>
                {
                    var fixture = new Fixture();

                    // APPLY COMMON CUSTOMIZATIONS HERE
                    foreach (var customization in customizations)
                    {
                        fixture.Customize(customization);
                    }

                    foreach (var specimenBuilder in builders)
                    {
                        fixture.Customizations.Add(specimenBuilder);
                    }

                    return fixture;
                })
            {
            }
        }
    }
}