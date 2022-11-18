using NUnit.Framework;
using PearsonTest;

namespace PearsonNunitTest
{
    public class CoinChangeTest
    {
        CoinChange coinChange = new CoinChange();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase]
        public void ShouldReturnZero()
        {
            Assert.AreEqual(0, coinChange.FindCoinChanges(0));
        }
        [TestCase]
        public void ShouldReturn1()
        {
            Assert.AreEqual(1, coinChange.FindCoinChanges(1));
        }
        [TestCase]
        public void ShouldReturnOne_5()
        {
            Assert.AreEqual(1, coinChange.FindCoinChanges(1));
        }
        [TestCase]
        public void ShouldReturnFive_39()
        {
            Assert.AreEqual(5, coinChange.FindCoinChanges(39));
        }
        [TestCase]
        public void ShouldReturnOne_100()
        {
            Assert.AreEqual(1, coinChange.FindCoinChanges(100));
        }
        [TestCase]
        public void ShouldReturnFive_256()
        {
            Assert.AreEqual(5, coinChange.FindCoinChanges(256));
        }
        [TestCase]
        public void ShouldReturnTen_1000()
        {
            Assert.AreEqual(10, coinChange.FindCoinChanges(1000));
        }
        [TestCase]
        public void ShouldReturnTwentyOne_1890()
        {
            Assert.AreEqual(21, coinChange.FindCoinChanges(1890));
        }
    }
}