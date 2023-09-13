using NUnit.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AD
{
    [TestFixture]
    public class Ex6ForwardStringTests
    {

        [TestCase(0, "")]
        [TestCase(3, "")]
        public void ForwardString_Empty(int n, string expected)
        {
            List<int> list = new List<int>();
            string actual;

            // Arrange

            // Act
            actual = TestUtils.TrimmedStringWithSingleSpaces(Opgave6.ForwardString(list, n));

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "0 1 2 3 4 5 6 7 8 9 10 11")]
        [TestCase(3, "3 4 5 6 7 8 9 10 11")]
        [TestCase(11, "11")]
        [TestCase(12, "")]
        public void ForwardString_Filled(int n, string expected)
        {
            List<int> list = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            string actual;

            // Arrange

            // Act
            actual = TestUtils.TrimmedStringWithSingleSpaces(Opgave6.ForwardString(list, n));

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "")]
        [TestCase(3, "")]
        public void BackwardString_Empty(int n, string expected)
        {
            List<int> list = new List<int>();
            string actual;

            // Arrange

            // Act
            actual = TestUtils.TrimmedStringWithSingleSpaces(Opgave6.BackwardString(list, n));

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "11 10 9 8 7 6 5 4 3 2 1 0")]
        [TestCase(3, "11 10 9 8 7 6 5 4 3")]
        [TestCase(11, "11")]
        [TestCase(12, "")]
        public void BackwardString_Filled(int n, string expected)
        {
            List<int> list = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            string actual;

            // Arrange

            // Act
            actual = TestUtils.TrimmedStringWithSingleSpaces(Opgave6.BackwardString(list, n));

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}