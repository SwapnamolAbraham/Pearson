using NUnit.Framework;
using PearsonTest;

namespace PearsonNunitTest
{
    public class Tests
    {
        Palindrome palindrome = new Palindrome();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("")]
        public void ShouldWordnothaveavalue(string word)
        {
            Assert.IsFalse(palindrome.FindPalindrome(word));
        }
        [TestCase("noon")]
        public void ShouldWordhaveavalue(string word)
        {
            Assert.IsTrue(palindrome.FindPalindrome(word));
        }
        [TestCase("test")]
        public void ShouldWordIsNotPalindrome(string word)
        {
            Assert.IsFalse(palindrome.FindPalindrome(word));
        }
        [TestCase("A man, a plan, a canal, Panama!")]
        public void ShouldWordHaveSpecialCharcters(string word)
        {
            Assert.IsTrue(palindrome.FindPalindrome(word));
        }
        [TestCase("1881")]
        public void ShouldWordHaveNumbers(string word)
        {
            Assert.IsTrue(palindrome.FindPalindrome(word));
        }
        [TestCase("Madam")]
        public void ShouldWordHaveupperandLowercaseletters(string word)
        {
            Assert.IsTrue(palindrome.FindPalindrome(word));
        }
        [TestCase("M")]
        public void ShouldWordHaveoneletters(string word)
        {
            Assert.IsTrue(palindrome.FindPalindrome(word));
        }
    }
}