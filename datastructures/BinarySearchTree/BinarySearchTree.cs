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
                // If node.left is null, that means we have found where we need to be inserted. There is no smaller node.
                // Because X is smaller than the current node, we insert on the left.
                if (node.GetLeft() == null)
                    node.left = new BinaryNode<T>(x, null, null);
                else
                // Otherwise, keep going!
                    Insert(x, node.GetLeft());
            }
            else if (x.CompareTo(node.GetData()) > 0)
            {
                // If node.right is null, that means we have found where we need to be inserted. There is no larger node.
                // Because X is larger than the current node, we insert on the right.
                if (node.GetRight() == null)
                    node.right = new BinaryNode<T>(x, null, null);
                else
                    Insert(x, node.GetRight());
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
            if (IsEmpty())
                throw new BinarySearchTreeEmptyException();
            
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
            if (IsEmpty())
                throw new BinarySearchTreeEmptyException();
            if (GetRoot().GetLeft() == null && GetRoot().GetRight() == null)
            {
                root = null;
                return;
            }
                
            RemoveMin(GetRoot());
        }

        // Method to remove min item from a (sub)tree. Returns the new root.
        public BinaryNode<T> RemoveMin(BinaryNode<T> node)
        {
            if (node == null)
                throw new BinarySearchTreeElementNotFoundException();

            // If the left node is null, we have found the min. Thus, the new root is either the node on the right if it exists
            // or null if there is no node on the right.
            if (node.left == null)
                return node.right;
            
            // Left node not found, so keep going.
            node.left = RemoveMin(node.left);
            
            return node;
        }

        // Oude verkeerde cod, wel heel benieuwd wat ik fout heb gedaan
        // public void Remove(T x, BinaryNode<T> node)
        // {
        //     // X is smaller
        //     if (x.CompareTo(nodeData) < 0)
        //     {
        //         Remove(x, nodeLeft);
        //     }
        //     // X is larger
        //     else if (x.CompareTo(nodeData) > 0)
        //     {
        //         Remove(x, nodeRight);
        //     }
        //     // X is equal (node to remove)
        //     else if (x.CompareTo(node.GetData()) == 0)
        //     {
        //         // Easy peasy, the node has no kids.
        //         if (nodeLeft == null && nodeRight == null)
        //         {
        //             node = null;
        //         }
        //         // Only one child, just move it up one
        //         else if (nodeLeft == null && nodeRight != null)
        //         {
        //             node = nodeRight;
        //         }
        //         else if (nodeLeft != null && nodeRight == null)
        //         {
        //             node = nodeLeft;
        //         }
        //         // Now time for the hard part. The node has two children.
        //         else
        //         {
        //             node.data = FindMin(nodeRight);
        //             node.right = RemoveMin(nodeRight);
        //         }
        //     }
        // }
        
        public BinaryNode<T> Remove(T x, BinaryNode<T> node)
        {
            if (node == null)
            {
                throw new BinarySearchTreeElementNotFoundException();
            }

            var nodeData = node.GetData();

            // X is smaller
            if (x.CompareTo(nodeData) < 0)
            {
                node.left = Remove(x, node.left);
            }
            // X is larger
            else if (x.CompareTo(nodeData) > 0)
            {
                node.right = Remove(x, node.right);
            }
            // X is equal (node to remove)
            else
            {
                // Easy peasy, the node has no kids or just 1.
                // If the left is null. that means we can just return right. if right is also null, well, that's still correct!
                if (node.left == null)
                {
                    return node.right;
                }
                if (node.right == null)
                {
                    return node.left;
                }

                // Node with two children, get the smallest in the right subtree
                node.data = FindMin(node.right);

                // Delete the inorder successor
                node.right = Remove(node.data, node.right);
            }
            return node;
        }
        
        public void Remove(T x)
        {
            root = GetRoot();
            if (root == null)
            {
                throw new BinarySearchTreeElementNotFoundException();
            }

            if (x.CompareTo(root.GetData()) == 0 && root.GetLeft() == null && root.GetRight() == null)
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
            return ToString(node.GetLeft()) + node.GetData() + " " + ToString(node.GetRight());
        }

        public override string ToString()
        {
            if (GetRoot() == null)
                return "";
            return ToString(GetRoot()).TrimStart().TrimEnd();
        }
    }
}
