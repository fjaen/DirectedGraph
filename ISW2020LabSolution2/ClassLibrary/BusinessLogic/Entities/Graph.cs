using System;
using System.Collections.Generic;
using System.Text;

namespace DirectedGraph.Entities
{
    public partial class Graph
    {
        public Graph() {
            Nodes = new List<Node>();
            Edges= new List<Edge>();
        }
        public Graph(DateTime CreationDate,String Description):this() {
            this.CreationDate = CreationDate;
            this.Description = Description;
        }
    }
}