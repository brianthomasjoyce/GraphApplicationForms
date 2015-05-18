using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApplicationForms
{

    //providing access to neighbours property
    //provide a cost property used to specify the distance between letters in a weighted graph
    public class DirectedGraphNode<L> : Node<L> //inherit the node class
    {
        private List<int> weightings;
        public DirectedGraphNode() : base() { }//inherit base of node
        public DirectedGraphNode(L value) : base(value) { }
        public DirectedGraphNode(L Value, ListOfNodes<L> neighbours) : base(Value, neighbours) { }

       // public double DistanceFromStart { get; set; }
        public ListOfNodes<L> NeighbourNodes// instance of the List of Nodes Class
        {

            get
            {
                if (base.Neighbors == null)
                    base.Neighbors = new ListOfNodes<L>();

                return base.Neighbors;
            }
        }

        public List<int> Weightings
        {

            
            get
            {
                if (weightings == null)
                {
                    weightings = new List<int>();
                }
                return weightings;
            }
        }
        
    }
}
