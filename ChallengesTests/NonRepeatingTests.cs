using NUnit.Framework;
using Challenges;

namespace Tests
{
    public class NonRepeatingTests
    {
        [Test]
        public void string_zxvczbtxyzvy_returns_c()
        {
            var result = NonRepeating.Run("zxvczbtxyzvy");
            Assert.That(result, Is.EqualTo("c"));
        }
        [Test]
        public void string_hello_returns_h()
        {
            var result = NonRepeating.Run("hello");
            Assert.That(result, Is.EqualTo("h"));
        }
         [Test]
        public void string_xxyyzz_returns_minus_1()
        {
            var result = NonRepeating.Run("xxyyzz");
            Assert.That(result, Is.EqualTo("-1"));
        }  
        [Test]
        public void whitspace_string_retuns_EmptyString()
        {
            var result = NonRepeating.Run(" ");
            Assert.That(result, Is.EqualTo("Empty string"));
        }
    }
}