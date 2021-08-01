using Brooze;
using NUnit.Framework;

namespace BroozeTest
{
    public class Tests
    {
        private int _one;
        private int _zero;
        private SomeService _service;
        
        [SetUp]
        public void Setup()
        {
            _one = 1;
            _zero = 0;
            _service = new SomeService();
        }

        [Test]
        public void TestThatPass()
        {
            Assert.Pass("Test passed");
        }

        [Test]
        public void TestService1()
        {
            Assert.AreEqual(_one, _service.GiveMeOne());
        }

        [Test]
        public void TestService2()
        {
            Assert.AreEqual(_zero, _service.GiveMeOne());
        }
    }
}