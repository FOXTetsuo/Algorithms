namespace AD
{
    public partial interface IBinaryTree<T>
    {
        //----------------------------------------------------------------------
        // Methods that have to be implemented for exam
        //----------------------------------------------------------------------
        BinaryNode<T> GetRoot();
        int Size();
        int Height();

        void MakeEmpty();
        bool IsEmpty();
        void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2);

        string ToPrefixString();
        string ToInfixString();
        string ToPostfixString();

        //----------------------------------------------------------------------
        // Methods that have to be implemented for homework
        //----------------------------------------------------------------------
        int NumberOfLeaves();
        int NumberOfNodesWithOneChild();
        int NumberOfNodesWithTwoChildren();
    }
}