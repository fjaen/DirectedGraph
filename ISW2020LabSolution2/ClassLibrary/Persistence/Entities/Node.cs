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

        //cardinality n
        public virtual ICollection<Edge> SourceEdges
        {
            get;
            set;
        }

        //cardinality n
        public virtual ICollection<Edge> DestinationEdges
        {
            get;
            set;
        }
    }
}