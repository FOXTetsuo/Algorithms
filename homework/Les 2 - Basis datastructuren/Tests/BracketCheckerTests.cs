using NUnit.Framework;

namespace AD
{
    [TestFixture]
    public partial class BracketCheckerTests
    {
        [TestCase("", true)]  // Empty
        [TestCase("()", true)]  // Single
        [TestCase("((())())", true)]  // Multiple
        [TestCase("((())((()))", false)]  // Too many opening
        [TestCase("((())()))", false)]  // Too many closing
        [TestCase("(()))(", false)]  // Count ok, but closing without opening
        public void BracketChecker1(string str, bool expected)
        {
            // Act
            bool actual = BracketChecker.CheckBrackets(str);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase("", true)]  // Empty
        [TestCase("{{}}", true)]  // Curly
        [TestCase("[[]]", true)]  // Brackets
        [TestCase("[{()}]", true)]  // Combined
        [TestCase("[(({[]}))]", true)]  // Combined
        [TestCase("[{(([))]}]", false)]  // Combined
        [TestCase("[[[{{(}}]]])", false)]  // Combined
        [TestCase("{[[()]}]", false)]  // Combined
        [TestCase("[{[()}]]", false)]  // Combined
        [TestCase("({[}])", false)]  // Combined
        public void BracketChecker2(string str, bool expected)
        {
            // Act
            bool actual = BracketChecker.CheckBrackets2(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}