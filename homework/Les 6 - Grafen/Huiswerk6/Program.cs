namespace AD
{
    class Program
    {
        public static Graph Figure14_1FromBook()
        {
            Graph graph = new Graph();

            graph.AddEdge("V0", "V1", 2);
            graph.AddEdge("V0", "V3", 1);
            graph.AddEdge("V1", "V3", 3);
            graph.AddEdge("V1", "V4", 10);
            graph.AddEdge("V3", "V2", 2);
            graph.AddEdge("V3", "V5", 8);
            graph.AddEdge("V3", "V6", 4);
            graph.AddEdge("V3", "V4", 2);
            graph.AddEdge("V2", "V0", 4);
            graph.AddEdge("V2", "V5", 5);
            graph.AddEdge("V4", "V6", 6);
            graph.AddEdge("V6", "V5", 1);

            return graph;
        }


        public static Graph UnweightedFromLectureExample()
        {
            Graph graph = new Graph();

            graph.AddEdge("v1", "v2");
            graph.AddEdge("v1", "v4");
            graph.AddEdge("v2", "v4");
            graph.AddEdge("v2", "v5");
            graph.AddEdge("v3", "v1");
            graph.AddEdge("v3", "v6");
            graph.AddEdge("v4", "v3");
            graph.AddEdge("v4", "v5");
            graph.AddEdge("v4", "v6");
            graph.AddEdge("v5", "v7");
            graph.AddEdge("v7", "v4");
            graph.AddEdge("v7", "v6");

            return graph;
        }


        public static Graph WeightedFromLectureExercise()
        {
            Graph graph = new Graph();

            graph.AddEdge("A", "C", 2);
            graph.AddEdge("A", "E", 8);
            graph.AddEdge("A", "G", 6);
            graph.AddEdge("B", "D", 7);
            graph.AddEdge("B", "E", 2);
            graph.AddEdge("B", "F", 4);
            graph.AddEdge("B", "H", 4);
            graph.AddEdge("C", "A", 2);
            graph.AddEdge("C", "D", 3);
            graph.AddEdge("C", "G", 2);
            graph.AddEdge("D", "B", 7);
            graph.AddEdge("D", "C", 3);
            graph.AddEdge("D", "E", 2);
            graph.AddEdge("D", "F", 3);
            graph.AddEdge("E", "A", 8);
            graph.AddEdge("E", "B", 2);
            graph.AddEdge("E", "D", 2);
            graph.AddEdge("F", "B", 4);
            graph.AddEdge("F", "D", 3);
            graph.AddEdge("F", "G", 2);
            graph.AddEdge("G", "A", 6);
            graph.AddEdge("G", "C", 2);
            graph.AddEdge("G", "F", 2);
            graph.AddEdge("H", "B", 4);

            return graph;
        }


        static void Main(string[] args)
        {
            Graph graph14_1 = Figure14_1FromBook();
            Graph unweighted = UnweightedFromLectureExample();
            Graph weighted = WeightedFromLectureExercise();

            System.Console.WriteLine(graph14_1);
            System.Console.WriteLine(unweighted);
            System.Console.WriteLine(weighted);

            graph14_1.Dijkstra("V0");
            unweighted.Unweighted("v3");
            weighted.Dijkstra("A");

            System.Console.WriteLine(graph14_1);
            System.Console.WriteLine(unweighted);
            System.Console.WriteLine(weighted);
       }
    }
}