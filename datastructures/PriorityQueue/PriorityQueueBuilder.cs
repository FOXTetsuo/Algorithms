namespace AD
{
    public partial class DSBuilder
    {
        public static IPriorityQueue<int> CreatePriorityQueueEmpty()
        {
            PriorityQueue<int> q = new PriorityQueue<int>();
            return q;
        }

        //
        //          1
        //        /   \
        //      3       5
        //     /
        //    4
        //
        public static IPriorityQueue<int> CreatePriorityQueueSmall()
        {
            PriorityQueue<int> q = new PriorityQueue<int>();

            q.array = new int[] { 0, 1, 3, 5, 4 };
            q.size = 4;

            return q;
        }

        //
        //          -8
        //        /    \
        //      -2      -8
        //     /  \    /  \
        //    7    5  5    6
        //   / \
        //  8   9
        //
        public static IPriorityQueue<int> CreatePriorityQueueModerate()
        {
            PriorityQueue<int> q = new PriorityQueue<int>();

            q.array = new int[] { 0, -8, -2, -8, 7, 5, 5, 6, 8, 9 };
            q.size = 9;

            return q;
        }

        public static IPriorityQueue<int> CreatePriorityQueueFull()
        {
            PriorityQueue<int> q = new PriorityQueue<int>();
            System.Random r = new System.Random();

            for (int i = 0; i < PriorityQueue<int>.DEFAULT_CAPACITY; i++)
                q.Add(r.Next(PriorityQueue<int>.DEFAULT_CAPACITY * 3));
            q.size = PriorityQueue<int>.DEFAULT_CAPACITY;

            return q;
        }

    }
}
