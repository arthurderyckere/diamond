using NUnit.Framework;
using Diamond.Diamond;

namespace Diamond.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Assert_PrintDiamond_A_Returns_A()
        {
            var diamond = new DiamondFactory();

            var result = diamond.PrintDiamond('A');
            Assert.AreEqual("A", result);
        }
        [Test]
        public void Assert_PrintDiamond_B_Returns_ABBA()
        {
            var diamond = new DiamondFactory();

            var result = diamond.PrintDiamond('B');
            Assert.AreEqual(" A /nB B/n A ", result);
        }
    }
}