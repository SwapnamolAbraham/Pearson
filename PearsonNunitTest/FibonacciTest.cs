using NUnit.Framework;
using PearsonTest;

namespace PearsonNunitTest
{
    public class FibonacciTest
    {
        Fibonacci fibonacci = new Fibonacci();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase]
        public void ShouldReturnZero()
        {
            Assert.AreEqual(0, fibonacci.FindFibonacci(0));
        }
        [TestCase]
        public void ShouldReturn0_1()
        {
            Assert.AreEqual(0, fibonacci.FindFibonacci(1));
        }
        [TestCase]
        public void ShouldReturnOne()
        {
            Assert.AreEqual(1, fibonacci.FindFibonacci(2));
        }
        [TestCase]
        public void ShouldReturn1_3()
        {
            Assert.AreEqual(1, fibonacci.FindFibonacci(3));
        }
        [TestCase]
        public void ShouldReturnTwo()
        {
            Assert.AreEqual(2, fibonacci.FindFibonacci(4));
        }
        [TestCase]
        public void ShouldReturnThree()
        {
            Assert.AreEqual(3, fibonacci.FindFibonacci(5));
        }
        [TestCase]
        public void ShouldReturnFive()
        {
            Assert.AreEqual(5, fibonacci.FindFibonacci(6));
        }
        [TestCase]
        public void ShouldReturnEight()
        {
            Assert.AreEqual(8, fibonacci.FindFibonacci(7));
        }
        [TestCase]
        public void ShouldReturn_377()
        {
            Assert.AreEqual(377, fibonacci.FindFibonacci(15));
        }

    }
}