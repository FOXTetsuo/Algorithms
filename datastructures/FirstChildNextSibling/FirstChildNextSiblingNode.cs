namespace AD
{
    public partial class FirstChildNextSiblingNode<T> : IFirstChildNextSiblingNode<T>
    {
        public FirstChildNextSiblingNode<T> firstChild;
        public FirstChildNextSiblingNode<T> nextSibling;
        public T data;

        public FirstChildNextSiblingNode(T data, FirstChildNextSiblingNode<T> firstChild, FirstChildNextSiblingNode<T> nextSibling)
        {
            throw new System.NotImplementedException();
        }

        public FirstChildNextSiblingNode(T data)
        {
            throw new System.NotImplementedException();
        }

        public T GetData()
        {
            throw new System.NotImplementedException();
        }

        public FirstChildNextSiblingNode<T> GetFirstChild()
        {
            throw new System.NotImplementedException();
        }

        public FirstChildNextSiblingNode<T> GetNextSibling()
        {
            throw new System.NotImplementedException();
        }
    }
}