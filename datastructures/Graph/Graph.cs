using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace AD
{
    public partial class Graph : IGraph
    {
        public static readonly double INFINITY = System.Double.MaxValue;

        public Dictionary<string, Vertex> vertexMap;


        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------

        public Graph()
        {
            vertexMap = new Dictionary<string, Vertex>();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        /// <summary>
        ///    Adds a vertex to the graph. If a vertex with the given name
        ///    already exists, no action is performed.
        /// </summary>
        /// <param name="name">The name of the new vertex</param>
        public void AddVertex(string name)
        {
            vertexMap.TryAdd(name, new Vertex(name));
        }


        /// <summary>
        ///    Gets a vertex from the graph by name. If no such vertex exists,
        ///    a new vertex will be created and returned.
        /// </summary>
        /// <param name="name">The name of the vertex</param>
        /// <returns>The vertex withe the given name</returns>
        public Vertex GetVertex(string name)
        {
            if (vertexMap.TryGetValue(name, out var vertex))
            {
                return vertex;
            }

            AddVertex(name);
            return GetVertex(name);
        }


        /// <summary>
        ///    Creates an edge between two vertices. Vertices that are non existing
        ///    will be created before adding the edge.
        ///    There is no check on multiple edges!
        /// </summary>
        /// <param name="source">The name of the source vertex</param>
        /// <param name="dest">The name of the destination vertex</param>
        /// <param name="cost">cost of the edge</param>
        public void AddEdge(string source, string dest, double cost = 1)
        {
            var sourceVert = GetVertex(source);
            var destinationVert = GetVertex(dest);

            sourceVert.GetAdjacents().AddLast(new Edge(destinationVert, cost));
        }


        /// <summary>
        ///    Clears all info within the vertices. This method will not remove any
        ///    vertices or edges.
        /// </summary>
        public void ClearAll()
        {
            foreach (var kvp in vertexMap)
            {
                kvp.Value.Reset();
            }
        }

        /// <summary>
        ///    Performs the Breatch-First algorithm for unweighted graphs.
        /// </summary>
        /// <param name="name">The name of the starting vertex</param>
        public void Unweighted(string name)
        {
            var queue = new Queue<Vertex>();
            Vertex startinVertex = vertexMap[name];
            startinVertex.distance = 0;
            
            queue.Enqueue(startinVertex);

            while (queue.Count != 0)
            {
                var vert = queue.Dequeue();

                foreach (Edge e in vert.GetAdjacents())
                {
                    if (e.dest.distance == INFINITY)
                    {
                        e.dest.distance = vert.distance + 1;
                        e.dest.prev = vert;
                        queue.Enqueue(e.dest);
                    }
                }
            }
        }

        // Sets the distance of each Vertex to the distance they have from the Node you're trying to find
        public void FindDistanceTo(string name)
        {
            foreach (var vertex in vertexMap)
            {
                if (vertex.Key == name)
                {
                    vertex.Value.distance = 0;
                    continue;
                }
                vertex.Value.distance = Travel(vertex.Key, name, 0);

                if (vertex.Value.distance == INFINITY)
                    vertex.Value.distance = -1;
            }
        }

        // Walk around the paths to see what the shortest route to a given target is
        public double Travel(string name, string target, double counter)
        {
            if (name == target)
                return counter;

            var adj = GetVertex(name).GetAdjacents();
            double minDistance = INFINITY;

            foreach (var adjacent in adj)
            {
                if (adjacent.dest.name != name)
                {
                    double distance = Travel(adjacent.dest.name, target, counter + 1);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                    } 
                }
            }

            return minDistance;
        }

        // Sadly doesn't work because of the 'boundary conditon' in travel.
        public bool HasCycle(string name)
        {
            if (Travel(name, name, 0) != INFINITY)
            {
                return true;
            }

            return false;
        }


        public string ShowDistance()
        {
            var returnstring = "";
            foreach (var vertex in vertexMap)
            {
                returnstring += ($"{vertex.Key}({vertex.Value.distance}) ");
            }

            return returnstring;
        }

        /// <summary>
        ///    Performs the Dijkstra algorithm for weighted graphs.
        /// </summary>
        /// <param name="name">The name of the starting vertex</param>
        public void Dijkstra(string name)
        {
            // first get vertex
            var vertex = GetVertex(name);
            vertex.distance = 0;
            var priorityQueue = new PriorityQueue<Vertex>();
            priorityQueue.Add(vertex);

            while (priorityQueue.Size() > 0)
            {
                vertex = priorityQueue.Remove();
                if (vertex.GetKnown())
                    continue;
                
                vertex.known = true;
                
                foreach (var edge in vertex.GetAdjacents())
                {
                    var w = edge.dest;
                    if (!w.GetKnown())
                    {
                        var tentativeDistance = vertex.GetDistance() + edge.cost;
                        if (tentativeDistance < w.GetDistance())
                        {
                            // Update the distance and previous vertex for 'w'.
                            w.distance = tentativeDistance;
                            w.prev = vertex;

                            // Add 'w' to the priority queue to explore its neighbors.
                            priorityQueue.Add(w);
                        }
                    }
                }
            }
        }

        //----------------------------------------------------------------------
        // ToString that has to be implemented for exam
        //----------------------------------------------------------------------

        /// <summary>
        ///    Converts this instance of Graph to its string representation.
        ///    It will call the ToString method of each Vertex. The output is
        ///    ascending on vertex name.
        /// </summary>
        /// <returns>The string representation of this Graph instance</returns>
        public override string ToString()
        {
            var returnstring = "";
            foreach (string key in vertexMap.Keys.OrderBy(x => x))
            {
                returnstring+= vertexMap[key];
            }

            return returnstring;
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------



        public bool IsConnected()
        {
            throw new System.NotImplementedException();
        }

    }
}