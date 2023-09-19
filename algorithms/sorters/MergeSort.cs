using System.Collections.Generic;
using System.Linq;


namespace AD
{
    public partial class MergeSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            // Split the list in two until we have a list with two or fewer elements
            if (list.Count > 2)
            {
                Sort(list.GetRange(0, list.Count / 2));
                Sort(list.GetRange(list.Count / 2, list.Count()));
            }

            if (list.Count != 1)
            {
                var i0 = list[0];
                var i1 = list[1];
                if (i0 > i1)
                {
                    list[0] = i1;
                    list[1] = i0;
                }
            }
        }

    }
}
