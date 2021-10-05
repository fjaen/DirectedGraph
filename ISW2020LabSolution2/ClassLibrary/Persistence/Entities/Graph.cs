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

        //cardinality n
        public virtual ICollection<Node> Nodes
        {
            get;
            set;
        }
        
        //cardinality n
        public virtual ICollection<Edge> Edges
        {
            get;
            set;
        }
    }
}