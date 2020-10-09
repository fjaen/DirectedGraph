using System;
using System.Collections.Generic;
using System.Text;

namespace DirectedGraph.Entities
{
    public partial class Edge
    {

        public Edge(int Weight, Node Source, Node Destination) {
            this.Weight = Weight;
            this.Source = Source;
            this.Destination = Destination;
        }
    }
}