using System;
using System.Collections.Generic;
using System.Text;

namespace DirectedGraph.Entities
{
    public partial class Graph
    {
        public DateTime CreationDate
        {
            get;
            set;
        }
        public String Description
        {
            get;
            set;
        }        

        public ICollection<Node> Nodes
        {
            get;
            set;
        }

        public ICollection<Edge> Edges
        {
            get;
            set;
        }
    }
}