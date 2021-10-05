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
        //cardinality 1
        public virtual Node Source
        {
            get;
            set;
        }
        //cardinality 1
        public virtual Node Destination
        {
            get;
            set;
        }
    }
}