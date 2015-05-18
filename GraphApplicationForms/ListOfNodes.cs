using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApplicationForms
{
    public class ListOfNodes<L> : Collection<Node<L>> //implement a collection class
    {

        public ListOfNodes(): base(){ } // access base class members


        public ListOfNodes(int size)  // create a specified nodes number in the collection
        {
            for(int s = 0; s < size; ++s)
            {
                base.Items.Add(default(Node<L>));
            }//for list of nodes
        }

        public Node<L> FindByValue(L value)
        {            
            foreach (Node<L> node in Items)
            {
                if (node.Value.Equals(value))
                {
                    return node;
                }
            }//foreach way to find by value

            return null; // null means a node does not match what already exists
        }

    }
}
