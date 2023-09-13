namespace AD
{
    class Program
    {
        static void Ex1ArrayList()
        {
            System.Console.WriteLine("\n=====   Opgave 1 : MyArrayList   =====\n");

            MyArrayList al = new MyArrayList(10);
            System.Console.WriteLine(al);
            al.Add(2);
            al.Add(3);
            al.Add(5);
            System.Console.WriteLine(al);
            System.Console.WriteLine(al.Get(0));
            try
            {
                System.Console.WriteLine(al.Get(3));
            }
            catch (MyArrayListIndexOutOfRangeException e)
            {
                System.Console.WriteLine("Exception (zoals verwacht): {0}", e.Message);
            }
            al.Set(2, 4);
            System.Console.WriteLine(al);

            al.Clear();
            for (int i = 0; i < 10; i++)
            {
                al.Add(i);
            }
            al.Set(9, 2);
            al.Set(7, 2);
            System.Console.WriteLine(al);
            System.Console.WriteLine(al.CountOccurences(2));
        }


        static void Ex2LinkedList()
        {
            System.Console.WriteLine("\n=====   Opgave 2 : MyLinkedList   =====\n");

            MyLinkedList<string> ll = new MyLinkedList<string>();
            System.Console.WriteLine(ll);
            ll.AddFirst("a");
            ll.AddFirst("b");
            ll.AddFirst("c");
            ll.Insert(2, "x");
            System.Console.WriteLine(ll);
            try
            {
                ll.Insert(4, "y");
            }
            catch (MyLinkedListIndexOutOfRangeException e)
            {
                System.Console.WriteLine(e.Message);
            }

            ll.Clear();
            System.Console.WriteLine(ll);
            ll.AddFirst("a");
            ll.AddFirst("b");
            ll.AddFirst("c");
            ll.Insert(2, "x");
            System.Console.WriteLine(ll);
            try
            {
                ll.Insert(5, "kan niet");
            }
            catch (MyLinkedListIndexOutOfRangeException e)
            {
                System.Console.WriteLine("Exception (zoals verwacht): {0}", e.Message);
            }

            ll.Clear();
            ll.AddFirst("a");
            ll.AddFirst("b");
            System.Console.WriteLine(ll.GetFirst());
            ll.RemoveFirst();
            System.Console.WriteLine(ll);
            ll.RemoveFirst();
            System.Console.WriteLine(ll);
        }


        static void Ex3Stack()
        {
            System.Console.WriteLine("\n=====   Opgave 3 : MyStack   =====\n");

            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            System.Console.WriteLine(stack.Top());
            stack.Pop();
            stack.Pop();
            stack.Pop();
            try
            {
                stack.Pop();
            }
            catch (MyStackEmptyException e)
            {
                System.Console.WriteLine("Exception (zoals verwacht): {0}", e.Message);
            }
        }


        static void Ex4BracketChecker()
        {
            System.Console.WriteLine("\n=====   Opgave 4 : BracketChecker   =====\n");

            System.Console.WriteLine(BracketChecker.CheckBrackets(""));
            System.Console.WriteLine(BracketChecker.CheckBrackets("()"));
            System.Console.WriteLine(BracketChecker.CheckBrackets("())"));

            System.Console.WriteLine("\n=====   Opgave 4 : BracketChecker2   =====\n");

            System.Console.WriteLine(BracketChecker.CheckBrackets2("(())([][][][[]]{})"));
            System.Console.WriteLine(BracketChecker.CheckBrackets2("(){}[]["));
            System.Console.WriteLine(BracketChecker.CheckBrackets2("([)]"));
            System.Console.WriteLine(BracketChecker.CheckBrackets2("([][]"));
        }


        static void Ex5Queue()
        {
            System.Console.WriteLine("\n=====   Opgave 5 : MyQueue   =====\n");

            MyQueue<int> queue = new MyQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            System.Console.WriteLine(queue.Dequeue());
            System.Console.WriteLine(queue.GetFront());
            System.Console.WriteLine(queue.Dequeue());
            System.Console.WriteLine(queue.GetFront());
            queue.Dequeue();
            try
            {
                System.Console.WriteLine(queue.GetFront());
            }
            catch (MyQueueEmptyException e)
            {
                System.Console.WriteLine("Exception (zoals verwacht): {0}", e.Message);
            }
        }


        static void Main(string[] args)
        {
            Ex1ArrayList();
            Ex2LinkedList();
            Ex3Stack();
            Ex4BracketChecker();
            Ex5Queue();
        }
    }
}
