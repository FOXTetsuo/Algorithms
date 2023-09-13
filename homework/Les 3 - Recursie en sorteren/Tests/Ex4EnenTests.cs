using NUnit.Framework;

namespace AD
{
    [TestFixture]
    public class Ex4EnenTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(7, 3)]
        [TestCase(9, 2)]
        [TestCase(15, 4)]
        [TestCase(16, 1)]
        [TestCase(255, 8)]
        [TestCase(1024, 1)]
        public void Enen(int n, int expected)
        {
            int actual;

            // Arrange

            // Act
            actual = Opgave4.Enen(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}