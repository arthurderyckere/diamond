using NUnit.Framework;
using Diamond.Diamond;
using System.Text.RegularExpressions;
using System.Linq;

namespace Diamond.Test
{
    public class Tests
    {
        private DiamondFactory _diamond;
        [SetUp]
        public void Setup()
        {
            this._diamond = new DiamondFactory();
        }

        [Test]
        public void Assert_PrintDiamond_A_Returns_A()
        {
            var result = _diamond.PrintDiamond('A');
            Assert.AreEqual("\r\nA", result);
        }
        [Test]
        public void Assert_PrintDiamond_B_Returns_ABBA()
        {
            var result = _diamond.PrintDiamond('B');
            Assert.AreEqual("\r\n A \r\nB B\r\n A ", result);
        }
        [Test]
        public void Assert_PrintDiamond_C_Returns_ABBCCBBA()
        {
            var result = _diamond.PrintDiamond('C');
            Assert.AreEqual("\r\n  A  \r\n B B \r\nC   C\r\n B B \r\n  A  ", result);
        }
        [Test]
        public void Assert_PrintDiamond_Returns_Only_Uppercase_Letters_Or_Whitespaces()
        {
            var result = _diamond.PrintDiamond('Z');
            var isLetterOrWhiteSpace = true;
            foreach (char c in result)
            {
                isLetterOrWhiteSpace = (char.IsLetter(c) && char.IsUpper(c)) || char.IsWhiteSpace(c);
            }
            Assert.IsTrue(isLetterOrWhiteSpace);
        }
        [Test]
        public void Assert_PrintDiamond_Returns_Only_UpperCase_Alphabet_And_Any_Whitespace_Chars()
        {
            var result = _diamond.PrintDiamond('Z');
            var expr = Regex.IsMatch(result, @"^[A-Z\s]+$");
            Assert.IsTrue(expr);
        }
        [Test]
        public void Assert_PrintDiamond_Has_Amount_Of_NewLines()
        {
            char Z = 'Z';
            char A = 'A';
            int lettersInAlphabet = (((short)Z) - ((short)A)) + 1;
            var result = new DiamondFactory().PrintDiamond(Z);
            // ! Could be - 2 if first \r\n was removed.
            Assert.AreEqual((lettersInAlphabet * 2) - 1, result.Count(c => c == '\n'));
        }
    }
}