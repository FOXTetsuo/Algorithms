using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AD
{
    public partial class TestUtils
    {
        public static string TrimmedStringWithSingleSpaces(string s)
        {
            return Regex.Replace(s, @"\s+", " ").Trim();
        }
        public static string TrimmedStringWithoutSpaces(string s)
        {
            return Regex.Replace(s, @"\s+", "").Trim();
        }
        public static string ListToString<T>(IEnumerable<T> lst)
        {
            if (lst.Count() == 0)
                return "NIL";
            return "[" + string.Join(",", lst) + "]";
        }
        public static string ListToOrderedString<T>(IEnumerable<T> lst)
        {
            if (lst.Count() == 0)
                return "NIL";
            return "[" + string.Join(",", lst.OrderBy(x => x)) + "]";
        }
        public static List<int> RandomList(int lo, int hi, int count, bool unique = false)
        {
            HashSet<int> hash = new HashSet<int>();
            List<int> list = new List<int>();
            System.Random random = new System.Random();

            while (list.Count < count)
            {
                int elt = random.Next(lo, hi);
                if (unique && hash.Contains(elt))
                    continue;
                list.Add(elt);
                hash.Add(elt);
            }
            return list;
        }
        public List<int> UniqueRandomList(int lo, int hi, int count)
        {
            return RandomList(lo, hi, count, true);
        }    }
}