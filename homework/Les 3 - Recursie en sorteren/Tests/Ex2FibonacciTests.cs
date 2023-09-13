using NUnit.Framework;

namespace AD
{
    [TestFixture]
    public class Ex2FibonacciTests
    {
        [TestCase("iterative", 1,1)]
        [TestCase("iterative", 9,34)]
        [TestCase("iterative", 13,233)]
        [TestCase("iterative", 21,10946)]
        [TestCase("recursive", 1,1)]
        [TestCase("recursive", 9,34)]
        [TestCase("recursive", 13,233)]
        [TestCase("recursive", 21,10946)]
        public void Fibonacci(string fun, int n, long expected)
        {
            long actual;
            System.Func<int, long> f = null;

            // Arrange
            if (fun == "iterative")
                f = (x) => Opgave2.FibonacciIterative(x);
            else if (fun == "recursive")
                f = (x) => Opgave2.FibonacciRecursive(x);
            Assume.That(f != null);

            // Act
            actual = f(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}