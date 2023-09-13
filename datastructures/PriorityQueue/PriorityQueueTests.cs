using NUnit.Framework;

namespace AD
{
    [TestFixture]
    public partial class PriorityQueueTests
    {
        [Test]
        public void PriorityQueue_01_Size_01_OnEmptyQueue()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueEmpty();
            int expected = 0;

            // Act
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_01_Size_02_OnSmallQueue()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueSmall();
            int expected = 4;

            // Act
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_01_Size_03_OnModerateQueue()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            int expected = 9;

            // Act
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_02_ToString_01_OnEmptyQueue()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueEmpty();
            string expected = "";

            // Act
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_02_ToString_02_OnSmallQueue()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueSmall();
            string expected = "1 3 5 4";

            // Act
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_02_ToString_03_OnModerateQueue()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            string expected = "-8 -2 -8 7 5 5 6 8 9";

            // Act
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_03_Clear_01_OnEmptyQueue_01_SizeEquals0()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueEmpty();
            int expected = 0;

            // Act
            q.Clear();
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_03_Clear_01_OnEmptyQueue_02_ToStringIsEmpty()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueEmpty();
            string expected = "";

            // Act
            q.Clear();
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_03_Clear_02_OnSmallQueue_01_SizeEquals0()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueSmall();
            int expected = 0;

            // Act
            q.Clear();
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_03_Clear_02_OnSmallQueue_02_ToStringIsEmpty()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueSmall();
            string expected = "";

            // Act
            q.Clear();
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_04_Add_01_OnEmptyQueue_01_SizeEquals1()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueEmpty();
            int expected = 1;

            // Act
            q.Add(3);
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_04_Add_01_OnEmptyQueue_02_ToStringIsEmpty()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueEmpty();
            string expected = "3";

            // Act
            q.Add(3);
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Watch it: the method CreatePriorityQueueModerate uses a fixed
        // array as initialization. Therefore, the allocated memory is not
        // equal to "CAPACITY", but to the length of the array
        // Therefore, the first call to Add() can generate an
        // out-of-bounds exception!
        [Test]
        public void PriorityQueue_04_Add_02_LeafNodeEqualsParent_01_SizeIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            int expected = 10;

            // Act
            q.Add(5);
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_04_Add_02_LeafNodeEqualsParent_02_ToStringIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            string expected = "-8 -2 -8 7 5 5 6 8 9 5";

            // Act
            q.Add(5);
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_04_Add_03_LeafNodeLargerThanParent_01_SizeIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            int expected = 10;

            // Act
            q.Add(6);
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_04_Add_03_LeafNodeLargerThanParent_02_ToStringIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            string expected = "-8 -2 -8 7 5 5 6 8 9 6";

            // Act
            q.Add(6);
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_04_Add_04_InnerNodeEqualsParent_01_SizeIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            int expected = 10;

            // Act
            q.Add(2);
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_04_Add_04_InnerNodeEqualsParent_02_ToStringIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            string expected = "-8 -8 -8 7 -2 5 6 8 9 5";

            // Act
            q.Add(-8);
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_04_Add_05_InnerNodeLargerThanParent_01_SizeIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            int expected = 10;

            // Act
            q.Add(3);
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_04_Add_05_InnerNodeLargerThanParent_02_ToStringIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            string expected = "-8 -5 -8 7 -2 5 6 8 9 5";

            // Act
            q.Add(-5);
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_04_Add_06_NewRootNode_01_SizeIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            int expected = 10;

            // Act
            q.Add(1);
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_04_Add_06_NewRootNode_02_ToStringIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            string expected = "-10 -8 -8 7 -2 5 6 8 9 5";

            // Act
            q.Add(-10);
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_05_Remove_01_OnEmptyQueue()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueEmpty();

            // Act & Assert
            Assert.Throws(typeof(PriorityQueueEmptyException), () => q.Remove());
        }
        [Test]
        public void PriorityQueue_05_Remove_02_OnSmallQueue_01_SizeIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueSmall();
            int expected = 3;

            // Act
            q.Remove();
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_05_Remove_02_OnSmallQueue_02_ToStringIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueSmall();
            string expected = "3 4 5";

            // Act
            q.Remove();
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_05_Remove_02_OnSmallQueue_03_RunTwiceToStringIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueSmall();
            string expected = "4 5";

            // Act
            q.Remove();
            q.Remove();
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_05_Remove_03_OnModerateQueue_01_SizeIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            int expected = 8;

            // Act
            q.Remove();
            int actual = q.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_05_Remove_03_OnModerateQueue_02_ToStringIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            string expected = "-8 -2 5 7 5 9 6 8";

            // Act
            q.Remove();
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PriorityQueue_05_Remove_03_OnModerateQueue_03_RunTwiceToStringIsOk()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueModerate();
            string expected = "-2 5 5 7 8 9 6";

            // Act
            q.Remove();
            q.Remove();
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Should not be necessary to check: see also 04_Add_02
        [Test]
        public void PriorityQueue_06_CheckForOverFlow()
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueFull();

            // Act
            for (int i = 0; i < PriorityQueue<int>.DEFAULT_CAPACITY * 100; i++)
                q.Add(3);

            // Assert

            // Just asserting we get to this line without an out-of-bounds exception
            // We _could_ check whether the new capacity is twice as big ..
        }
        [Test, Sequential]
        public void PriorityQueue_07_AddFreely(
            [Values(
                new int[] {1},
                new int[] {1, 2, 3, 4, 5, 6, 7, 8},
                new int[] {8, 7, 6, 5, 4, 3, 2, 1},
                new int[] {2, 1, 3, 8, 4, 7, 6, 5}
            )] int[] sequence,
            [Values(
                "1",
                "1 2 3 4 5 6 7 8",
                "8 7 6 5 4 3 2 1",
                "2 1 3 8 4 7 6 5"
            )] string expected)
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueEmpty();

            // Act
            foreach (int element in sequence)
                q.AddFreely(element);
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test, Sequential]
        public void PriorityQueue_08_BuildHeap(
            [Values(
                new int[] {1},
                new int[] {1, 2, 3, 4, 5, 6, 7, 8},
                new int[] {8, 7, 6, 5, 4, 3, 2, 1},
                new int[] {2, 1, 3, 8, 4, 7, 6, 5},
                new int[] {20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1}
            )] int[] sequence,
            [Values(
                "1",
                "1 2 3 4 5 6 7 8",
                "1 4 2 5 8 3 6 7",
                "1 2 3 5 4 7 6 8",
                "1 2 6 3 10 8 7 4 12 11 19 9 15 18 14 5 13 17 20 16"
            )] string expected)
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueEmpty();
            foreach (int element in sequence)
                q.AddFreely(element);

            // Act
            q.BuildHeap();
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
