using System;
using System.Collections.Generic;
using System.Text;

namespace DirectedGraph.Entities
{
    public partial class Edge
    {
        public int Weight
        {
            get;
            set;
        }

        public Node Source
        {
            get;
            set;
        }

        public Node Destination
        {
            get;
            set;
        }
    }
}