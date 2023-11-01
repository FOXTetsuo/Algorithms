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
        
        public BinaryNode<T> FindMinNode(BinaryNode<T> node)
        {
            if (node.left != null)
            {
                return FindMinNode(node.left);
            }

            return node;
        }

        public BinaryNode<T> FindMinNode()
        {
            if (IsEmpty())
                throw new BinarySearchTreeEmptyException();
            
            root = GetRoot();
            return FindMinNode(root);
        }

        public T FindSecondToMin()
        {
            var smallestElement = FindMinNode();
            
            // We need SOME kind of element here.
            BinaryNode<T> smallestInSubtree = GetRoot();

            // If the subtree is empty, just ignore it
            if (smallestElement.GetRight() != null)
            {
                return FindMinNode(smallestElement.GetRight()).data;
            }
            
            var node = GetRoot();
            var nodeLeftData = node.GetLeft().GetData();
            var nodeRightData = node.GetRight().GetData();
            
            // Parent als rechts null is
            // Kleinste in rechter subboom als die dat niet is
            while (nodeLeftData.CompareTo(smallestElement.data) != 0 && nodeRightData.CompareTo(smallestElement.data) != 0)
                {
                    if (node.GetLeft() != null)
                        node = node.GetLeft();
                    else node = node.GetRight();
                    
                    nodeLeftData = node.GetLeft().GetData();
                    nodeRightData = node.GetRight().GetData();
                }

            return node.GetData();
        }

        public T FindSecondToMinSimple()
        {
            BinaryNode<T> current = GetRoot();
            BinaryNode<T> prev = null;

            // Traverse the tree to find the second smallest element
            while (current != null && current.GetLeft() != null)
            {
                prev = current;
                current = current.GetLeft();
            }

            // If there is no left subtree, the smallest element is the root, return its right child
            if (current == null)
            {
                if (GetRoot().GetRight() != null)
                {
                    return GetRoot().GetRight().GetData();
                }
                else
                {
                    // Handle the case where there's no right child, you may want to define the behavior
                    return default(T); // Replace with an appropriate default value or throw an exception.
                }
            }

            // If the smallest element has a right subtree, find the minimum in that subtree
            if (current.GetRight() != null)
            {
                return FindMinNode(current.GetRight()).GetData();
            }

            // If the smallest element has no right subtree, return its parent (prev) data
            return prev.GetData();
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
