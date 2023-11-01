using System;
using System.Collections.Generic;


namespace AD
{
    public partial class PriorityQueue<T> : IPriorityQueue<T>
        where T : IComparable<T>
    {
        public static int DEFAULT_CAPACITY = 100;
        public int size;   // Number of elements in heap
        public T[] array;  // The heap array

        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------
        public PriorityQueue()
        {
            array = new T[DEFAULT_CAPACITY];
            size = 0;
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------
        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            array = new T[DEFAULT_CAPACITY];
            size = 0;
        }

        public void Add(T x)
        {
            if (Size() + 1 >= array.Length)
            {
                // Resize the array if it's full
                int newSize = array.Length * 2;
                T[] newArray = new T[newSize];
                Array.Copy(array, newArray, array.Length);
                array = newArray;
            }

            array[Size() + 1] = x;
            size += 1;
            PercolateUp();
        }

        // Removes the smallest item in the priority queue
        public T Remove()
        {
            if (array[1] == null || EqualityComparer<T>.Default.Equals(array[1], default(T)))
                throw new PriorityQueueEmptyException();
            
            var copyOfFirstIndex = array[1];
            array[1] = array[Size()];
            PercolateDown();
            array[Size()] = default(T);
            size--;

            return copyOfFirstIndex;
        }
        
        public void PercolateDown()
        {
            PercolateDown(1);
        }

        public void PercolateDown(int arrayIndex)
        {
            var leftChildIndex = arrayIndex * 2;
            var rightChildIndex = arrayIndex * 2 + 1;

            var smallest = 0;

            if (leftChildIndex <= Size() && array[leftChildIndex].CompareTo(array[arrayIndex]) < 0)
            {
                smallest = leftChildIndex;
            }
            else
            {
                smallest = arrayIndex;
            }
            if (rightChildIndex <= (Size()) && array[rightChildIndex].CompareTo(array[smallest]) < 0)
                smallest = rightChildIndex;
            
            if (smallest != arrayIndex)
            {
                Swap(arrayIndex, smallest);
                PercolateDown(smallest);
            }
        }

        public void PercolateUp()
        {
            PercolateUp(Size());
        }
        
        public void PercolateUp(int arrayIndex)
        {
            var parentIndex = arrayIndex / 2;

            // MAX CHECK NEEDED
            var parent = array[parentIndex];
            
            // otherwise, we compare the right with the index
            // If it is smaller, swap the two
            if (array[arrayIndex].CompareTo(parent) < 0)
            {
                Swap(parentIndex, arrayIndex);
                if (parentIndex > 1)
                    PercolateUp(parentIndex);
            }
        }

        public void Swap(int indexOfBiggerElement, int index)
        {
            T temp = array[index];
            array[index] = array[indexOfBiggerElement];
            array[indexOfBiggerElement] = temp;
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public void AddFreely(T x)
        {
            if (Size() + 1 >= array.Length)
            {
                // Resize the array if it's full
                int newSize = array.Length * 2;
                T[] newArray = new T[newSize];
                Array.Copy(array, newArray, array.Length);
                array = newArray;
            }

            array[Size() + 1] = x;
            size += 1;
        }

        public void BuildHeap()
        {
            for (int i = Size() / 2; i > 0; i--)
            {
                PercolateDown(i);
            }
        }

        public override string ToString()
        {
            if (Size() == 0)
                return "";
            var returnstring = "";
            for (int i = 1; i < Size() + 1; i++)
            {
                returnstring += array[i] + " ";
            }

            return returnstring.TrimEnd();
        }

        public bool isComplete()
        {
            for (int i = 1; i < Size(); i++)
            {
                if (array[i].CompareTo(default(T)) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool isMaxHeap()
        {
            for (int i = 1; i <= Size(); i++)
            {
                if (2 * i <= Size())
                {
                    if (array[i].CompareTo(array[2*i]) < 0)
                    {
                        return false;
                    }
                }
                
                if (2 * i + 1 <= Size())
                {
                    if (array[i].CompareTo(array[2*i+1]) < 0 )
                    {
                        return false;
                    }
                }
                
            }
            
            return true;
        }
    }
}
