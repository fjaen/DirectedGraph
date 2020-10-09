using System;
using System.Collections.Generic;
using System.Text;

namespace DirectedGraph.Entities
{
    public partial class Node
    {
        public Node() {
            SourceEdges = new List<Edge>();
            DestinationEdges = new List<Edge>();
        }
        public Node(int Id):this()
        {
            this.Id = Id;
        }
    }
}