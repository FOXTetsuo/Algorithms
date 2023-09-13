namespace AD
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public partial class DSBuilder
    {
        public static Sorter CreateInsertionSorter()
        {
            return new InsertionSort();
        }

        public static Sorter CreateMergeSorter()
        {
            return new MergeSort();
        }

        public static Sorter CreateShellSorter()
        {
            return new ShellSort();
        }

        public static Sorter CreateQuickSorter()
        {
            return new QuickSort();
        }

        public static Sorter CreateSorter(string sorterName)
        {
            if (sorterName == "InsertionSort")
                return CreateInsertionSorter();
            else if (sorterName == "MergeSort")
                return CreateMergeSorter();
            else if (sorterName == "ShellSort")
                return CreateShellSorter();
            else if (sorterName == "QuickSort")
                return CreateQuickSorter();
            else
                return null;
        }
    }
}
