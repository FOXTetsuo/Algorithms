using NUnit.Framework;
using System;


namespace AD
{
    [TestFixture]
    public partial class MyArrayListTests
    {
        [Test]
        public void MyArrayList_1_Constructor5_1_CapacityEquals5()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 5;

            // Act
            int actual = lst.Capacity();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_1_Constructor5_2_SizeEquals0()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 0;

            // Act
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_2_Add_1_CapacityEquals5()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 5;
            lst.Add(3);

            // Act
            int actual = lst.Capacity();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_2_Add_2_SizeEquals1()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 1;
            lst.Add(3);

            // Act
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_2_Add_3_CapacityAlmostFull()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 5;
            lst.Add(3);
            lst.Add(3);
            lst.Add(3);
            lst.Add(3);
            lst.Add(3);

            // Act
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_2_Add_4_CapacityFull()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            lst.Add(3);
            lst.Add(3);
            lst.Add(3);
            lst.Add(3);
            lst.Add(3);

            // Act & Assert
            Assert.Throws(typeof(MyArrayListFullException), () => lst.Add(3));
        }

        [Test]
        public void MyArrayList_3_Get_1_GetReturnsProperResult()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 2;
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);

            // Act
            int actual = lst.Get(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_3_Get_2_ThrowsExceptionOnEmptyList()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();

            // Act & Assert
            Assert.Throws(typeof(MyArrayListIndexOutOfRangeException), () => lst.Get(0));
        }

        [Test]
        public void MyArrayList_3_Get_3_ThrowsExceptionOnTooLowIndex()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            lst.Add(1);
            lst.Add(2);

            // Act & Assert
            Assert.Throws(typeof(MyArrayListIndexOutOfRangeException), () => lst.Get(-1));
        }

        [Test]
        public void MyArrayList_3_Get_4_ThrowsExceptionOnTooHighIndex()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            lst.Add(1);
            lst.Add(2);

            // Act & Assert
            Assert.Throws(typeof(MyArrayListIndexOutOfRangeException), () => lst.Get(2));
        }

        [Test]
        public void MyArrayList_4_Set_1_GetReturnsProperResult()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 7;
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);

            // Act
            lst.Set(1, 7);
            int actual = lst.Get(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_4_Set_2_ThrowsExceptionOnEmptyList()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();

            // Act & Assert
            Assert.Throws(typeof(MyArrayListIndexOutOfRangeException), () => lst.Set(0, 2));
        }

        [Test]
        public void MyArrayList_4_Set_3_ThrowsExceptionOnTooLowIndex()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();

            // Act
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);

            // Assert
            Assert.Throws(typeof(MyArrayListIndexOutOfRangeException), () => lst.Set(-1, 2));
        }

        [Test]
        public void MyArrayList_4_Set_4_ThrowsExceptionOnTooHighIndex()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();

            // Act
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            Assert.Throws(typeof(MyArrayListIndexOutOfRangeException), () => lst.Set(4, 2));
        }

        [Test]
        public void MyArrayList_5_Clear_1_CapacityRemainsSame()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 5;
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);

            // Act
            lst.Clear();
            int actual = lst.Capacity();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_5_Clear_2_SizeEquals0()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 0;
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);

            // Act
            lst.Clear();
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_5_Clear_3_GetThrowsExceptionAfterClear()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            lst.Add(1);
            lst.Add(2);
            lst.Clear();

            // Act & Assert
            Assert.Throws(typeof(MyArrayListIndexOutOfRangeException), () => lst.Get(0));
        }

        [Test]
        public void MyArrayList_5_Clear_4_SetThrowsExceptionAfterClear()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Clear();

            // Act & Assert
            Assert.Throws(typeof(MyArrayListIndexOutOfRangeException), () => lst.Set(0, 2));
        }

        [Test]
        public void MyArrayList_6_ToString_1_OnEmptyList()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            String expected = "NIL";

            // Act
            String actual = lst.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_6_ToString_2_OnSingleElement()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            String expected = "[3]";

            // Act
            lst.Add(3);
            String actual = lst.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_6_ToString_3_OnFullList()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            String expected = "[1,2,3,4,5]";

            // Act
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            String actual = lst.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_6_ToString_4_AfterSet()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            String expected = "[1,2,7,4,5]";

            // Act
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            lst.Set(2, 7);
            String actual = lst.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_6_ToString_5_AfterClear()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            String expected = "NIL";

            // Act
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            lst.Clear();
            String actual = lst.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_7_CountOccurences_1_OnEmptyList()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 0;

            // Act
            int actual = lst.CountOccurences(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_7_CountOccurences_2_NoOccurences()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 0;

            // Act
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            int actual = lst.CountOccurences(6);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_7_CountOccurences_3_OneOccurence()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 1;

            // Act
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            int actual = lst.CountOccurences(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_7_CountOccurences_4_MoreOccurences()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 3;

            // Act
            lst.Add(3);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(3);
            int actual = lst.CountOccurences(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_8_CountOccurences_5_ReturnsProperResultAfterClean()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 0;

            // Act
            lst.Add(3);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(3);
            lst.Clear();
            int actual = lst.CountOccurences(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyArrayList_8_CountOccurences_5_ReturnsProperResultAfterCleanAndAdd()
        {
            // Arrange
            IMyArrayList lst = DSBuilder.CreateMyArrayList5();
            int expected = 1;

            // Act
            lst.Add(3);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(3);
            lst.Clear();
            lst.Add(3);
            int actual = lst.CountOccurences(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}