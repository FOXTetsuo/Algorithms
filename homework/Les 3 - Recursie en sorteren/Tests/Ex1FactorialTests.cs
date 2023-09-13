using NUnit.Framework;

namespace AD
{
    [TestFixture]
    public class Ex1FactorialTests
    {
        [TestCase("iterative", 1,1)]
        [TestCase("iterative", 2,2)]
        [TestCase("iterative", 9,362880)]
        [TestCase("iterative", 19,121645100408832000)]
        [TestCase("recursive", 1,1)]
        [TestCase("recursive", 2,2)]
        [TestCase("recursive", 9,362880)]
        [TestCase("recursive", 19,121645100408832000)]
        public void Factorial(string fun, int n, long expected)
        {
            long actual;
            System.Func<int, long> f = null;

            // Arrange
            if (fun == "iterative")
                f = (x) => Opgave1.FacIterative(x);
            else if (fun == "recursive")
                f = (x) => Opgave1.FacRecursive(x);
            Assert.IsNotNull(f);

            // Act
            actual = f(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}