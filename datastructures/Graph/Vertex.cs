using System;
using System.Collections.Generic;
using System.Linq;


namespace AD
{
    public partial class Vertex : IVertex
    {
        public string name;
        public LinkedList<Edge> adj;
        public double distance;
        public Vertex prev;
        public bool known;


        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------

        /// <summary>
        ///    Creates a new Vertex instance.
        /// </summary>
        /// <param name="name">The name of the new vertex</param>
        public Vertex(string name)
        {
            throw new System.NotImplementedException();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public string GetName()
        {
            throw new System.NotImplementedException();
        }
        public LinkedList<Edge> GetAdjacents()
        {
            throw new System.NotImplementedException();
        }

        public double GetDistance()
        {
            throw new System.NotImplementedException();
        }

        public Vertex GetPrevious()
        {
            throw new System.NotImplementedException();
        }

        public bool GetKnown()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }


        //----------------------------------------------------------------------
        // ToString that has to be implemented for exam
        //----------------------------------------------------------------------

        /// <summary>
        ///    Converts this instance of Vertex to its string representation.
        ///    <para>Output will be like : name (distance) [ adj1 (cost) adj2 (cost) .. ]</para>
        ///    <para>Adjecents are ordered ascending by name. If no distance is
        ///    calculated yet, the distance and the parantheses are omitted.</para>
        /// </summary>
        /// <returns>The string representation of this Graph instance</returns> 
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}