namespace AD
{
	public partial interface IMyStack<T>
	{
        bool IsEmpty();
		void Push(T data);
		T Top();
		T Pop();
	}

    public class MyStackEmptyException : System.Exception
    {
    }

}
