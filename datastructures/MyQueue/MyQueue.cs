using System.Collections.Generic;
using System.Drawing;

namespace AD
{
    public partial class MyQueue<T> : IMyQueue<T>
    {
        public MyLinkedList<T> list = new MyLinkedList<T>();
        public bool IsEmpty()
        {
            return (list.Size() == 0);
        }

        public void Enqueue(T data)
        {
            list.AddLast(data);
        }

        public T GetFront()
        {
            if (IsEmpty())
            {
                throw new MyQueueEmptyException();
            }
            return list.GetFirst();
        }

        public T Dequeue()
        {
            var data = GetFront();
            list.RemoveFirst();
            return data;
        }

        public void Clear()
        {
            list = new MyLinkedList<T>();
        }

    }
}