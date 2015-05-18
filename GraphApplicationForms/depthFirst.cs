using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GraphApplicationForms
{
    public class depthFirst<L>
    {

        private double total = 0;
        private DirectedGraphNode<string>[] pathToAdd;
        private Label result;

        public depthFirst(Label result)
        {
            this.result = result;
        }
        public depthFirst(DirectedGraphNode<string>[]pathToAdd, Label resultLabel)
        {
            this.result = resultLabel;
            this.pathToAdd = pathToAdd;
        }
        public void depthSearch(GraphDeclare<string> graph, LinkedList<DirectedGraphNode<string>> Visited, DirectedGraphNode<string> start, DirectedGraphNode<string> End, double maxDistance, ref List<KeyValuePair<string, double>> listPair)
        {

            LinkedList<DirectedGraphNode<string>> nodes = getNeighboursAdjecentNodes(graph, Visited.Last());
            foreach (DirectedGraphNode<string> node in nodes)
            {
                Boolean contains = Visited.Any(x => x.Value == node.Value);// if visited node is in the list
                pathToAdd = Visited.ToArray();
                total = add(pathToAdd, graph);

                double subtotal = getDistanceBetween(new DirectedGraphNode<string>(Visited.Last.Value.Value.ToString()), new DirectedGraphNode<string>(node.Value.ToString()), graph);
                subtotal += total;

                //if the total is greater than or equal to the max dist then contine
                if (subtotal >= maxDistance)
                {
                    continue;
                }                                                                                                                                                                                  
                if ((node.Value == End.Value))
                {
                    Visited.AddLast(node);

                    pathToAdd = Visited.ToArray();
                    total = add(pathToAdd, graph);
                    printPath(Visited, total, ref listPair);  
                    Visited.RemoveLast();//remove last node when it is found
                    break;
                }
            }//foreach
            //recurse afer checking and examining all nodes
            foreach (DirectedGraphNode<string> node in nodes)
            {
                Boolean contain = Visited.Any(x => x.Value == node.Value);
                if (contain == true || node.Value == End.Value)
                {
                    continue;
                }
                Visited.AddLast(node);
                pathToAdd = Visited.ToArray();
                total = add(pathToAdd, graph);


                depthSearch(graph, Visited, start, End, maxDistance, ref listPair);//recall the method
                Visited.RemoveLast();
            }
        }

        private void printPath(LinkedList<DirectedGraphNode<string>> visited, double total, ref List<KeyValuePair<string, double>> ListPair)
        {
            string strgroupids;
            StringBuilder cb = new StringBuilder();
            foreach (DirectedGraphNode<string> node in visited)
            {
                cb.Append(node.Value + ",");

            }
            if (cb.ToString().EndsWith(","))
            {
                strgroupids = cb.ToString().Substring(0, cb.ToString().Length - 1);
                ListPair.Add(new KeyValuePair<string, double>(strgroupids, total));
            }

        }

        //method to check what are neighbours of the last node in the list 
        private LinkedList<DirectedGraphNode<string>> getNeighboursAdjecentNodes(GraphDeclare<string> graph, DirectedGraphNode<string> n)
        {
            LinkedList<DirectedGraphNode<string>> neighbours = new LinkedList<DirectedGraphNode<string>>();

            foreach (DirectedGraphNode<string> edge in graph.nodeSet)
            {

                if (edge.Value.Equals(n.Value))
                {
                    foreach (DirectedGraphNode<string> neighbour in edge.NeighbourNodes)
                    {
                        neighbours.AddLast(neighbour);
                    }

                }
            }

            return neighbours;
        }
        //add method used throughougt the application 
        public double add(DirectedGraphNode<string>[] pathToAdd, GraphDeclare<string> graph)
        {
            int counter = 0;
            double totalDistance = 0;
            for (int cntA = 0; cntA < pathToAdd.Count(); ++cntA)
            {
                counter = cntA + 1;
                if (counter != pathToAdd.Count())
                {
                    double total = getDistanceBetween(new DirectedGraphNode<string>(pathToAdd[cntA].Value.ToString()), new DirectedGraphNode<string>(pathToAdd[counter].Value.ToString()), graph);
                    if (total == 0.0)
                    {
                        result.Text = "No Such Route Exists";
                        return 0;
                        
                        // break;
                    }
                    else
                    {
                        totalDistance = totalDistance + total;
                        result.Text = totalDistance.ToString();

                    }
                }//dist Calc

            }//cnt
            return totalDistance;
        }


        //return the distance between the 2 nodes in question through this method
        public double getDistanceBetween(DirectedGraphNode<string> u, DirectedGraphNode<string> v,  GraphDeclare<string> graph)
        {
            foreach (DirectedGraphNode<string> first in graph.nodeSet)
            {
                if (first.Value.Equals(u.Value))
                {


                    foreach (DirectedGraphNode<string> neighbour in first.NeighbourNodes)
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
    }

}
