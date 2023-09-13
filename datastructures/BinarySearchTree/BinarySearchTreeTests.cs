using NUnit.Framework;


namespace AD
{
    [TestFixture]
    public partial class BinarySearchTreeTests
    {
        [Test]
        public void BinarySearchTree_01_Insert_01_After1Insert_IsEmptyReturnsFalse()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntEmpty();
            bool expected = false;

            // Act
            tree.Insert(3);
            bool actual = tree.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_01_Insert_02_After1Insert_SizeEquals1()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntEmpty();
            int expected = 1;

            // Act
            tree.Insert(3);
            int actual = tree.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_01_Insert_03_After1Insert_HeightEquals0()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntEmpty();
            int expected = 0;

            // Act
            tree.Insert(3);
            int actual = tree.Height();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_01_Insert_04_After3AscendingInserts_ToInfixStringCorrect()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntEmpty();
            string expected = "[ NIL 1 [ NIL 2 [ NIL 3 NIL ] ] ]";

            // Act
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_01_Insert_05_After3DescendingInserts_ToInfixStringCorrect()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntEmpty();
            string expected = "[ [ [ NIL 1 NIL ] 2 NIL ] 3 NIL ]";

            // Act
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(1);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_01_Insert_06_After3UnorderedInserts_ToInfixStringCorrect()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntEmpty();
            string expected = "[ [ NIL 1 NIL ] 2 [ NIL 3 NIL ] ]";

            // Act
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(3);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_01_Insert_07_After13UnorderedInserts_ToInfixStringCorrect()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntEmpty();
            string expected = "[ [ NIL 3 [ [ NIL 7 NIL ] 8 [ NIL 12 NIL ] ] ] 17 [ [ NIL 24 NIL ] 26 [ NIL 32 [ [ NIL 34 [ [ NIL 37 NIL ] 42 NIL ] ] 45 [ NIL 50 NIL ] ] ] ] ]";

            // Act
            tree.Insert(17);
            tree.Insert(3);
            tree.Insert(26);
            tree.Insert(8);
            tree.Insert(24);
            tree.Insert(32);
            tree.Insert(7);
            tree.Insert(12);
            tree.Insert(45);
            tree.Insert(34);
            tree.Insert(50);
            tree.Insert(42);
            tree.Insert(37);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_02_FindMin_01_OnEmptyTree()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntEmpty();

            // Act & Assert
            Assert.Throws(typeof(BinarySearchTreeEmptyException), () => tree.FindMin());
        }

        [Test]
        public void BinarySearchTree_02_FindMin_02_OnTree1Element()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeInt1Element();
            int expected = 4;

            // Act
            int actual = tree.FindMin();

            // Act & Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_02_FindMin_03_OnSmallIntTree()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntSmall();
            int expected = 2;

            // Act
            int actual = tree.FindMin();

            // Act & Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_02_FindMin_04_OnModerateIntTree()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();
            int expected = 3;

            // Act
            int actual = tree.FindMin();

            // Act & Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_03_RemoveMin_01_OnEmptyTree()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntEmpty();

