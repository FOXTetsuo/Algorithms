namespace AD
{
    public partial interface IMyQueue<T>
    {
        bool IsEmpty();
        void Enqueue(T data);
        T GetFront();
        T Dequeue();
        void Clear();
    }

    public class MyQueueEmptyException : System.Exception
    {
    }
}