using System;

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
            root = null;
        }

        public BinaryTree(T rootItem)
        {
            this.root = new BinaryNode<T>(rootItem, null, null);
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public BinaryNode<T> GetRoot()
        {
            return root;
        }

        public int Size()
        {
            if (IsEmpty())
                return 0;
            // Call a recursive helper function starting from the root
            return Size(GetRoot());
        }

        private int Size(AD.BinaryNode<T> node)
        {
            if (node == null)
                return 0;

            int leftSize = Size(node.GetLeft());
            int rightSize = Size(node.GetRight());

            // Add 1 for the current node
            return 1 + leftSize + rightSize;
        }

        public int Height()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return Height(GetRoot())-1;
        }

        public int Height(IBinaryNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftHeight = Height(node.GetLeft());
            int rightHeight = Height(node.GetRight());

            return 1 + Math.Max(leftHeight, rightHeight);
        }

        public void MakeEmpty()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return (root == null);
        }

        public void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
        {
            // Create a new binary tree with rootItem as the root.
            this.root = new BinaryNode<T>(rootItem, null, null);

            // Attach the left subtree from t1 to the new tree.
            if (t1 != null)
                GetRoot().left = t1.GetRoot();

            // Attach the right subtree from t2 to the new tree.
            if (t2 != null)
                GetRoot().right = t2.GetRoot();

            // Optionally, you may want to empty t1 and t2 to release their resources
            // since their subtrees have been transferred to the new tree.
            t1.MakeEmpty();
            t2.MakeEmpty();
        }


        public string ToPrefixString()
        {
            if (IsEmpty())
                return ("NIL");
            return "";
        }

        public string ToInfixString()
        {
            if (IsEmpty())
                return ("NIL");
            return "";
        }

        public string ToPostfixString()
        {
            if (IsEmpty())
                return ("NIL");
            return "";
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public int NumberOfLeaves()
        {
            return NumberOfLeaves(root);
        }
        
        public int NumberOfLeaves(IBinaryNode<T> node)
        {
            if (node == null)
                return 0;

            if (node.GetRight() == null && node.GetLeft() == null)
                return 1;

            int leftLeaves = NumberOfLeaves(node.GetLeft());
            int rightLeaves = NumberOfLeaves(node.GetRight());

            return leftLeaves + rightLeaves;
        }

        public int NumberOfNodesWithOneChild()
        {
            return NumberOfNodesWithOneChild(root);
        }

        public int NumberOfNodesWithOneChild(IBinaryNode<T> node)
        {
            if (node == null || (node.GetRight() == null && node.GetLeft() == null))
                return 0;

            if (node.GetRight() == null && node.GetLeft() != null)
                return 1 + NumberOfNodesWithOneChild(node.GetLeft());
            if (node.GetLeft() == null && node.GetRight() != null)
                return 1 + NumberOfNodesWithOneChild(node.GetRight());

            int leftCount = NumberOfNodesWithOneChild(node.GetLeft());
            int rightCount = NumberOfNodesWithOneChild(node.GetRight());

            return leftCount + rightCount;
        }

        
        // if (node.GetRight() == null && node.GetLeft() != null)
        // return 1 + NumberOfNodesWithOneChild(node.GetLeft());
        //     if (node.GetLeft() == null && node.GetRight() != null)
        // return 1 + NumberOfNodesWithOneChild(node.GetRight());

        public int NumberOfNodesWithTwoChildren()
        {
            return NumberOfNodesWithTwoChildren(root);
        }

        public int NumberOfNodesWithTwoChildren(IBinaryNode<T> node)
        {
            if (node == null)
                return 0;

            int leftCount = NumberOfNodesWithTwoChildren(node.GetLeft());
            int rightCount = NumberOfNodesWithTwoChildren(node.GetRight());

            // Check if both children are present
            if (node.GetLeft() != null && node.GetRight() != null)
                return 1 + leftCount + rightCount;
            else
                return leftCount + rightCount;
        }

    }
}