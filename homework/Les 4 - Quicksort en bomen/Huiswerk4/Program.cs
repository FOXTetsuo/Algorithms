namespace AD
{
    class Program
    {
        //
        //  a
        //  |
        //  b -- c -- d
        //  |
        //  e
        //
        public static FirstChildNextSibling<string> CreateFirstTreeNextSibling_Small()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string>();
            FirstChildNextSiblingNode<string> e = new FirstChildNextSiblingNode<string>("e");
            FirstChildNextSiblingNode<string> d = new FirstChildNextSiblingNode<string>("d");
            FirstChildNextSiblingNode<string> c = new FirstChildNextSiblingNode<string>("c", null, d);
            FirstChildNextSiblingNode<string> b = new FirstChildNextSiblingNode<string>("b", e, c);
            FirstChildNextSiblingNode<string> a = new FirstChildNextSiblingNode<string>("a", b, null);
            tree.root = a;
            return tree;
        }

        //
        //         5
        //       /   \
        //     2       6
        //    / \
        //   8   7
        //      /
        //     1
        //
        public static BinaryTree<int> CreateBinaryTree_Int()
        {
            BinaryTree<int> t8 = new BinaryTree<int>(8);
            BinaryTree<int> t1 = new BinaryTree<int>(1);
            BinaryTree<int> tnil = new BinaryTree<int>();
            BinaryTree<int> t7 = new BinaryTree<int>();
            BinaryTree<int> t2 = new BinaryTree<int>();
            BinaryTree<int> t5 = new BinaryTree<int>();
            BinaryTree<int> t6 = new BinaryTree<int>(6);

            t7.Merge(7, t1, tnil);
            t2.Merge(2, t8, t7);
            t5.Merge(5, t2, t6);

            return t5;
        }

        //
        //         t
        //       /   \
        //     w       a
        //    / \     / \
        //   q   g   o   p
        public static BinaryTree<string> CreateBinaryTree_String()
        {
            BinaryTree<string> tq = new BinaryTree<string>("q");
            BinaryTree<string> tg = new BinaryTree<string>("g");
            BinaryTree<string> to = new BinaryTree<string>("o");
            BinaryTree<string> tp = new BinaryTree<string>("p");
            BinaryTree<string> tw = new BinaryTree<string>();
            BinaryTree<string> tt = new BinaryTree<string>();
            BinaryTree<string> ta = new BinaryTree<string>();

            tw.Merge("w", tq, tg);
            ta.Merge("a", to, tp);
            tt.Merge("t", tw, ta);

            return tt;
        }

        public static void PrintBinaryTreeInfo<T>(BinaryTree<T> tree)
        {
            System.Console.WriteLine("Size            : {0}", tree.Size());
            System.Console.WriteLine("Height          : {0}", tree.Height());
            System.Console.WriteLine("ToPrefixString  : {0}", tree.ToPrefixString());
            System.Console.WriteLine("ToInfixString   : {0}", tree.ToInfixString());
            System.Console.WriteLine("ToPostfixString : {0}", tree.ToPostfixString());
        }

        public static void PrintBinaryTreeMoreInfo<T>(BinaryTree<T> tree)
        {
            System.Console.WriteLine("NumberOfLeaves               : {0}", tree.NumberOfLeaves());
            System.Console.WriteLine("NumberOfNodesWithOneChild    : {0}", tree.NumberOfNodesWithOneChild());
            System.Console.WriteLine("NumberOfNodesWithTwoChildren : {0}", tree.NumberOfNodesWithTwoChildren());
        }

        static void Opgave1()
        {
            System.Console.WriteLine("\n=====   Opgave 1 : QuickSort   =====\n");
            Sorter isort = new InsertionSort();
            Sorter msort = new MergeSort();
            Sorter ssort = new ShellSort();
            Sorter qsort = new QuickSort();
            isort.Run();
            msort.Run();
            ssort.Run();
            qsort.Run();
            int[] numbers = { 100, 1000, 10000 };
            foreach (int num in numbers)
            {
                isort.RunWithTimer(num);
                msort.RunWithTimer(num);
                ssort.RunWithTimer(num);
                qsort.RunWithTimer(num);
            }
        }

        static void Opgave2()
        {
            System.Console.WriteLine("\n=====   Opgave 2 : FirstChildNextSibling   =====\n");

            FirstChildNextSibling<string> tree;

            // Empty tree
            System.Console.WriteLine("--- Empty tree ---");
            tree = new FirstChildNextSibling<string>();
            tree.PrintPreOrder();
            System.Console.WriteLine("Size     : {0}", tree.Size());
            System.Console.WriteLine("ToString : {0}", tree);

            // Small tree
            System.Console.WriteLine("\n--- Small tree ---");
            tree = CreateFirstTreeNextSibling_Small();
            tree.PrintPreOrder();
            System.Console.WriteLine("Size     : {0}", tree.Size());
            System.Console.WriteLine("ToString : {0}", tree);
        }

        static void Opgave3()
        {
            System.Console.WriteLine("\n=====   Opgave 3 : BinaryTree   =====\n");

            // Empty tree
            System.Console.WriteLine("--- Empty tree ---");
            BinaryTree<int> emptyTree = new BinaryTree<int>();
            PrintBinaryTreeInfo(emptyTree);

            // Int tree
            System.Console.WriteLine("\n--- Int tree ---");
            BinaryTree<int> intTree = CreateBinaryTree_Int();
            PrintBinaryTreeInfo(intTree);

            // String tree
            System.Console.WriteLine("\n--- String tree ---");
            BinaryTree<string> stringTree = CreateBinaryTree_String();
            PrintBinaryTreeInfo(stringTree);
        }

        static void Opgave4()
        {
            System.Console.WriteLine("\n=====   Opgave 4 : NumberOfNodes   =====\n");

            // Empty tree
            System.Console.WriteLine("--- Empty tree ---");
            BinaryTree<int> emptyTree = new BinaryTree<int>();
            PrintBinaryTreeMoreInfo(emptyTree);

            // Int tree
            System.Console.WriteLine("\n--- Int tree ---");
            BinaryTree<int> intTree = CreateBinaryTree_Int();
            PrintBinaryTreeMoreInfo(intTree);

            // String tree
            System.Console.WriteLine("\n--- String tree ---");
            BinaryTree<string> stringTree = CreateBinaryTree_String();
            PrintBinaryTreeMoreInfo(stringTree);

        }

        static void Main(string[] args)
        {
            Opgave1();
            Opgave2();
            Opgave3();
            Opgave4();
        }
    }
}
