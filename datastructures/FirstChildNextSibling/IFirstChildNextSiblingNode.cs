namespace AD
{
    public partial interface IFirstChildNextSiblingNode<T>
    {
        T GetData();
        FirstChildNextSiblingNode<T> GetFirstChild();
        FirstChildNextSiblingNode<T> GetNextSibling();
    }
}