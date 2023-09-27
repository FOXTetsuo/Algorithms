using System;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace AD
{
    public partial class FirstChildNextSibling<T> : IFirstChildNextSibling<T>
    {
        public FirstChildNextSiblingNode<T> root;

        public IFirstChildNextSiblingNode<T> GetRoot()
        {
            return root;
        }

        public int Size()
        {
            // Call a recursive helper function starting from the root
            return Size(GetRoot());
        }

        private int Size(IFirstChildNextSiblingNode<T> node)
        {
            if (node == null)
                return 0;

            int leftSize = CountNodes(node.GetFirstChild());
            int rightSize = CountNodes(node.GetNextSibling());

            // Add 1 for the current node
            return 1 + leftSize + rightSize;
        }
        
        public void PrintPreOrder(IFirstChildNextSiblingNode<T> node, int depth)
        {
            if (node == null)
            {
                return;
            }

            for (int i = 0; i < depth; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(node.GetData());
            PrintPreOrder(node.GetFirstChild(), 3 + depth);
            PrintPreOrder(node.GetNextSibling(), depth);
        }

        public void PrintPreOrder()
        {
            PrintPreOrder(GetRoot(), 0);
        }

    }
}