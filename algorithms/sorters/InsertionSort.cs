using System.Collections.Generic;


namespace AD
{
    public partial class InsertionSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            Sort(list, 0, list.Count - 1);
        }

        public void Sort(List<int> list, int lo, int hi)
        {
            if (lo < hi)
            {
                // Sorteer eerst het deel van de lijst tussen lo en hi recursief
                Sort(list, lo, hi - 1);

                // Plaats het hi-de element op de juiste positie in de gesorteerde subarray
                int key = list[hi];
                int j = hi - 1;

                while (j >= lo && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j--;
                }

                list[j + 1] = key;
            }
            
        }
    }
}
