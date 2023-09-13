using NUnit.Framework;

namespace AD
{
    [TestFixture]
    public class Ex3OmEnOmTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(10, 30)]
        [TestCase(17, 81)]
        [TestCase(19, 100)]
        public void OmEnOm(int n, long expected)
        {
            int actual;

            // Arrange

            // Act
            actual = Opgave3.OmEnOm(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-1)]
        [TestCase(-10)]
        public void OmEnOm_ThrowingExceptionOnNegativeInput(int n)
        {
            // Arrange

            // Act & Assert
            Assert.Throws(typeof(OmEnOmNegativeValueException), () => Opgave3.OmEnOm(n));
        }

    }
}