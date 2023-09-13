namespace AD
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public partial class DSBuilder
    {
        public static IMyArrayList CreateMyArrayList5()
        {
            return new MyArrayList(5);
        }
    }
}
