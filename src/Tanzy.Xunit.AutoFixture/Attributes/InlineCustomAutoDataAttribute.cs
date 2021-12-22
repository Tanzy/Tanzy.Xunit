using AutoFixture.Xunit2;

namespace Tanzy.Xunit.AutoFixture.Attributes
{
    public class InlineCustomAutoDataAttribute : InlineAutoDataAttribute
    {
        public InlineCustomAutoDataAttribute(params object[] values) : base(new CustomAutoDataAttribute(), values)
        {
        }
    }
}