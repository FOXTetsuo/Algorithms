namespace AD
{
    public partial interface IGraph
    {
        //----------------------------------------------------------------------
        // Methods that have to be implemented for exam
        //----------------------------------------------------------------------

        // Add a vertex. If already existing, exits without exception
        void AddVertex(string name);

        // Returns a vertex from the graph by name
        // If there is no such vertex, one is added
        Vertex GetVertex(string name);

        void AddEdge(string source, string dest, double cost);

        void ClearAll();

        void Unweighted(string name);

        void Dijkstra(string name);

        //----------------------------------------------------------------------
        // Methods that have to be implemented for homework
        //----------------------------------------------------------------------
        bool IsConnected();
    }

}