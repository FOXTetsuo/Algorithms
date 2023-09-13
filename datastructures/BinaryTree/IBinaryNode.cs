namespace AD
{
    public partial interface IBinaryNode<T>
    {
        //----------------------------------------------------------------------
        // Methods that have to be implemented for exam
        //----------------------------------------------------------------------
        T GetData();
        BinaryNode<T> GetLeft();
        BinaryNode<T> GetRight();
    }
}