using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        private static Tuple<string, string>[] numerals =
        {
            Tuple.Create("M" + char.ConvertFromUtf32(0x305), "C" + char.ConvertFromUtf32(0x305)),
            Tuple.Create("D" + char.ConvertFromUtf32(0x305), "C" + char.ConvertFromUtf32(0x305)),
            Tuple.Create("C" + char.ConvertFromUtf32(0x305), "X" + char.ConvertFromUtf32(0x305)),
            Tuple.Create("L" + char.ConvertFromUtf32(0x305), "X" + char.ConvertFromUtf32(0x305)),
            Tuple.Create("X" + char.ConvertFromUtf32(0x305), "I" + char.ConvertFromUtf32(0x305)),
            Tuple.Create("V" + char.ConvertFromUtf32(0x305), "I" + char.ConvertFromUtf32(0x305)),
            Tuple.Create("M", "C"),
            Tuple.Create("D", "C"),
            Tuple.Create("C", "X"),
            Tuple.Create("L", "X"),
            Tuple.Create("X", "I"),
            Tuple.Create("V", "I"),
            Tuple.Create("I", "")
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

            foreach (var numeral in numerals) {
                while (num >= numeralValues[numeral.Item1])
                {
                    num -= numeralValues[numeral.Item1];
                    result += numeral.Item1;
                }
                if (num >= (numeralValues[numeral.Item1] - numeralValues[numeral.Item2]))
                {
                    result += numeral.Item2 + numeral.Item1;
                    num -= numeralValues[numeral.Item1] - numeralValues[numeral.Item2];
                }
            }

            return result;
        }
    }
}
