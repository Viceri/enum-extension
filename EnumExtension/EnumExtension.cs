using System;
using System.Collections.Generic;
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

        public static IEnumerable<string> GetEnumAsList<T>() where T : Enum
        {
            var enumValues = new List<string>();

            foreach (var enumValue in typeof(T).GetEnumValues())
            {
                enumValues.Add(GetDescription((Enum)enumValue));
            }

            return enumValues;
        }

    }
}
