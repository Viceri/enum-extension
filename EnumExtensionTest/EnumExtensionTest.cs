using System.ComponentModel;
using Xunit;

namespace EnumExtension.testing
{
    public class EnumExtensionTest
    {
        [Theory]
        [InlineData(Sex.Male, "Male M")]
        [InlineData(Sex.Female, "Female M")]
        [InlineData(Sex.Unisex, "Unisex M")]
        public void Should_Return_Enum_Description(Sex sex, string expectedValue)
        {
            var enumValue = EnumExtension.GetDescription(sex);

            Assert.Equal(enumValue, expectedValue);
        }
    }

    public enum Sex
    {
        [Description("Male M")]
        Male,

        [Description("Female M")]
        Female,

        [Description("Unisex M")]
        Unisex,
    }
}
