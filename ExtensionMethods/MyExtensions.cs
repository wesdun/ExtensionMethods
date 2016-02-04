using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        private static Dictionary<string, string> numeralSubtractives = new Dictionary<string, string>()
        {
            { "M" + char.ConvertFromUtf32(0x305), "C" + char.ConvertFromUtf32(0x305) },
            { "D" + char.ConvertFromUtf32(0x305), "C" + char.ConvertFromUtf32(0x305) },
            { "C" + char.ConvertFromUtf32(0x305), "X" + char.ConvertFromUtf32(0x305) },
            { "L" + char.ConvertFromUtf32(0x305), "X" + char.ConvertFromUtf32(0x305) },
            { "X" + char.ConvertFromUtf32(0x305), "I" + char.ConvertFromUtf32(0x305) },
            { "V" + char.ConvertFromUtf32(0x305), "I" + char.ConvertFromUtf32(0x305) },
            { "M", "C" },
            { "D", "C" },
            { "C", "X" },
            { "L", "X" },
            { "X", "I" },
            { "V", "I" },
            { "I", "" }
        };

        private static Dictionary<string, int> numeralValues = new Dictionary<string, int>()
        {
            {"", 0 },
            {"I",1 },
            {"V", 5 },
            {"X", 10 },
            {"L", 50 },
            {"C", 100 },
            {"D", 500 },
            {"M", 1000 },
            {"I" + char.ConvertFromUtf32(0x305), 1000},
            {"V" + char.ConvertFromUtf32(0x305), 5000},
            {"X" + char.ConvertFromUtf32(0x305), 10000},
            {"L" + char.ConvertFromUtf32(0x305), 50000},
            {"C" + char.ConvertFromUtf32(0x305), 100000},
            {"D" + char.ConvertFromUtf32(0x305), 500000},
            {"M" + char.ConvertFromUtf32(0x305), 1000000}

        };

        public static string ToRomanNumeral(this int num)
        {
            String result = "";

            if (num == 0)
            {
                result = "nulla";
            } else
            {
                foreach (var numeral in numeralSubtractives)
                {
                    while (num >= numeralValues[numeral.Key])
                    {
                        num -= numeralValues[numeral.Key];
                        result += numeral.Key;
                    }
                    if (num >= (numeralValues[numeral.Key] - numeralValues[numeral.Value]))
                    {
                        result += numeral.Value + numeral.Key;
                        num -= numeralValues[numeral.Key] - numeralValues[numeral.Value];
                    }
                }
            }


            return result;
        }
    }
}
