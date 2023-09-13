namespace AD
{
    public partial interface IFirstChildNextSibling<T>
    {
        IFirstChildNextSiblingNode<T> GetRoot();
        int Size();
        void PrintPreOrder();
    }
}
