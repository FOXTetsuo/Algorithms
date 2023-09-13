namespace AD
{
    public partial class BinarySearchTree<T> : BinaryTree<T>, IBinarySearchTree<T>
        where T : System.IComparable<T>
    {

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public void Insert(T x)
        {
            throw new System.NotImplementedException();
        }

        public T FindMin()

        {
            throw new System.NotImplementedException();
        }

        public void RemoveMin()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(T x)
        {
            throw new System.NotImplementedException();
        }

        public string InOrder()
        {
            throw new System.NotImplementedException();
        }
    }
}
