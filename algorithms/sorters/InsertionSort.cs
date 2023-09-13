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
            throw new System.NotImplementedException();
        }
    }
}
