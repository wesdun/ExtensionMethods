using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ExtensionMethods
{
    [TestFixture]
    class RomanNumeralTests
    {
        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("IV", 4)]
        [TestCase("X", 10)]
        [TestCase("IX", 9)]
        [TestCase("XXII", 22)]
        [TestCase("XLIX", 49)]
        [TestCase("LXIV", 64)]
        [TestCase("LXXXIII", 83)]
        [TestCase("XCVII", 97)]
        [TestCase("XCIX", 99)]
        [TestCase("D", 500)]
        [TestCase("DI", 501)]
        [TestCase("DCXLIX", 649)]
        [TestCase("CMXCIV", 994)]
        [TestCase("MIV", 1004)]
        [TestCase("MVI", 1006)]
        [TestCase("MXXIII", 1023)]
        [TestCase("MMXIV", 2014)]
        [TestCase("MMMCMXCIX", 3999)]
        [TestCase("nulla", 0)]
        public void ToRomanNumeralTest(string result, int num)
        {
            Assert.AreEqual(result, num.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_4005_ReturnsIbVbV()
        {
            Assert.AreEqual("I" + char.ConvertFromUtf32(0x305) + "V" + char.ConvertFromUtf32(0x305) + "V", 4005.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_1M1_ReturnsMbI()
        {
            Assert.AreEqual("M" + char.ConvertFromUtf32(0x305) + "I", 1000001.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_999997_Returns()
        {
            Assert.AreEqual("C" + char.ConvertFromUtf32(0x305) +
                "M" + char.ConvertFromUtf32(0x305) +
                "X" + char.ConvertFromUtf32(0x305) +
                "C" + char.ConvertFromUtf32(0x305) +
                "I" + char.ConvertFromUtf32(0x305) +
                "X" + char.ConvertFromUtf32(0x305) +
                "CMXCVII", 999997.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_0_ReturnsNulla()
        {
            Assert.AreEqual("nulla", 0.ToRomanNumeral());
        }
    }
}
