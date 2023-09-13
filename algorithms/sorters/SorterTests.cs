using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AD
{

    [TestFixture]
    public partial class SorterTests
    {

        [Test, Combinatorial]
        public void Sort(
                    [Values("InsertionSort", "MergeSort", "ShellSort", "QuickSort")] string sorterName,
                    [Values(0, 1, 2, 10, 3000)] int n)
        {
            List<int> list = new List<int>();
            List<int> listCopy;
            Sorter sorter;

            // Arrange
            sorter = DSBuilder.CreateSorter(sorterName);
            Assert.IsNotNull(sorter);

            // Arrange
            list = TestUtils.RandomList(0, 100000, n);
            listCopy = new List<int>(list);
            listCopy.Sort();

            // Act
            sorter.Sort(list);

            // Assert
            bool equal = list.SequenceEqual(listCopy);
            Assert.IsTrue(equal);
        }
        [Test, Combinatorial]
        public void SortSame(
                            [Values("InsertionSort", "MergeSort", "ShellSort", "QuickSort")] string sorterName)
        {
            List<int> list = new List<int>();
            Sorter sorter;

            // Arrange
            sorter = DSBuilder.CreateSorter(sorterName);
            Assert.IsNotNull(sorter);

            // Arrange
            for (int i = 0; i < 20; i++)
                list.Add(5);

            // Act
            sorter.Sort(list);

            // Assert
            Assert.AreEqual(20, list.Count);
            for (int i = 0; i < 20; i++)
                Assert.AreEqual(5, list[i]);
        }
    }
}