            // Act & Assert
            Assert.Throws(typeof(BinarySearchTreeEmptyException), () => tree.RemoveMin());
        }

        [Test]
        public void BinarySearchTree_03_RemoveMin_02_OnTree1Element()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeInt1Element();
            string expected = "NIL";

            // Act
            tree.RemoveMin();
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_03_RemoveMin_03_OnSmallIntTree()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntSmall();
            string expected = "[ [ NIL 4 [ NIL 5 NIL ] ] 6 [ NIL 7 NIL ] ]";

            // Act
            tree.RemoveMin();
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void BinarySearchTree_03_RemoveMin_04_OnModerateIntTree()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();
            string expected = "[ [ [ NIL 7 NIL ] 8 [ NIL 12 NIL ] ] 17 [ [ NIL 24 NIL ] 26 [ NIL 32 [ [ NIL 34 [ [ NIL 37 NIL ] 42 NIL ] ] 45 [ NIL 50 NIL ] ] ] ] ]";

            // Act
            tree.RemoveMin();
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_04_Remove_01_OnEmptyTree()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntEmpty();

            // Act & Assert
            Assert.Throws(typeof(BinarySearchTreeElementNotFoundException), () => tree.Remove(1));
        }

        [Test]
        public void BinarySearchTree_04_Remove_02_OnNonEmptyTree_ElementNotExisting()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();

            // Act & Assert
            Assert.Throws(typeof(BinarySearchTreeElementNotFoundException), () => tree.Remove(40));
        }

        [Test]
        public void BinarySearchTree_04_Remove_03_OnNonEmptyTree_LeafElement_12()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();
            string expected = "[ [ NIL 3 [ [ NIL 7 NIL ] 8 NIL ] ] 17 [ [ NIL 24 NIL ] 26 [ NIL 32 [ [ NIL 34 [ [ NIL 37 NIL ] 42 NIL ] ] 45 [ NIL 50 NIL ] ] ] ] ]";

            // Act
            tree.Remove(12);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_04_Remove_03_OnNonEmptyTree_LeafElement_37()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();
            string expected = "[ [ NIL 3 [ [ NIL 7 NIL ] 8 [ NIL 12 NIL ] ] ] 17 [ [ NIL 24 NIL ] 26 [ NIL 32 [ [ NIL 34 [ NIL 42 NIL ] ] 45 [ NIL 50 NIL ] ] ] ] ]";

            // Act
            tree.Remove(37);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_04_Remove_04_OnNonEmptyTree_ElementWithLeftChild()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();
            string expected = "[ [ NIL 3 [ [ NIL 7 NIL ] 8 [ NIL 12 NIL ] ] ] 17 [ [ NIL 24 NIL ] 26 [ NIL 32 [ [ NIL 34 [ NIL 37 NIL ] ] 45 [ NIL 50 NIL ] ] ] ] ]";

            // Act
            tree.Remove(42);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_04_Remove_05_OnNonEmptyTree_ElementWithRightChild32()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();
            string expected = "[ [ NIL 3 [ [ NIL 7 NIL ] 8 [ NIL 12 NIL ] ] ] 17 [ [ NIL 24 NIL ] 26 [ [ NIL 34 [ [ NIL 37 NIL ] 42 NIL ] ] 45 [ NIL 50 NIL ] ] ] ]";

            // Act
            tree.Remove(32);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_04_Remove_05_OnNonEmptyTree_ElementWithRightChild34()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();
            string expected = "[ [ NIL 3 [ [ NIL 7 NIL ] 8 [ NIL 12 NIL ] ] ] 17 [ [ NIL 24 NIL ] 26 [ NIL 32 [ [ [ NIL 37 NIL ] 42 NIL ] 45 [ NIL 50 NIL ] ] ] ] ]";

            // Act
            tree.Remove(34);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_04_Remove_06_OnNonEmptyTree_ElementWithBothChilds17()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();
            string expected = "[ [ NIL 3 [ [ NIL 7 NIL ] 8 [ NIL 12 NIL ] ] ] 24 [ NIL 26 [ NIL 32 [ [ NIL 34 [ [ NIL 37 NIL ] 42 NIL ] ] 45 [ NIL 50 NIL ] ] ] ] ]";

            // Act
            tree.Remove(17);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_04_Remove_06_OnNonEmptyTree_ElementWithBothChilds26()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();
            string expected = "[ [ NIL 3 [ [ NIL 7 NIL ] 8 [ NIL 12 NIL ] ] ] 17 [ [ NIL 24 NIL ] 32 [ [ NIL 34 [ [ NIL 37 NIL ] 42 NIL ] ] 45 [ NIL 50 NIL ] ] ] ]";

            // Act
            tree.Remove(26);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_04_Remove_06_OnNonEmptyTree_ElementWithBothChilds45()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();
            string expected = "[ [ NIL 3 [ [ NIL 7 NIL ] 8 [ NIL 12 NIL ] ] ] 17 [ [ NIL 24 NIL ] 26 [ NIL 32 [ [ NIL 34 [ [ NIL 37 NIL ] 42 NIL ] ] 50 NIL ] ] ] ]";

            // Act
            tree.Remove(45);
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BinarySearchTree_05_ToString_01_OnEmptyTree()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntEmpty();
            string expected = "";

            // Act
            string actual = tree.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinarySearchTree_05_ToString_02_OnSmallTree()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntSmall();
            string expected = "2 4 5 6 7";

            // Act
            string actual = tree.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinarySearchTree_05_ToString_03_OnModerateTree()
        {
            // Arrange
            IBinarySearchTree<int> tree = DSBuilder.CreateBinarySearchTreeIntModerate();
            string expected = "3 7 8 12 17 24 26 32 34 37 42 45 50";

            // Act
            string actual = tree.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
