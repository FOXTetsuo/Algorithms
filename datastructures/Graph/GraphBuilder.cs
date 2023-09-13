namespace AD
{
    public partial class DSBuilder
    {
        public static IVertex CreateVertexUnclean()
        {
            Vertex v = new Vertex("name");
            v.distance = 5;
            v.prev = v;
            v.known = true;

            return v;
        }


        public static IVertex CreateVertexSingle()
        {
            Vertex v1 = new Vertex("V1");

            return v1;
        }


        public static IVertex CreateVertexSingleWithDistance()
        {
            Vertex v = new Vertex("V1");
            v.distance = 13;

            return v;
        }


        public static IVertex CreateVertexWithTwoAdjecents()
        {
            Vertex v1 = new Vertex("V1");
            Vertex v3 = new Vertex("V3");
            Vertex v4 = new Vertex("V4");
            Edge e13 = new Edge(v3, 3);
            Edge e14 = new Edge(v4, 10);

            v1.adj.AddLast(e13);
            v1.adj.AddLast(e14);

            return v1;
        }

        public static IVertex CreateVertexWithTwoAdjecentsUnsorted()
        {
            Vertex v1 = new Vertex("V1");
            Vertex v3 = new Vertex("V3");
            Vertex v4 = new Vertex("V4");
            Edge e13 = new Edge(v3, 3);
            Edge e14 = new Edge(v4, 10);

            v1.adj.AddLast(e14);
            v1.adj.AddLast(e13);

            return v1;
        }

        public static IVertex CreateVertexWithTwoAdjecentsAndDistance()
        {
            Vertex v1 = new Vertex("V1");
            Vertex v3 = new Vertex("V3");
            Vertex v4 = new Vertex("V4");
            Edge e13 = new Edge(v3, 3);
            Edge e14 = new Edge(v4, 10);

            v1.distance = 5;
            v1.adj.AddLast(e13);
            v1.adj.AddLast(e14);

            return v1;
        }


        public static IGraph CreateGraphEmpty()
        {
            return new Graph();
        }


        public static IGraph CreateGraphFromBook14_1()
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


        public static IGraph CreateGraphFromLectureUnweightedExample()
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


        public static IGraph CreateGraphFromLectureUnweightedExercise()
        {
            Graph graph = new Graph();

            graph.AddEdge("A", "G");
            graph.AddEdge("A", "H");
            graph.AddEdge("B", "C");
            graph.AddEdge("B", "F");
            graph.AddEdge("D", "B");
            graph.AddEdge("D", "G");
            graph.AddEdge("E", "I");
            graph.AddEdge("F", "C");
            graph.AddEdge("G", "E");
            graph.AddEdge("H", "B");
            graph.AddEdge("H", "G");
            graph.AddEdge("I", "D");

            return graph;
        }


        public static IGraph CreateGraphFromLectureWeightedExample()
        {
            Graph graph = new Graph();

            graph.AddEdge("V1", "V2", 2);
            graph.AddEdge("V1", "V4", 1);
            graph.AddEdge("V2", "V4", 3);
            graph.AddEdge("V2", "V5", 10);
            graph.AddEdge("V3", "V1", 4);
            graph.AddEdge("V3", "V6", 3);
            graph.AddEdge("V4", "V3", 3);
            graph.AddEdge("V4", "V5", 2);
            graph.AddEdge("V4", "V6", 8);
            graph.AddEdge("V4", "V7", 4);
            graph.AddEdge("V5", "V7", 6);
            graph.AddEdge("V7", "V6", 1);

            return graph;
        }


        public static IGraph CreateGraphFromLectureWeightedExercise()
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


    }
}
