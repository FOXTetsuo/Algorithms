using NUnit.Framework;


namespace AD
{
    [TestFixture]
    public partial class FirstChildNextSiblingTests
    {
        [Test]
        public void FirstChildNextSibling_1_Constructor_1_SizeReturnsProperResult()
        {
            // Arrange
            IFirstChildNextSibling<string> tree = DSBuilder.CreateFirstChildNextSibling_Empty();
            int expected = 0;

            // Act
            int actual = tree.Size();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FirstChildNextSibling_1_Constructor_2_ToStringReturnsProperResult()
        {
            // Arrange
            IFirstChildNextSibling<string> tree = DSBuilder.CreateFirstChildNextSibling_Empty();
            string expected = "NIL";

            // Act
            string actual = tree.ToString();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FirstChildNextSibling_2_SmallTree_1_SizeReturnsProperResult()
        {
            // Arrange
            IFirstChildNextSibling<string> tree = DSBuilder.CreateFirstChildNextSibling_Small();
            int expected = 5;

            // Act
            int actual = tree.Size();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FirstChildNextSibling_2_SmallTree_2_ToStringReturnsProperResult()
        {
            // Arrange
            IFirstChildNextSibling<string> tree = DSBuilder.CreateFirstChildNextSibling_Small();
            string expected = "a,FC(b,FC(e),NS(c,NS(d)))";

            // Act
            string actual = tree.ToString();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FirstChildNextSibling_3_BigTree_1_SizeReturnsProperResult()
        {
            // Arrange
            IFirstChildNextSibling<string> tree = DSBuilder.CreateFirstChildNextSibling_18_3();
            int expected = 11;

            // Act
            int actual = tree.Size();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FirstChildNextSibling_3_BigTree_2_ToStringReturnsProperResult()
        {
            // Arrange
            IFirstChildNextSibling<string> tree = DSBuilder.CreateFirstChildNextSibling_18_3();
            string expected = "a,FC(b,FC(f,NS(g)),NS(c,NS(d,FC(h),NS(e,FC(i,NS(j,FC(k)))))))";

            // Act
            string actual = tree.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}