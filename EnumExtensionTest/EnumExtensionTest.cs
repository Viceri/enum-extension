using System.ComponentModel;
using System.Linq;
using Xunit;

namespace EnumExtension.testing
{
    public class EnumExtensionTest
    {
        [Theory]
        [InlineData(Sex.Male, "Male M")]
        [InlineData(Sex.Female, "Female F")]
        [InlineData(Sex.Unisex, "Unisex U")]
        public void Should_Return_Enum_Description(Sex sex, string expectedValue)
        {
            var enumValue = EnumExtension.GetDescription(sex);

            Assert.Equal(enumValue, expectedValue);
        }

        [Fact]
        public void Should_Return_Enum_As_List()
        {
            var enumExpectedValues = new[]
            {
                "Male M",
                "Female F",
                "Unisex U"
            };

            var enumValues = EnumExtension.GetEnumAsList<Sex>();

            Assert.Equal(3, enumValues.Count());

            foreach (var enumValue in enumValues)
            {
               Assert.Contains(enumValue, enumExpectedValues);
            }
        }
    }

    public enum Sex
    {
        [Description("Male M")]
        Male,

        [Description("Female F")]
        Female,

        [Description("Unisex U")]
        Unisex,
    }
}
