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
        [Test]
        public void ToRomanNumeral_1_ReturnsI()
        {
            Assert.AreEqual("I", 1.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_5_ReturnsV()
        {
            Assert.AreEqual("V", 5.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_4_ReturnsIV()
        {
            Assert.AreEqual("IV", 4.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_10_ReturnsX()
        {
            Assert.AreEqual("X", 10.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_9_ReturnsIX()
        {
            Assert.AreEqual("IX", 9.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_22_ReturnsXXII()
        {
            Assert.AreEqual("XXII", 22.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_49_ReturnsXLIX()
        {
            Assert.AreEqual("XLIX", 49.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_64_ReturnsLXIV()
        {
            Assert.AreEqual("LXIV", 64.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_83_ReturnsLXXXIII()
        {
            Assert.AreEqual("LXXXIII", 83.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_97_ReturnsXCVII()
        {
            Assert.AreEqual("XCVII", 97.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_99_ReturnsXCIX()
        {
            Assert.AreEqual("XCIX", 99.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_500_ReturnsD()
        {
            Assert.AreEqual("D", 500.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_501_ReturnsDI()
        {
            Assert.AreEqual("DI", 501.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_649_ReturnsDCXLIX()
        {
            Assert.AreEqual("DCXLIX", 649.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_994_ReturnsCMXCIV()
        {
            Assert.AreEqual("CMXCIV", 994.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_1004_ReturnsMIV()
        {
            Assert.AreEqual("MIV", 1004.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_1006_ReturnsMVI()
        {
            Assert.AreEqual("MVI", 1006.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_1023_ReturnsMXXIII()
        {
            Assert.AreEqual("MXXIII", 1023.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_2014_ReturnsMMXIV()
        {
            Assert.AreEqual("MMXIV", 2014.ToRomanNumeral());
        }

        [Test]
        public void ToRomanNumeral_3999_ReturnsMMMCMXCIX()
        {
            Assert.AreEqual("MMMCMXCIX", 3999.ToRomanNumeral());
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
