using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;
namespace GraphApplicationForms
{
    public class LoadTextFile<L>
    {

        private string TextFile; //text file 
        private Label label;//label
        private GraphDeclare<string> graph; //declare graph instance
        private string from, to; //declare from and to variables
        private string[] fields;
        private int weight;


        public LoadTextFile(Label label, string file, GraphDeclare<string> graph)
        {
            // construct text file and pass intance of graph
            this.label = label; //label to display details
            TextFile = file; //text file with co-ordinates
            this.graph = graph; //graph
            populate();  // call the populate to fill the graph with values
        }

        public void populate()
        {
            using(TextFieldParser parser = new TextFieldParser(TextFile))  // pass text file
            {
                parser.Delimiters = new string[] { "," }; //set the delimeter
                StringBuilder sb = new StringBuilder();
                
                while (true) //while looping 
                {
                    fields = parser.ReadFields();
                    if (fields == null)
                    {

                        break;
                    }
                    else
                    {
                        from = fields[0].ToString(); //get value from
                        to = fields[1].ToString(); //get value to
                        weight = Convert.ToInt16(fields[2]); //get weight

                        //check of nodeset has the values of from, to and then add the associated weight to the edge
                        if(!graph.containsValue(from))
                        {
                            graph.AddNode(new DirectedGraphNode<string>(from));
                        }
                        if (!graph.containsValue(to)) //if it doesnt have a to value then add it.
                        {
                            graph.AddNode(new DirectedGraphNode<string>(to));
                        }
                        graph.AddDirectedEdgeToTheGraph(from, to, weight); // add the appropriate cost to the graph

                    }
                }
            }

            displayNodesWithNeighbours();
        }

        private void displayNodesWithNeighbours()  //displays to the second tab all node and their neighbours
        {
            StringBuilder sb = new StringBuilder();

            foreach(DirectedGraphNode<string> node in graph.nodeSet) //go through the graph nodes
            {

                sb.Append(node.Value + "-" + " ");
                foreach(DirectedGraphNode<string> neighbour in node.NeighbourNodes) //loop through the neighbours of those nodes
                {

                    sb.Append(neighbour.Value + " "); 
                }
                sb.Append("\n");

            }

            label.Text = sb.ToString();
        }
    }
}
