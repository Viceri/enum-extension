using System;
using System.ComponentModel;

namespace EnumExtension
{
    public static class EnumExtension
    {
        public static string GetDescription(Enum enumValue)
        {
            var enumValueString = enumValue.GetType().GetMember(enumValue.ToString());

            var attrs = enumValueString[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            return ((DescriptionAttribute)attrs[0]).Description;
        }
    }
}
