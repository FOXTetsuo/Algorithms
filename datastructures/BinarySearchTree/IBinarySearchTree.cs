namespace AD
{
    public partial interface IBinarySearchTree<T> : IBinaryTree<T>
        where T : System.IComparable<T>
    {
        void Insert(T x);
        T FindMin();
        void RemoveMin();
        void Remove(T x);
        string InOrder();
    }

    public class BinarySearchTreeElementNotFoundException : System.Exception
    {
        // Is thrown when Remove gets parameter that is not in the tree
    }
    public class BinarySearchTreeEmptyException : System.Exception
    {
        // Is thrown when RemoveMin or FindMin is called on empty tree
    }
    public class BinarySearchTreeDoubleKeyException : System.Exception
    {
        // Is thrown when same element is inserted twice
    }
}