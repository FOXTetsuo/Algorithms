using NUnit.Framework;


namespace AD
{
    [TestFixture]
    public partial class BinaryTreeTests
    {
        [Test]
        public void BinaryTree_08_NumberOfLeaves_1_OnEmptyTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeEmpty();
            int expected = 0;

            // Act
            int actual = tree.NumberOfLeaves();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_08_NumberOfLeaves_2_OnIntTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            int expected = 3;

            // Act
            int actual = tree.NumberOfLeaves();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_08_NumberOfLeaves_3_OnStringTree()
        {
            // Arrange
            IBinaryTree<string> tree = DSBuilder.CreateBinaryTreeString();
            int expected = 4;

            // Act
            int actual = tree.NumberOfLeaves();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_09_NumberOfNodesWithOneChild_1_OnEmptyTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeEmpty();
            int expected = 0;

            // Act
            int actual = tree.NumberOfNodesWithOneChild();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_09_NumberOfNodesWithOneChild_2_OnIntTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            int expected = 1;

            // Act
            int actual = tree.NumberOfNodesWithOneChild();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_09_NumberOfNodesWithOneChild_3_OnStringTree()
        {
            // Arrange
            IBinaryTree<string> tree = DSBuilder.CreateBinaryTreeString();
            int expected = 0;

            // Act
            int actual = tree.NumberOfNodesWithOneChild();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_10_NumberOfNodesWithTwoChildren_1_OnEmptyTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeEmpty();
            int expected = 0;

            // Act
            int actual = tree.NumberOfNodesWithTwoChildren();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_10_NumberOfNodesWithTwoChildren_2_OnIntTree()
        {
            // Arrange
            IBinaryTree<int> tree = DSBuilder.CreateBinaryTreeInt();
            int expected = 2;

            // Act
            int actual = tree.NumberOfNodesWithTwoChildren();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void BinaryTree_10_NumberOfNodesWithTwoChildren_3_OnStringTree()
        {
            // Arrange
            IBinaryTree<string> tree = DSBuilder.CreateBinaryTreeString();
            int expected = 3;

            // Act
            int actual = tree.NumberOfNodesWithTwoChildren();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}