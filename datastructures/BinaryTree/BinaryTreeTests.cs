using NUnit.Framework;


namespace AD
{
    [TestFixture]
    public partial class BinaryTreeTests
    {
        [Test]
        public void BinaryTree_01_GetRoot_1_OnEmptyTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeEmpty();
            BinaryNode<int> expected = null;

            // Act
            BinaryNode<int> actual = tree.GetRoot();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_01_GetRoot_2_OnIntTree_1_NotNull()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            BinaryNode<int> not_expected = null;

            // Act
            BinaryNode<int> actual = tree.GetRoot();

            // Assert
            Assert.AreNotEqual(not_expected, actual);
        }
        [Test]
        public void BinaryTree_01_GetRoot_2_OnIntTree_2_DataCorrect()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            int expected = 5;

            // Act
            int actual = tree.GetRoot().data;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_01_GetRoot_3_OnStringTree_1_NotNull()
        {
            // Arrange
            IBinaryTree<string> tree = DSBuilder.CreateBinaryTreeString();
            BinaryNode<string> not_expected = null;

            // Act
            BinaryNode<string> actual = tree.GetRoot();

            // Assert
            Assert.AreNotEqual(not_expected, actual);
        }
        [Test]
        public void BinaryTree_01_GetRoot_3_OnStringTree_2_DataCorrect()
        {
            // Arrange
            IBinaryTree<string> tree = DSBuilder.CreateBinaryTreeString();
            string expected = "t";

            // Act
            string actual = tree.GetRoot().data;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_02_Size_1_OnEmptyTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeEmpty();
            int expected = 0;

            // Act
            int actual = tree.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_02_Size_2_OnIntTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            int expected = 6;

            // Act
            int actual = tree.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_02_Size_3_OnStringTree()
        {
            // Arrange
            IBinaryTree<string> tree = DSBuilder.CreateBinaryTreeString();
            int expected = 7;

            // Act
            int actual = tree.Size();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_03_Height_1_OnEmptyTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeEmpty();
            int expected = -1;

            // Act
            int actual = tree.Height();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_03_Height_2_OnIntTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            int expected = 3;

            // Act
            int actual = tree.Height();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_03_Height_3_OnStringTree()
        {
            // Arrange
            IBinaryTree<string> tree = DSBuilder.CreateBinaryTreeString();
            int expected = 2;

            // Act
            int actual = tree.Height();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_03_MakeEmpty_GetRootIsNullAfterMakeEmpty()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            BinaryNode<int> expected = null;

            // Act
            tree.MakeEmpty();
            BinaryNode<int> actual = tree.GetRoot();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_04_IsEmpty_1_OnEmptyTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeEmpty();
            bool expected = true;

            // Act
            bool actual = tree.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_04_IsEmpty_2_OnIntTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            bool expected = false;

            // Act
            bool actual = tree.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_04_IsEmpty_3_OnStringTree()
        {
            // Arrange
            IBinaryTree<string> tree = DSBuilder.CreateBinaryTreeString();
            bool expected = false;

            // Act
            bool actual = tree.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_04_IsEmpty_4_AfterMakeClean()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            bool expected = true;
            tree.MakeEmpty();

            // Act
            bool actual = tree.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_05_ToPrefixString_1_OnEmptyTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeEmpty();
            string expected = "NIL";

            // Act
            string actual = tree.ToPrefixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_05_ToPrefixString_2_OnIntTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            string expected = "[ 5 [ 2 [ 8 NIL NIL ] [ 7 [ 1 NIL NIL ] NIL ] ] [ 6 NIL NIL ] ]";

            // Act
            string actual = tree.ToPrefixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_05_ToPrefixString_3_OnStringTree()
        {
            // Arrange
            IBinaryTree<string> tree = DSBuilder.CreateBinaryTreeString();
            string expected = "[ t [ w [ q NIL NIL ] [ g NIL NIL ] ] [ a [ o NIL NIL ] [ p NIL NIL ] ] ]";

            // Act
            string actual = tree.ToPrefixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_06_ToInfixString_1_OnEmptyTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeEmpty();
            string expected = "NIL";

            // Act
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_06_ToInfixString_2_OnIntTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            string expected = "[ [ [ NIL 8 NIL ] 2 [ [ NIL 1 NIL ] 7 NIL ] ] 5 [ NIL 6 NIL ] ]";

            // Act
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_06_ToInfixString_3_OnStringTree()
        {
            // Arrange
            IBinaryTree<string> tree = DSBuilder.CreateBinaryTreeString();
            string expected = "[ [ [ NIL q NIL ] w [ NIL g NIL ] ] t [ [ NIL o NIL ] a [ NIL p NIL ] ] ]";

            // Act
            string actual = tree.ToInfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_07_ToPostfixString_1_OnEmptyTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeEmpty();
            string expected = "NIL";

            // Act
            string actual = tree.ToPostfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_07_ToPostfixString_2_OnIntTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            string expected = "[ [ [ NIL NIL 8 ] [ [ NIL NIL 1 ] NIL 7 ] 2 ] [ NIL NIL 6 ] 5 ]";

            // Act
            string actual = tree.ToPostfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_07_ToPostfixString_3_OnStringTree()
        {
            // Arrange
            IBinaryTree<string> tree = DSBuilder.CreateBinaryTreeString();
            string expected = "[ [ [ NIL NIL q ] [ NIL NIL g ] w ] [ [ NIL NIL o ] [ NIL NIL p ] a ] t ]";

            // Act
            string actual = tree.ToPostfixString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
