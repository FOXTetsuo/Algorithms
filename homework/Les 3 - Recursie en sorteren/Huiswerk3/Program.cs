namespace AD
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n=====   Opgave 1 : Faculteit   =====\n");
            Opgave1.Run();

            System.Console.WriteLine("\n=====   Opgave 2 : Fibonacci   =====\n");
            Opgave2.Run();

            System.Console.WriteLine("\n=====   Opgave 3 : OmEnOm   =====\n");
            Opgave3.Run();

            System.Console.WriteLine("\n=====   Opgave 4 : Enen   =====\n");
            Opgave4.Run();

            System.Console.WriteLine("\n=====   Opgave 6 : ForwardString   =====\n");
            Opgave6.Run();

            System.Console.WriteLine("\n=====   Opgave 7 : Sorting   =====\n");
            Sorter isort = new InsertionSort();
            Sorter msort = new MergeSort();
            Sorter ssort = new ShellSort();
            isort.Run();
            msort.Run();
            ssort.Run();
            int[] numbers = {100, 1000, 10000};
            foreach (int num in numbers)
            {
                isort.RunWithTimer(num);
                msort.RunWithTimer(num);
                ssort.RunWithTimer(num);
            }
        }
    }
}
