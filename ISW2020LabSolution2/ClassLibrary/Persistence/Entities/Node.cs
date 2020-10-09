using System;
using System.Collections.Generic;
using System.Text;

namespace DirectedGraph.Entities
{
    public partial class Node
    {
        public int Id
        {
            get;
            set;
        }
        public ICollection<Edge> SourceEdges
        {
            get;
            set;
        }
        public ICollection<Edge> DestinationEdges
        {
            get;
            set;
        }
    }
}