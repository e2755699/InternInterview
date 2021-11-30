using Demo;
using NUnit.Framework;

namespace DemoTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var demo = new DemoClass();

            var sum = demo.Sum(1, 1);

            var expected = 2;
            Assert.AreEqual(expected, sum);
        }
    }
}