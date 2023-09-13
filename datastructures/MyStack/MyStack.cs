namespace AD
{
    public partial class MyStack<T> : IMyStack<T>
    {
        public MyLinkedList<T> list = new MyLinkedList<T>();
        public bool IsEmpty()
        {
            throw new System.NotImplementedException();
        }

        public T Pop()
        {
            throw new System.NotImplementedException();
        }

        public void Push(T data)
        {
            throw new System.NotImplementedException();
        }

        public T Top()
        {
            throw new System.NotImplementedException();
        }
    }
}
