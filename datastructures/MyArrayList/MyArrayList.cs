using System;

namespace AD
{
    public partial class MyArrayList : IMyArrayList
    {
        private int[] data;
        private int size;

        public MyArrayList(int capacity)
        {
            data = new int[capacity];
			size = 0;
        }

        public void Add(int n)
        {
            if (Capacity() >= Size()+1)
            {
                data[size] = n;
                size++;
            }
            else throw new MyArrayListFullException();
        }

        public int Get(int index)
        {
            if (index >= Size() || index <= 0)
            {
                throw new MyArrayListIndexOutOfRangeException();
            }
            return data[index];
        }

        public void Set(int index, int n)
        {
            if (index >= Capacity()-1 || index <= 0)
            {
                throw new MyArrayListIndexOutOfRangeException();
            }
            data[index] = n;
        }

        public int Capacity()
        {
            return data.Length;
        }

        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            data = new int[Capacity()];
            size = 0;
        }

        public int CountOccurences(int n)
        {
            int occurrences = 0;
            foreach (var number in data)
            {
                if (number == n)
                {
                    occurrences++;
                }
            }

            return occurrences;
        }

        public override string ToString()
        {
            string returnstring = "";
            if (Size() == 0)
            {
                return "NIL";
            }

            if (Size() == 1)
            {
                return $"[{data[0]}]";
            }
            else
            {
                
                foreach (var number in data)
                {
                    returnstring += number.ToString() +",";
                }
            }

            return "[" + returnstring.Remove(returnstring.Length-1) + "]";
        }
    }
}
