using NUnit.Framework;
using PearsonTest;

namespace PearsonNunitTest
{
    public class RomansTest
    {
        Romans romans = new Romans();
        [SetUp]
        public void Setup()
        {
        }

        [TestCase]
        public void ShouldNotReturnRoman_0()
        {
            Assert.AreEqual("", romans.FindRomanLetters("0"));
        }

        [TestCase]
        public void ShouldReturnRoman_I_1()
        {
            Assert.AreEqual("I", romans.FindRomanLetters("1"));
        }

        [TestCase]
        public void ShouldReturnRoman_II_2()
        {
            Assert.AreEqual("II", romans.FindRomanLetters("2"));
        }

        [TestCase]
        public void ShouldReturnRoman_III_3()
        {
            Assert.AreEqual("III", romans.FindRomanLetters("3"));
        }

        [TestCase]
        public void ShouldReturnRoman_IV_4()
        {
            Assert.AreEqual("IV", romans.FindRomanLetters("4"));
        }

        [TestCase]
        public void ShouldReturnRoman_V_5()
        {
            Assert.AreEqual("V", romans.FindRomanLetters("5"));
        }

        [TestCase]
        public void ShouldReturnRoman_IX_9()
        {
            Assert.AreEqual("IX", romans.FindRomanLetters("9"));
        }

        [TestCase]
        public void ShouldReturnRoman_X_10()
        {
            Assert.AreEqual("X", romans.FindRomanLetters("10"));
        }

        [TestCase]
        public void ShouldReturnRoman_XXXIX_39()
        {
            Assert.AreEqual("XXXIX", romans.FindRomanLetters("39"));
        }

        [TestCase]
        public void ShouldReturnRoman_XLIX_49()
        {
            Assert.AreEqual("XLIX", romans.FindRomanLetters("49"));
        }

        [TestCase]
        public void ShouldReturnRoman_L_50()
        {
            Assert.AreEqual("L", romans.FindRomanLetters("50"));
        }

        [TestCase]
        public void ShouldReturnRoman_C_100()
        {
            Assert.AreEqual("C", romans.FindRomanLetters("100"));
        }

        [TestCase]
        public void ShouldReturnRoman_CCXLVI_246()
        {
            Assert.AreEqual("CCXLVI", romans.FindRomanLetters("246"));
        }


        [TestCase]
        public void ShouldReturnRoman_CD_400()
        {
            Assert.AreEqual("CD", romans.FindRomanLetters("400"));
        }

        [TestCase]
        public void ShouldReturnRoman_D_500()
        {
            Assert.AreEqual("D", romans.FindRomanLetters("500"));
        }
        [TestCase]
        public void ShouldReturnRoman_DCCLXXXIX_789()
        {
            Assert.AreEqual("DCCLXXXIX", romans.FindRomanLetters("789"));
        }
        [TestCase]
        public void ShouldReturnRoman_CM_900()
        {
            Assert.AreEqual("CM", romans.FindRomanLetters("900"));
        }

        [TestCase]
        public void ShouldReturnRoman_M_1000()
        {
            Assert.AreEqual("M", romans.FindRomanLetters("1000").ToString());
        }

        [TestCase]
        public void ShouldReturnRoman_MMCDXXI_2421()
        {
            Assert.AreEqual("MMCDXXI", romans.FindRomanLetters("2,421").ToString());
        }

        [TestCase]
        public void ShouldReturnRoman_MMMMMMMMMMMCMLXXXIV_11984()
        {
            Assert.AreEqual("MMMMMMMMMMMCMLXXXIV", romans.FindRomanLetters("11,984"));
        }
    }
}