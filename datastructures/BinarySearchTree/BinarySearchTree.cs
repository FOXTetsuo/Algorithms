using System.Data.Common;
using System.Security.Cryptography;

namespace AD
{
    public partial class BinarySearchTree<T> : BinaryTree<T>, IBinarySearchTree<T>
        where T : System.IComparable<T>
    {

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public void Insert(T x, BinaryNode<T> node)
        {
            if (x.CompareTo(node.GetData()) < 0)
            {
                // If node.right is null, that means we have found where we need to be inserted. There is no larger node.
                if (node.GetRight() == null)
                    node.right = new BinaryNode<T>(x, null, null);
                else
                // Otherwise, keep going!
                    Insert(x, node.GetRight());
            }
            else if (x.CompareTo(node.GetData()) > 0)
            {
                if (node.GetLeft() == null)
                    node.left = new BinaryNode<T>(x, null, null);
                else
                    Insert(x, node.GetLeft());
            }
        }
    
        public void Insert(T x)
        {
            root = GetRoot();
            if (root == null)
            {
                root = new BinaryNode<T>(x, null, null);
                return;
            }
            Insert(x, root);
        }

        // Just keep going left
        public T FindMin(BinaryNode<T> node)
        {
            if (node.left != null)
            {
                return FindMin(node.left);
            }

            return node.GetData();
        }

        public T FindMin()
        {
            root = GetRoot();
            return FindMin(root);
        }
        
        // Just keep going right
        public T FindMax(BinaryNode<T> node)
        {
            if (node.right != null)
            {
                return FindMin(node.right);
            }

            return node.GetData();
        }

        public T FindMax()
        {
            root = GetRoot();
            return FindMin(root);
        }
        
        public void RemoveMin()
        {
            throw new System.NotImplementedException();
        }

        // Method to remove min item from a (sub)tree. Returns the new root.
        public BinaryNode<T> RemoveMin(BinaryNode<T> node)
        {
            if (node == null)
                throw new BinarySearchTreeElementNotFoundException();
            if (node.GetLeft() != null)
            {
                node.left = RemoveMin(node.left);
                return node;
            }
            return node.right;
        }

        public void Remove(T x, BinaryNode<T> node)
        {
            var nodeData = node.GetData();
            var nodeLeft = node.GetLeft();
            var nodeRight = node.GetRight();
            // X is smaller
            if (x.CompareTo(nodeData) > 0)
            {
                Remove(x, nodeLeft);
            }
            // X is larger
            else if (x.CompareTo(nodeData) < 0)
            {
                Remove(x, nodeRight);
            }
            // X is equal (node to remove)
            else if (x.CompareTo(node.GetData()) == 0)
            {
                // Easy peasy, the node has no kids.
                if (nodeLeft == null && nodeRight == null)
                {
                    node = null;
                }
                // Only one child, just move it up one
                else if (nodeLeft == null && nodeRight != null)
                {
                    node = nodeRight;
                }
                else if (nodeLeft != null && nodeRight == null)
                {
                    node = nodeLeft;
                }
                // Now time for the hard part. The node has two children.
                else
                {
                    node.data = FindMin(nodeRight);
                    node.right = RemoveMin(nodeRight);
                }
            }
        }
    
        public void Remove(T x)
        {
            root = GetRoot();
            if (root == null)
            {
                return;
            }

            if (x.CompareTo(root.GetData()) == 0)
            {
                root = null;
                return;
            }
            
            Remove(x, root);
        }

        public string InOrder()
        {
            throw new System.NotImplementedException();
        }

        public string ToString(BinaryNode<T> node)
        {
            if (node == null) return "";
            // Recursively print the binary search tree
            return ToString(node.GetRight()) + " " + node.GetData() + " " + ToString(node.GetLeft());
        }

        public override string ToString()
        {
            if (GetRoot() == null)
                return "NIL";
            return ToString(GetRoot());
        }
    }
}
