namespace AD
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public partial class DSBuilder
    {
        public static IMyStack<string> CreateMyStackStringEmpty()
        {
            return new MyStack<string>();
        }
        public static IMyStack<int> CreateMyStackIntEmpty()
        {
            return new MyStack<int>();
        }
    }
}
