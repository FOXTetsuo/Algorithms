namespace AD
{
    public partial class BinaryTree<T> : IBinaryTree<T>
    {
        public BinaryNode<T> root;

        //----------------------------------------------------------------------
        // Constructors
        //----------------------------------------------------------------------

        public BinaryTree()
        {
            throw new System.NotImplementedException();
        }

        public BinaryTree(T rootItem)
        {
            throw new System.NotImplementedException();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public BinaryNode<T> GetRoot()
        {
            throw new System.NotImplementedException();
        }

        public int Size()
        {
            throw new System.NotImplementedException();
        }

        public int Height()
        {
            throw new System.NotImplementedException();
        }

        public void MakeEmpty()
        {
            throw new System.NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new System.NotImplementedException();
        }

        public void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
        {
            throw new System.NotImplementedException();
        }

        public string ToPrefixString()
        {
            throw new System.NotImplementedException();
        }

        public string ToInfixString()
        {
            throw new System.NotImplementedException();
        }

        public string ToPostfixString()
        {
            throw new System.NotImplementedException();
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public int NumberOfLeaves()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfNodesWithOneChild()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfNodesWithTwoChildren()
        {
            throw new System.NotImplementedException();
        }
    }
}