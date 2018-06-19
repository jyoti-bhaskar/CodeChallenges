using NUnit.Framework;
using Challenges;

namespace Tests
{
    public class FirstFactorialTests
    {
        [Test]
        public void four_returns_24()
        {
            var result = FirstFactorial.Run(4);
            Assert.That(result, Is.EqualTo(24));
        }

        [Test]
        public void five_returns_120()
        {
            var result = FirstFactorial.Run(5);
            Assert.That(result, Is.EqualTo(120));
        }
    }
}