using System.Collections.Generic;
using System.Linq;


namespace AD
{
    public partial class MergeSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            Sort(list, 0, list.Count);
        }

        public void Sort(List<int> list, int left, int right)
        {
            
            if (left < right - 1)
            {
                int center = (left + right) / 2;
                Sort(list, left, center);
                Sort(list, center, right);
                Merge(list, left, center, right);
            }
        }

        public void Merge(List<int> list, int left, int center, int right)
        {
            var Left = center - left + 1;
            var Right = right - center;

            var leftList = list.GetRange(left, center);
            var rightList = list.GetRange(center + 1, right);

            // dit is lelijk >:(
            leftList[Left + 1] = int.MaxValue;
            rightList[Right + 1] = int.MaxValue;
            var i = 1;
            var j = 1;

            
        }

    }
}
