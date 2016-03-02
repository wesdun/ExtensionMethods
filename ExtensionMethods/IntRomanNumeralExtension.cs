using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class IntRomanNumeralExtension
    {
        private static RomanNumeral[] RomanNumerals = {
            new RomanNumeral("M" + char.ConvertFromUtf32(0x305), 1000000, "C" + char.ConvertFromUtf32(0x305)),
            new RomanNumeral("D" + char.ConvertFromUtf32(0x305), 500000, "C" + char.ConvertFromUtf32(0x305)),
            new RomanNumeral("C" + char.ConvertFromUtf32(0x305), 100000, "X" + char.ConvertFromUtf32(0x305)),
            new RomanNumeral("L" + char.ConvertFromUtf32(0x305), 50000, "X" + char.ConvertFromUtf32(0x305)),
            new RomanNumeral("X" + char.ConvertFromUtf32(0x305), 10000, "I" + char.ConvertFromUtf32(0x305)),
            new RomanNumeral("V" + char.ConvertFromUtf32(0x305), 5000, "I" + char.ConvertFromUtf32(0x305)),
            new RomanNumeral("M", 1000, "C"),
            new RomanNumeral("D", 500, "C"),
            new RomanNumeral("C", 100, "X"),
            new RomanNumeral("L", 50, "X"),
            new RomanNumeral("X", 10, "I"),
            new RomanNumeral("V", 5, "I"),
            new RomanNumeral("I", 1, ""),
            new RomanNumeral("I" + char.ConvertFromUtf32(0x305), 1000, "")
            };

        public static string ToRomanNumeral(this int num)
        {
            String result = "";

            if (num == 0)
            {
                result = "nulla";
            } else
            {
                foreach (var numeral in RomanNumerals)
                {
                    while (num >= numeral.intValue) 
                    {
                        num -= numeral.intValue;
                        result += numeral.character;
                    }
                    if (NeedsSubtractiveNotation(num, numeral)) 
                    {
                        num -= numeral.intValue - GetSubtractiveIntValue(numeral.subtractive);
                        result += numeral.subtractive + numeral.character;
                    }
                }
            }

            return result;
        }

        private static bool NeedsSubtractiveNotation(int num, RomanNumeral numeral)
        {
            return num >= (numeral.intValue - GetSubtractiveIntValue(numeral.subtractive));
        }

        private static int GetSubtractiveIntValue(string RomanNumeralCharacter)
        {
            for (int i = 0; i < RomanNumerals.Length; i++)
            {
                if(RomanNumeralCharacter == RomanNumerals[i].character)
                {
                    return RomanNumerals[i].intValue;
                }
            }

            return 0;
        }
    }

    public class RomanNumeral {

        public string character;
        public int intValue;
        public string subtractive;

        public RomanNumeral(string character, int intValue, string subtractive)
        {
            this.character = character;
            this.intValue = intValue;
            this.subtractive = subtractive;
        }
    }
}
