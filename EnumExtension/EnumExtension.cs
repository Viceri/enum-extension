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

        public static IEnumerable<EnumValue> GetEnumAsList<T>() where T : Enum
        {
            var enumValues = (IEnumerable<T>)typeof(T).GetEnumValues();

            return enumValues.Select((value, index) => new EnumValue
            {
                Index = index,
                Description = GetDescription(value)
            });
        }

    }

    public class EnumValue
    {
        public int Index { get; set; }
        public string Description { get; set; }
    }
}
