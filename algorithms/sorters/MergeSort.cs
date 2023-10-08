using System.Collections.Generic;

namespace AD
{
    public partial class MergeSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            Sort(list, 0, list.Count - 1);
        }

        public void Sort(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                Sort(list, left, center);
                Sort(list, center + 1, right);
                Merge(list, left, center, right);
            }
        }

        public void Merge(List<int> list, int left, int center, int right)
        {
            int Left = center - left + 1;
            int Right = right - center;

            List<int> leftList = list.GetRange(left, Left);
            List<int> rightList = list.GetRange(center + 1, Right);

            // Add max values to the end of every list
            leftList.Add(int.MaxValue);
            rightList.Add(int.MaxValue);

            int i = 0, j = 0;

            for (int k = left; k <= right; k++)
            {
                if (leftList[i] <= rightList[j])
                {
                    list[k] = leftList[i];
                    i++;
                }
                else
                {
                    list[k] = rightList[j];
                    j++;
                }
            }
        }
    }
}