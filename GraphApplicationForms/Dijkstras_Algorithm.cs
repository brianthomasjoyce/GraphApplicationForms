using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApplicationForms
{
    public class Dijkstras_Algorithm<L>
    {
        private List<DirectedGraphNode<L>> _nodes;
        private ListOfNodes<L> _edges; //Neighbour edges is a type of list of nodes
        private List<DirectedGraphNode<L>> _basis;
        private Dictionary<string, double> _dist;
        private Dictionary<string, DirectedGraphNode<L>> _previous;

        public Dijkstras_Algorithm(GraphDeclare<L> graph, List<DirectedGraphNode<L>> nodes)
        {
            _nodes = nodes;
            _edges = graph.nodeSet;
            _basis = new List<DirectedGraphNode<L>>();
            _dist = new Dictionary<string, double>();
            _previous = new Dictionary<string, DirectedGraphNode<L>>();

            foreach (DirectedGraphNode<L> Node in _nodes)
            {
                _previous.Add(Node.Value.ToString(), null);
                _basis.Add(Node);
                _dist.Add(Node.Value.ToString(), double.MaxValue);     
            }
        }

        public Dijkstras_Algorithm()
        {
            // TODO: Complete member initialization
        }

        public void CalculateDistance(DirectedGraphNode<L> startNode)
        {
            _dist[startNode.Value.ToString()] = 0;

            while(_basis.Count > 0)
            {
                DirectedGraphNode<L> u = GetNodeWithSmallestDistance();

                if(u == null)
                {
                    _basis.Clear(); 
                }
                else
                {
                    foreach(DirectedGraphNode<L> v in getNeighbours(u))
                    {
                        double alt = _dist[u.Value.ToString()] + getDistanceBetween(u, v);
                        if (alt < _dist[v.Value.ToString()])
                        {
                            _dist[v.Value.ToString()] = alt;
                            _previous[v.Value.ToString()] = u;
                        }
                    }

                    _basis.Remove(u);
                }
            }
        }


        public List<DirectedGraphNode<L>> getNeighbours(DirectedGraphNode<L> n)
        {
            List<DirectedGraphNode<L>> neighbours = new List<DirectedGraphNode<L>>();

            foreach(DirectedGraphNode<L> edge in _edges)
            {

                if(edge.Value.Equals(n.Value) &&_basis.Contains(n))
                {
                    foreach(DirectedGraphNode<L> neighbour in edge.NeighbourNodes)
                    {
                        neighbours.Add(neighbour);
                    }

                }
            }

            return neighbours;
        }

        public List<DirectedGraphNode<L>> getPathTo(DirectedGraphNode<L> value)
        {
            List<DirectedGraphNode<L>> path = new List<DirectedGraphNode<L>>();

            path.Insert(0, value);
            while(_previous[value.Value.ToString()] !=null)
            {
                value = _previous[value.Value.ToString()];
                path.Insert(0, value);
            }

            return path;
        }

        public DirectedGraphNode<L> GetNodeWithSmallestDistance()
        {
            double distance = double.MaxValue;

            DirectedGraphNode<L> smallest = null;

            foreach(DirectedGraphNode<L> n in _basis)
            {
                if(_dist[n.Value.ToString()]< distance)
                {
                    distance = _dist[n.Value.ToString()];
                    smallest = n;
                }
            }

            return smallest;
        }


        public double getDistanceBetween(DirectedGraphNode<L> u, DirectedGraphNode<L> v)
        {
            foreach(DirectedGraphNode<L> first in _edges)
            {
                if(first.Value.Equals(u.Value))
                {

                    
                    foreach (DirectedGraphNode<L> neighbour in first.NeighbourNodes)
                    {
                        
                        if (neighbour.Value.Equals(v.Value))
                        {
                            int index = first.NeighbourNodes.IndexOf(neighbour);
                            Console.WriteLine(first.Weightings[index]);

                             return first.Weightings[index];
                        }
                    }
                }

                
            }
            return 0;
        }



        ///////////////////////////////////////////////////////////////////////////////////
        //public double getLengthofDistance(string[] distanceCalc)
        //{
        //    double totalDistance;
        //    int counter = 0;
        //    for (int cntA = 0; cntA < distanceCalc.Count(); ++cntA)
        //    {
        //        counter = cntA + 1;
        //        if (counter != distanceCalc.Count())
        //        {
        //            double total = getDistanceBetween(new DirectedGraphNode<string>(distanceCalc[cntA].ToString()), new DirectedGraphNode<string>(distanceCalc[counter].ToString()));
        //            if (total == 0.0)
        //            {
        //                Console.WriteLine("No Such Route Exists: ");
        //                return 0;
        //                //break;
        //            }
        //            else
        //            {
        //                totalDistance = totalDistance + total;
        //            }
        //        }//dist Calc
        //    }//cntA
        //    return totalDistance;
        //}



    }

}
