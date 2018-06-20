using NUnit.Framework;
using Challenges;

namespace Tests
{
    public class NonRepeatingTests
    {
        [Test]
        public void stringWithOneTestCase()
        {
            var result = NonRepeating.Run("zxvczbtxyzvy");
            Assert.That(result, Is.EqualTo("c"));
        }
        [Test]
        public void stringWithTwoTestCase()
        {
            var result = NonRepeating.Run("hello");
            Assert.That(result, Is.EqualTo("h"));
        }
         [Test]
        public void stringWithThreeTestCase()
        {
            var result = NonRepeating.Run("xxyyzz");
            Assert.That(result, Is.EqualTo("-1"));
        }  
        [Test]
        public void stringWithZeroTestCase()
        {
            var result = NonRepeating.Run(" ");
            Assert.That(result, Is.EqualTo("Empty string"));
        }
    }
}