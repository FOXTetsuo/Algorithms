namespace AD
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public partial class DSBuilder
    {
        public static IMyQueue<string> CreateMyQueueStringEmpty()
        {
            return new MyQueue<string>();
        }
        public static IMyQueue<int> CreateMyQueueIntEmpty()
        {
            return new MyQueue<int>();
        }
    }
}
