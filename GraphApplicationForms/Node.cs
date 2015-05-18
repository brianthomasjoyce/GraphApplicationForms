using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApplicationForms
{
    public class Node<L>
    {
        private L data;
        private ListOfNodes<L> NeighboringLetters = null;

        public Node() { }
        public Node(L data) : this(data, null) { }
        public Node(L data, ListOfNodes<L> Neighbors)
        {
            this.data = data;
            this.NeighboringLetters = Neighbors;
        }

        //use getters and setters to access the privately declared Data declared in the class Encapsulation
        public L Value
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        protected ListOfNodes<L> Neighbors
        {
            get
            {
                return NeighboringLetters;
            }
            set
            {
                NeighboringLetters = value;
            }

        }

        protected double DistanceFromStart { get; set; }
        // this will be inherited by the directed graph node
    }
}
