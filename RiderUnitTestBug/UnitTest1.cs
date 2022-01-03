using System;
using NUnit.Framework;

namespace RiderUnitTestBug
{
    abstract class Around
    {
        [TestFixture("a")]
        [TestFixture("b")]
        public class Tests
        {
            private readonly string _value;

            public Tests(string value)
            {
                _value = value;
            }

            [Test]
            public void It_works()
            {
                Assert.That(_value, Is.EqualTo("a"));
            }
        }        
    }

}