using System.Collections.Generic;


namespace AD
{
    public partial class ShellSort : Sorter
    {
        private static InsertionSort _insertionSort = new();
        public override void Sort(List<int> list)
        {
            var increments = new List<int>();

            int inc = (int) (list.Count / 2.2);
            do
            {
                increments.Add(inc);
                inc = (int)(inc / 2.2);
            } while (inc > 1);

            foreach (var increment in increments)    
            {
                Sort(list, 0, increment);
            }

            new InsertionSort().Sort(list);
        }
        
        private void Sort(List<int> list, int start, int increment)
        {
            if (start >= increment)
                return;
                    
            List<int> numsToSort = new();

            for (int i = start; i < list.Count; i += increment)
            {
                numsToSort.Add(list[i]);
            }
            
            if (numsToSort.Count < 2)
                return;
            
            _insertionSort.Sort(numsToSort);
            
            for (int i = start; i < list.Count; i += increment)
                list[i] = numsToSort[i/increment];
            
            Sort(list, start + 1, increment);
        }
    }
}
