using NUnit.Framework;
using System.Linq;
using System.Text.RegularExpressions;


namespace AD
{
    [TestFixture]
    public partial class GraphTests
    {
        [Test]
        public void Graph_01_Vertex_01_Reset()
        {
            // Arrange
            IVertex v = DSBuilder.CreateVertexUnclean();

            // Act
            v.Reset();

            // Assert
            Assert.AreEqual(Graph.INFINITY, v.GetDistance());
            Assert.IsNull(v.GetPrevious());
            Assert.IsFalse(v.GetKnown());
        }

        [Test]
        public void Graph_01_Vertex_02_ToString_01_SingleVertex()
        {
            // Arrange
            IVertex v = DSBuilder.CreateVertexSingle();
            string expected = "V1[]";

            // Act
            string actual = TestUtils.TrimmedStringWithoutSpaces(v.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graph_01_Vertex_02_ToString_02_SingleVertexWithDistance()
        {
            // Arrange
            IVertex v = DSBuilder.CreateVertexSingleWithDistance();
            string expected = "V1(13)[]";

            // Act
            string actual = TestUtils.TrimmedStringWithoutSpaces(v.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graph_01_Vertex_02_ToString_03_VertexWithAdjecents()
        {
            // Arrange
            IVertex v = DSBuilder.CreateVertexWithTwoAdjecents();
            string expected = "V1[V3(3)V4(10)]";

            // Act
            string actual = TestUtils.TrimmedStringWithoutSpaces(v.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graph_01_Vertex_02_ToString_04_VertexWithAdjecentsUnsorted()
        {
            // Arrange
            IVertex v = DSBuilder.CreateVertexWithTwoAdjecentsUnsorted();
            string expected = "V1[V3(3)V4(10)]";

            // Act
            string actual = TestUtils.TrimmedStringWithoutSpaces(v.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graph_01_Vertex_02_ToString_05_VertexWithAdjecentsAndDistance()
        {
            // Arrange
            IVertex v = DSBuilder.CreateVertexWithTwoAdjecentsAndDistance();
            string expected = "V1(5)[V3(3)V4(10)]";

            // Act
            string actual = TestUtils.TrimmedStringWithoutSpaces(v.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Graph_02_AddVertex_01_OnEmptyGraph()
        {
            // Arrange
            // Ugly unittest. Normally we test only functionallity (so
            // we use the interfaces. Now we really want to see the
            // contents, so we use Graph instead of IGraph
            Graph graph = (Graph) DSBuilder.CreateGraphEmpty();
            int expected_count = 1;
            string expected_name = "test03";

            // Act
            graph.AddVertex("test03");

            // Assert
            Assert.AreEqual(expected_count, graph.vertexMap.Count);
            Assert.AreEqual(expected_name, graph.vertexMap.Last().Key);
        }


        [Test]
        public void Graph_02_AddVertex_02_OnEmptyGraph_DoubleExecuted()
        {
            // Arrange
            // Ugly unittest. Normally we test only functionallity (so
            // we use the interfaces. Now we really want to see the
            // contents, so we use Graph instead of IGraph
            Graph graph = (Graph)DSBuilder.CreateGraphEmpty();
            int expected_count = 1;
            string expected_name = "test03";

            // Act
            graph.AddVertex("test03");
            graph.AddVertex("test03");

            // Assert
            Assert.AreEqual(expected_count, graph.vertexMap.Count);
            Assert.AreEqual(expected_name, graph.vertexMap.Last().Key);
        }


        [Test]
        public void Graph_02_AddVertex_03_NewVertexOnGraph14_1()
        {
            // Arrange
            // Ugly unittest. Normally we test only functionallity (so
            // we use the interfaces. Now we really want to see the
            // contents, so we use Graph instead of IGraph
            Graph graph = (Graph)DSBuilder.CreateGraphFromBook14_1();
            int expected_count = 8;
            string expected_name = "test03";

            // Act
            graph.AddVertex("test03");

            // Assert
            Assert.AreEqual(expected_count, graph.vertexMap.Count);
            Assert.AreEqual(expected_name, graph.vertexMap.Last().Key);
        }


        [Test]
        public void Graph_02_AddVertex_04_ExistingVertexOnGraph14_1()
        {
            // Arrange
            // Ugly unittest. Normally we test only functionallity (so
            // we use the interfaces. Now we really want to see the
            // contents, so we use Graph instead of IGraph
            Graph graph = (Graph)DSBuilder.CreateGraphFromBook14_1();
            int expected_count = 7;

            // Act
            graph.AddVertex("V3");

            // Assert
            Assert.AreEqual(expected_count, graph.vertexMap.Count);
        }


        [Test]
        public void Graph_03_GetVertex_01_OnEmptyGraph()
        {
            // Arrange
            // Ugly unittest. Normally we test only functionallity (so
            // we use the interfaces. Now we really want to see the
            // contents, so we use Graph instead of IGraph
            Graph graph = (Graph)DSBuilder.CreateGraphEmpty();
            int expected_count = 1;
            string expected_name = "test03";

            // Act
            Vertex v = graph.GetVertex("test03");

            // Assert
            Assert.AreEqual(expected_count, graph.vertexMap.Count);
            Assert.AreEqual(expected_name, graph.vertexMap.Last().Key);
            Assert.AreEqual(expected_name, v.GetName());
            Assert.AreEqual(Graph.INFINITY, v.GetDistance());
            Assert.IsNull(v.GetPrevious());
            Assert.IsFalse(v.GetKnown());
        }


        [Test]
        public void Graph_03_GetVertex_02_OnEmptyGraph_AfterAddingVertex()
        {
            // Arrange
            // Ugly unittest. Normally we test only functionallity (so
            // we use the interfaces. Now we really want to see the
            // contents, so we use Graph instead of IGraph
            Graph graph = (Graph)DSBuilder.CreateGraphEmpty();
            int expected_count = 1;
            string expected_name = "test03";

            // Act
            graph.AddVertex("test03");
            Vertex v = graph.GetVertex("test03");

            // Assert
            Assert.AreEqual(expected_count, graph.vertexMap.Count);
            Assert.AreEqual(expected_name, graph.vertexMap.Last().Key);
            Assert.AreEqual(expected_name, v.GetName());
            Assert.AreEqual(Graph.INFINITY, v.GetDistance());
            Assert.IsNull(v.GetPrevious());
            Assert.IsFalse(v.GetKnown());
        }


        [Test]
        public void Graph_03_GetVertex_03_NewVertexOnGraph14_1()
        {
            // Arrange
            // Ugly unittest. Normally we test only functionallity (so
            // we use the interfaces. Now we really want to see the
            // contents, so we use Graph instead of IGraph
            Graph graph = (Graph)DSBuilder.CreateGraphFromBook14_1();
            int expected_count = 8;
            string expected_name = "test03";

            // Act
            graph.GetVertex("test03");

            // Assert
            Assert.AreEqual(expected_count, graph.vertexMap.Count);
            Assert.AreEqual(expected_name, graph.vertexMap.Last().Key);
        }


        [Test]
        public void Graph_03_GetVertex_04_ExistingVertexOnGraph14_1()
        {
            // Arrange
            // Ugly unittest. Normally we test only functionallity (so
            // we use the interfaces. Now we really want to see the
            // contents, so we use Graph instead of IGraph
            Graph graph = (Graph)DSBuilder.CreateGraphFromBook14_1();
            int expected_count = 7;

            // Act
            graph.GetVertex("V3");

            // Assert
            Assert.AreEqual(expected_count, graph.vertexMap.Count);
        }


        [Test]
        public void Graph_04_AddEdge_01_OnEmptyGraph()
        {
            // Arrange
            // Ugly unittest. Normally we test only functionallity (so
            // we use the interfaces. Now we really want to see the
            // contents, so we use Graph instead of IGraph
            Graph graph = (Graph)DSBuilder.CreateGraphEmpty();

            // Act
            graph.AddEdge("1", "2", 3);
            Vertex vertex = graph.vertexMap["1"];

            // Assert
            Assert.AreEqual(2, graph.vertexMap.Count);
            Assert.AreEqual(1, vertex.GetAdjacents().Count);
            Assert.AreEqual(3, vertex.GetAdjacents().First.Value.cost);
            Assert.AreEqual("2", vertex.GetAdjacents().First.Value.dest.name);
        }


        [Test]
        public void Graph_05_ToString_01_OnEmptyGraph()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraphEmpty();
            string expected = "";

            // Act
            string actual = TestUtils.TrimmedStringWithoutSpaces(graph.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graph_05_ToString_02_OnUnsortedVertices()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraphEmpty();
            graph.AddVertex("g");
            graph.AddVertex("a");
            graph.AddVertex("z");
            string expected = "a[]g[]z[]";

            // Act
            string actual = TestUtils.TrimmedStringWithoutSpaces(graph.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graph_05_ToString_04_OnGraph14_1()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraphFromBook14_1();
            string expected = TestUtils.TrimmedStringWithoutSpaces(@"
                V0 [ V1(2) V3(1) ]
                V1 [ V3(3) V4(10) ]
                V2 [ V0(4) V5(5) ]
                V3 [ V2(2) V4(2) V5(8) V6(4) ]
                V4 [ V6(6) ]
                V5 [ ]
                V6 [ V5(1) ]");

            // Act
            string actual = TestUtils.TrimmedStringWithoutSpaces(graph.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Graph_05_ToString_05_OnUnweightedGraphFromLectureExample()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraphFromLectureUnweightedExample();
            string expected = TestUtils.TrimmedStringWithoutSpaces(@"
                v1 [ v2(1) v4(1) ]
                v2 [ v4(1) v5(1) ]
                v3 [ v1(1) v6(1) ]
                v4 [ v3(1) v5(1) v6(1) ]
                v5 [ v7(1) ]
                v6 [ ]
                v7 [ v4(1) v6(1) ]");

            // Act
            string actual = TestUtils.TrimmedStringWithoutSpaces(graph.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graph_06_Unweighted_01_OnUnweightedGraphFromLectureExample()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraphFromLectureUnweightedExample();
            string expected = TestUtils.TrimmedStringWithoutSpaces(@"
                v1(1) [ v2(1) v4(1) ]
                v2(2) [ v4(1) v5(1) ]
                v3(0) [ v1(1) v6(1) ]
                v4(2) [ v3(1) v5(1) v6(1) ]
                v5(3) [ v7(1) ]
                v6(1) [ ]
                v7(4) [ v4(1) v6(1) ]");

            // Act
            graph.Unweighted("v3");
            string actual = TestUtils.TrimmedStringWithoutSpaces(graph.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graph_06_Unweighted_02_OnUnweightedGraphFromExersize()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraphFromLectureUnweightedExercise();
            string expected = TestUtils.TrimmedStringWithoutSpaces(@"
                A(0) [ G(1) H(1) ]
                B(2) [ C(1) F(1) ]
                C(3) [ ]
                D(4) [ B(1) G(1) ]
                E(2) [ I(1) ]
                F(3) [ C(1) ]
                G(1) [ E(1) ]
                H(1) [ B(1) G(1) ]
                I(3) [ D(1) ]");

            // Act
            graph.Unweighted("A");
            string actual = TestUtils.TrimmedStringWithoutSpaces(graph.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graph_07_Dijkstra_01_OnGraph14_1()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraphFromBook14_1();
            string expected = TestUtils.TrimmedStringWithoutSpaces(@"
                V0(0) [ V1(2) V3(1) ]
                V1(2) [ V3(3) V4(10) ]
                V2(3) [ V0(4) V5(5) ]
                V3(1) [ V2(2) V4(2) V5(8) V6(4) ]
                V4(3) [ V6(6) ]
                V5(6) [ ]
                V6(5) [ V5(1) ]");

            // Act
            graph.Dijkstra("V0");
            string actual = TestUtils.TrimmedStringWithoutSpaces(graph.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graph_07_Dijkstra_02_OnWeightedGraphFromLectureExample()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraphFromLectureWeightedExample();
            string expected = TestUtils.TrimmedStringWithoutSpaces(@"
                V1(0) [V2(2) V4(1)]
                V2(2) [V4(3) V5(10)]
                V3(4) [V1(4) V6(3)]
                V4(1) [V3(3) V5(2) V6(8) V7(4)]
                V5(3) [V7(6)]
                V6(6) [ ]
                V7(5) [V6(1)]");

            // Act
            graph.Dijkstra("V1");
            string actual = TestUtils.TrimmedStringWithoutSpaces(graph.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graph_07_Dijkstra_03_OnWeightedGraphFromLectureExersize()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraphFromLectureWeightedExercise();
            string expected = TestUtils.TrimmedStringWithoutSpaces(@"
                A(0) [C(2) E(8) G(6)]
                B(9) [D(7) E(2) F(4) H(4)]
                C(2) [A(2) D(3) G(2)]
                D(5) [B(7) C(3) E(2) F(3)]
                E(7) [A(8) B(2) D(2)]
                F(6) [B(4) D(3) G(2)]
                G(4) [A(6) C(2) F(2)]
                H(13) [B(4)]");

            // Act
            graph.Dijkstra("A");
            string actual = TestUtils.TrimmedStringWithoutSpaces(graph.ToString());

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
