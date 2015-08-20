using ConsoleApplication1;
using NUnit.Framework;
using System;
namespace ConsoleApplication1Test
{
    [TestFixture]
    public class UnitTestMathUtil
    {
        [Test]
        public void Test_MathUtil_Returns_True_Even()
        {
            MathUtil util = new MathUtil();
            Assert.IsTrue(util.IsEven(10));
            Assert.IsTrue(util.IsEven(12));
            Assert.IsTrue(util.IsEven(14));
        }

        [Test]
        public void Test_MathUtil_Returns_True_Odd()
        {
            MathUtil util = new MathUtil();
            Assert.IsTrue(util.IsOdd(11));
            Assert.IsTrue(util.IsOdd(12));
        }
    }
}
