using System.Data.Common;

namespace AD
{
    public partial class MyLinkedList<T> : IMyLinkedList<T>
    {
        public MyLinkedListNode<T> first;
        public MyLinkedListNode<T> last;
        private int size;

        public MyLinkedList()
        {
            first = null;
            last = null;
            size = 0;
        }

        // O(1)
        public void AddFirst(T data)
        {
            MyLinkedListNode<T> newFirst = new MyLinkedListNode<T>(data, first);
            first = newFirst;

            if (Size() == 0)
            {
                last = newFirst;
            }
            
            size++;
        }

        // O(1)
        public void AddLast(T data)
        {
            MyLinkedListNode<T> newLast = new MyLinkedListNode<T>(data, null);
            
            if (Size() == 0)
            {
                // If the list is empty, both 'first' and 'last' should point to the new node
                first = newLast;
                last = newLast; // Set 'last' to the new node
            }
            else
            {
                // Connect the previous 'last' node to the new node
                last.next = newLast;
                // Update 'last' reference to the new node
                last = newLast;
            }
            
            size++;
        }

        // O(1)
        public T GetFirst()
        {
            if (Size() > 0)
            {
                return first.data;
            }
            throw new MyLinkedListEmptyException();
        }

        // O(1)
        public void RemoveFirst()
        {
            if (Size() == 0)
            {
                throw new MyLinkedListEmptyException();
            }
            
            // Old First gets deleted by the garbage collector
            first = first.next;
            size--;
        }

        // O(1)
        public int Size()
        {
            return size;
        }

        // O(1)
        public void Clear()
        {
            first = null;
            size = 0;
        }

        // O(n)
        public void Insert(int index, T data)
        {
            // Out of bounds
            if (index > Size() || index < 0)
            {
                throw new MyLinkedListIndexOutOfRangeException();
            }
            
            // Empty
            else if (first == null)
            {
                var firstNode = new MyLinkedListNode<T>();
                firstNode.data = data;
                first = firstNode;
                size++;
                return;
            }
            
            // Insert at beginning
            if ( index == 0)
            {
                AddFirst(data);
                return;
            }
            
            // Normal insert
            var current = first;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }

            // Make the new node using the fancy constructor, and increase the size
            var newNode = new MyLinkedListNode<T>(data, current.next);
            current.next = newNode;
            size++;
        }

        // O(n)
        public override string ToString()
        {
            string returnstring = "";
            if (Size() == 0)
            {
                return "NIL";
            }

            if (Size() == 1)
            {
                return $"[{GetFirst()}]";
            }
            
            // Loop over all of the nodes
            var current = first;
            for (int i = 0; i < Size(); i++)
            {
                returnstring += current.data + ",";
                current = current.next;
            }
            
            // Remove the final comma (I'm lazy)
            return "[" + returnstring.Remove(returnstring.Length-1) + "]";
        }
    }
}