using System.Collections.Generic;
using System.Diagnostics;

namespace AD
{
    public abstract partial class Sorter
    {
        public abstract void Sort(List<int> list);

        public long SortWithTimer(List<int> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Sort(list);
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        public void Run()
        {
            List<int> list = new List<int>(new int[] { 3, 7, 6, 4, 1, 2, 8, 5 });
            Sort(list);
            System.Console.Write("{0,14} : ", GetType().Name);
            foreach (int x in list)
                System.Console.Write(x + " ");
            System.Console.WriteLine();
        }

        public void RunWithTimer(int num)
        {
            List<int> list = new List<int>();
            System.Random random = new System.Random();
            for (int i = 0; i < num; i++)
                list.Add(random.Next(0, 1000000));
            long t = SortWithTimer(list);
            System.Console.WriteLine("{0,14} : {1,6} numbers : {2,8} ticks", GetType().Name, num, t);
        }

    }
}
