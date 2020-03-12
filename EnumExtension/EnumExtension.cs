using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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

        public static Dictionary<int, string> GetEnumAsList<T>() where T : Enum
        {
            var enumDictionary = new Dictionary<int, string>();

            foreach (var enumValue in typeof(T).GetEnumValues())
            {
                enumDictionary[(int)enumValue] = GetDescription((Enum)enumValue);
            }

            return enumDictionary;
        }

    }
}
