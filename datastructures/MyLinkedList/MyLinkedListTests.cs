using NUnit.Framework;


namespace AD
{
    [TestFixture]
    public partial class MyLinkedListTests
    {
        [Test]
        public void MyLinkedList_1_Constructor0_1_SizeEquals0()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            int expected = 0;

            // Act
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_1_Constructor0_2_ThrowsExceptionOnGetFirst()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();

            // Act & Assert
            Assert.Throws(typeof(MyLinkedListEmptyException), () => lst.GetFirst());
        }

        [Test]
        public void MyLinkedList_2_AddFirst_1_SizeEquals1After1Insert()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            int expected = 1;

            // Act
            lst.AddFirst("1");
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_2_AddFirst_2_SizeEquals3After3Inserts()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            int expected = 3;

            // Act
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_2_AddFirst_3_GetFirstOkAfter1Insert()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            string expected = "1";

            // Act
            lst.AddFirst("1");
            string actual = lst.GetFirst();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_2_AddFirst_4_GetFirstOkAfter3Inserts()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            string expected = "3";

            // Act
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            string actual = lst.GetFirst();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_3_RemoveFirst_1_ThrowsExceptionOnEmptyList()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();

            // Act & Assert
            Assert.Throws(typeof(MyLinkedListEmptyException), () => lst.RemoveFirst());
        }

        [Test]
        public void MyLinkedList_3_RemoveFirst_2_SizeEquals0After1Insert()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            int expected = 0;

            // Act
            lst.RemoveFirst();
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_3_RemoveFirst_3_SizeEquals2After3Inserts()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            int expected = 2;

            // Act
            lst.RemoveFirst();
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_3_RemoveFirst_4_ThrowsExceptionOnGetFirstAfter1Insert()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");

            // Act
            lst.RemoveFirst();

            // Act & Assert
            Assert.Throws(typeof(MyLinkedListEmptyException), () => lst.GetFirst());
        }

        [Test]
        public void MyLinkedList_3_RemoveFirst_5_GetFirstOkAfter3Inserts()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            string expected = "2";

            // Act
            lst.RemoveFirst();
            string actual = lst.GetFirst();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_4_Clear_1_SizeEquals0OnEmptyList()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            int expected = 0;

            // Act
            lst.Clear();
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_4_Clear_2_SizeEquals0OnList1()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            int expected = 0;

            // Act
            lst.Clear();
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_4_Clear_3_SizeEquals0OnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            int expected = 0;

            // Act
            lst.Clear();
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_5_Insert_01_ThrowsExceptionOnIndexTooLowOnEmptyList()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();

            // Act & Assert
            Assert.Throws(typeof(MyLinkedListIndexOutOfRangeException), () => lst.Insert(-1, "1"));
        }

        [Test]
        public void MyLinkedList_5_Insert_02_ThrowsExceptionOnIndexTooHighOnEmptyList()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();

            // Act & Assert
            Assert.Throws(typeof(MyLinkedListIndexOutOfRangeException), () => lst.Insert(1, "1"));
        }

        [Test]
        public void MyLinkedList_5_Insert_03_ThrowsExceptionOnIndexTooLowOnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");

            // Act & Assert
            Assert.Throws(typeof(MyLinkedListIndexOutOfRangeException), () => lst.Insert(-1, "4"));
        }

        [Test]
        public void MyLinkedList_5_Insert_04_ThrowsExceptionOnIndexTooHighOnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");

            // Act & Assert
            Assert.Throws(typeof(MyLinkedListIndexOutOfRangeException), () => lst.Insert(4, "4"));
        }

        [Test]
        public void MyLinkedList_5_Insert_05_SizeEquals1AfterInsertAtBeginningOnEmptyList()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            int expected = 1;

            // Act
            lst.Insert(0, "1");
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_5_Insert_06_GetFirstOkAfterInsertAtBeginningOnEmptyList()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            string expected = "1";

            // Act
            lst.Insert(0, "1");
            string actual = lst.GetFirst();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_5_Insert_07_SizeEquals4AfterInsertAtBeginningOnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            int expected = 4;

            // Act
            lst.Insert(0, "0");
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_5_Insert_08_GetFirstOkAfterInsertAtBeginningOnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            string expected = "0";

            // Act
            lst.Insert(0, "0");
            string actual = lst.GetFirst();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_5_Insert_09_SizeEquals4AfterInsertAtEndOnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            int expected = 4;

            // Act
            lst.Insert(3, "3");
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_5_Insert_10_GetFirstOkAfterInsertAtEndOnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            string expected = "3";

            // Act
            lst.Insert(3, "4");
            string actual = lst.GetFirst();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_5_Insert_11_GetLastOkAfterInsertAtEndOnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            string expected = "4";

            // Act
            lst.Insert(3, "4");
            lst.RemoveFirst();
            lst.RemoveFirst();
            lst.RemoveFirst();
            string actual = lst.GetFirst();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_5_Insert_12_SizeEquals4AfterInsertInMiddleOnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            int expected = 4;

            // Act
            lst.Insert(1, "4");
            int actual = lst.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_5_Insert_13_GetFirstOkAfterInsertInMiddleOnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            string expected = "3";

            // Act
            lst.Insert(1, "4");
            string actual = lst.GetFirst();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_5_Insert_14_GetMiddleOkAfterInsertInMiddleOnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            string expected = "4";

            // Act
            lst.Insert(1, "4");
            lst.RemoveFirst();
            string actual = lst.GetFirst();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_5_Insert_15_GetLastOkAfterInsertInMiddleOnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            string expected = "1";

            // Act
            lst.Insert(1, "4");
            lst.RemoveFirst();
            lst.RemoveFirst();
            lst.RemoveFirst();
            string actual = lst.GetFirst();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_6_ToString_1_OnEmptyList()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            string expected = "NIL";

            // Act
            string actual = lst.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_6_ToString_2_OnList3()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            string expected = "[3,2,1]";

            // Act
            string actual = lst.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_6_ToString_3_VariousOperations1()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            lst.Insert(2, "4");

            string expected = "[3,2,4,1]";

            // Act
            string actual = lst.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyLinkedList_6_ToString_4_VariousOperations2()
        {
            // Arrange
            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.Insert(1, "4");
            lst.RemoveFirst();

            string expected = "[4,1]";

            // Act
            string actual = lst.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //------------------------------------------------------------
        // Tests to check the internal datastructure. In this case,
        // check whether the datastructure is built without the
        // sentinel node (header node).
        //------------------------------------------------------------

        [Test]
        public void MyLinkedList_7_Internal_1_Constructor()
        {
            // Arrange
            MyLinkedList<string> lst = (MyLinkedList<string>) DSBuilder.CreateMyLinkedListStringEmpty();

            // Assert
            Assert.IsNull(lst.first);
        }

        [Test]
        public void MyLinkedList_7_Internal_2_AddFirst()
        {
            // Arrange
            MyLinkedList<string> lst = (MyLinkedList<string>)DSBuilder.CreateMyLinkedListStringEmpty();

            // Act
            lst.AddFirst("1");

            // Assert
            Assert.IsNotNull(lst.first);
            Assert.IsNull(lst.first.next);
        }

        [Test]
        public void MyLinkedList_7_Internal_3_Insert()
        {
            // Arrange
            MyLinkedList<string> lst = (MyLinkedList<string>)DSBuilder.CreateMyLinkedListStringEmpty();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");

            // Act
            lst.Insert(1, "4");

            // Assert
            Assert.IsNotNull(lst.first);
            Assert.IsNotNull(lst.first.next);
            Assert.IsNotNull(lst.first.next.next);
            Assert.IsNotNull(lst.first.next.next.next);
            Assert.IsNull(lst.first.next.next.next.next);
        }


    }
}
