using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphApplicationForms
{
    public class RouteQuestions
    {
        private GraphDeclare<string> graph;
        private double Max;
        private DirectedGraphNode<string> EndNode;
        private DirectedGraphNode<string> StartNode;
        private LinkedList<DirectedGraphNode<string>> nodesList;
        private Label ResLabel;
        private depthFirst<string> depthFirst;
        private List<KeyValuePair<string, double>> listPairResults; //list pair passed to depth first search by reference
        private List<KeyValuePair<string, double>> sublist;
        private StringBuilder sb;
        private ParsePath parsePath;
        private List<KeyValuePair<string, double>> resultList;

        public RouteQuestions(GraphDeclare<string> graph, LinkedList<DirectedGraphNode<string>> depthList, double maximum, DirectedGraphNode<string> start, DirectedGraphNode<string> end, Label label)
        {
            this.graph = graph;
            this.Max = maximum;
            this.EndNode = end;
            this.StartNode = start;
            this.nodesList = new LinkedList<DirectedGraphNode<string>>();
            this.listPairResults = new List<KeyValuePair<string, double>>();
            this.sublist = new List<KeyValuePair<string, double>>();
            this.ResLabel = label;
            this.sb = new StringBuilder();
            this.depthFirst = new depthFirst<string>(ResLabel);
            this.resultList = new List<KeyValuePair<string, double>>();
        }


        //Question 10 Number of Routes less than a number
        public void calculateNumberOfRoutes()
        {
            double reducedSubMaximum = 0;
            nodesList.AddLast(StartNode);
            string path;

            //get all paths between the 2 nodes without repeating
            depthFirst.depthSearch(graph, nodesList, new DirectedGraphNode<string>(StartNode.Value), new DirectedGraphNode<string>(EndNode.Value), Max, ref listPairResults);

            sublist.AddRange(listPairResults);
            listPairResults.Clear();                     //clear list pair so to get results for the reduced maximum number
           
            for (int i = 0; i<sublist.Count(); ++i)     //return the list by reference and then begin searching for paths by reducing the max dist to the path dist minus the max and concatanting both strings
            {
                KeyValuePair<string, double> element = sublist[i]; 
                string[] elementArray = element.Key.Split(','); //load the pair into an array splitting by the delimeter

                reducedSubMaximum = Max - element.Value; //return the list by reference and then begin searching for paths by reducing the max dist to the path dist minus the max and concatanting both strings
                depthFirst.depthSearch(graph, nodesList, new DirectedGraphNode<string>(StartNode.Value), new DirectedGraphNode<string>(EndNode.Value), reducedSubMaximum, ref listPairResults);

                 //if results are returned
                if(listPairResults.Count>0)
                {
                    foreach(var res in listPairResults) //foreach result returned the second time
                    {
                        string[] resArray = res.Key.Split(','); //load into a results array
                            //add them to the list and concatonate all possible combinations

                        
                        //if the last node of the result returned is equal to the first node of the result drawn the second time
                            if (elementArray[elementArray.Count()-1].ToString()==(EndNode.Value.ToString()) && (resArray[0].ToString()==(EndNode.Value.ToString())))
                            {
                                    //check to see if they are neighbour nodes
                                if (findNeigbours(EndNode.Value.ToString(), resArray[1].ToString()))
                                {

                                    //combine the path and athe add the result
                                    path = conCatPath(elementArray, resArray, 1);

                                    sublist.Add(new KeyValuePair<string, double>(path, element.Value + res.Value));
                                }//if find neighbours
                            }//if element ends with
                                //this is if the last node of the first list and the first node of the last list are the same
                            else
                            {
                                //if the last node of the first array and the first node of the second array are different
                                for (int cnt = 0; cnt < resArray.Count(); ++cnt)
                                {
                                   //then check each node in the array that they are neigbours 
                                    if (findNeigbours(elementArray[elementArray.Count() - 1].ToString(), resArray[cnt].ToString()))
                                    {
                                        
                                        path = conCatPath(elementArray, resArray, cnt);
                                        //length = string.Concat(element.Key.ToString(), res.Key.Substring(cnt));
                                        //need to check the total of the concatenated list
                                        if (TotalPath(path) < Max && !sublist.Contains(new KeyValuePair<string,double>(path, TotalPath(path))))
                                        {
                                            sublist.Add(new KeyValuePair<string, double>(path, TotalPath(path)));
                                        }//total path
                                    }//if find neighbours
                                }
                            }//else
                    }           
                }//if list pair results
                listPairResults.Clear();//clear the list passed by reference
            }//sublist count
            
            foreach(var element in sublist)  //for all elements in the list output them in label
            {
                sb.Append(element.Key + "--" + element.Value + "\n");
            }

            ResLabel.Text = sb.ToString() + "\n" + sublist.Count().ToString();
            //Console.WriteLine(element.Key + " " + element.Value + "\n");
           
           Console.ReadLine();
        }//calculate number of Routes

        public void CalcShortestRoute()
        {
            nodesList.AddLast(StartNode);// add the start node
            depthFirst.depthSearch(graph, nodesList, new DirectedGraphNode<string>(StartNode.Value), new DirectedGraphNode<string>(EndNode.Value), double.MaxValue, ref listPairResults);//call the method passing all parameters

            sublist.Clear();//clear the list
            sublist.AddRange(listPairResults); //add the list to the temp list again

                foreach(var element in sublist) //output all routes
                {
                    sb.Append(element.Key + "--" + element.Value + "\n");
                }

            double min = sublist.Min(x => x.Value); //workout the min shortest route
            ResLabel.Text = sb.ToString() + "\n" + "The smallest Length is: " + min.ToString() + "\n"; // output to user
        }
        /// <summary>
        /// /////////////////////////////////////////////////
        /// </summary>
        /// <param name="Textbox"></param>
        /// 


        public void NumberOfTripsWithMaxOF(TextBox TextboxMax, TextBox TextBoxMin)
        {
            int MaxNoOFTrips = Convert.ToInt32(TextboxMax.Text);
            int MinNumOfTrips = Convert.ToInt32(TextBoxMin.Text);

            string[] fullpath;
            nodesList.AddLast(StartNode);
            //get all paths between the 2 nodes without repeating
            depthFirst.depthSearch(graph, nodesList, new DirectedGraphNode<string>(StartNode.Value), new DirectedGraphNode<string>(EndNode.Value), Max, ref listPairResults);

            foreach(var path in listPairResults) //for all the paths returned in the search 
            {
                string[] tempPath = path.Key.Split(','); //path split into an array
                if(tempPath.Count() <= (MaxNoOFTrips+1))
                {
                    sublist.Add(new KeyValuePair<string, double>(path.Key, path.Value));

                    if (MinNumOfTrips < tempPath.Count())
                    {
                        resultList.Add(new KeyValuePair<string, double>(path.Key, path.Value));
                    }
                }                
            }   
            //clear list pair so to get results for the reduced maximum number
            listPairResults.Clear();
            //return the list by reference and then begin searching for paths by reducing the max dist to the path dist minus the max and concatanting both strings
            for (int i = 0; i < sublist.Count(); ++i)
            {
                KeyValuePair<string, double> element = sublist[i];
                //reduce the max distance to find the result of the reduced max distance
                string[] elementArray = element.Key.Split(',');//load elements into the array
                depthFirst.depthSearch(graph, nodesList, new DirectedGraphNode<string>(StartNode.Value), new DirectedGraphNode<string>(EndNode.Value), double.MaxValue, ref listPairResults);
                //if results are returned
                if (listPairResults.Count > 0)
                {
                    foreach (var res in listPairResults)
                    {
                        string[] listPairResultsArray = res.Key.Split(',');
                                for (int cnt = 0; cnt < listPairResultsArray.Count(); cnt++)//loop through all characters of the res with the main and see if they are neighbour nodes
                                {
                                    if (findNeigbours(EndNode.Value.ToString(), listPairResultsArray[cnt].ToString()))//check to see if end node and other node are connected
                                    {

                                        fullpath = conCatPath(elementArray, listPairResultsArray, cnt).Split(',');
                                        

                                     //   length = string.Concat(element.Key + res.Key.Substring(cnt));//concat the nodeset if neighbours are found
                                        //then see if the length is smaller, bigger or equal to the amount of trips allowed
                                        if (fullpath.Count()<= (MaxNoOFTrips+1)&& fullpath.Count()> MinNumOfTrips)//if the length of the nodeset is bigger than the amount of trips then don't add, else ad
                                        {
                                            resultList.Add(new KeyValuePair<string, double>(string.Concat(element.Key + res.Key.Substring(cnt)), element.Value + res.Value));
                                            break;
                                        }
                                    }//if
                                }//for
                    }
                }
                listPairResults.Clear();//clear the list passed by reference
            }//forloop

            foreach (var element in resultList)  //for all elements in the list output them in label
            {
                sb.Append(element.Key + "--" + element.Value + "\n");
            }
            ResLabel.Text = sb.ToString() + "\n" + resultList.Count().ToString();
            //Console.WriteLine(element.Key + " " + element.Value + "\n");

            Console.ReadLine();


        }

        public Boolean findNeigbours(string a, string b)
        {
            DirectedGraphNode<string> nodeA = (DirectedGraphNode<string>)graph.nodeSet.FindByValue(a); //look for node a and node be in the list
            DirectedGraphNode<string> nodeB = (DirectedGraphNode<string>)graph.nodeSet.FindByValue(b);   //assign values and then connect both with a weight length

            if (nodeA.NeighbourNodes.Contains(nodeB))
            {
                return true;
            }

            return false;
        }

        //add totals through calling the other methods declared in the program
        public double TotalPath(string nodePath) 
        {
            parsePath = new ParsePath(nodePath);
            DirectedGraphNode<string>[] path = parsePath.processPath();
            double total = depthFirst.add(path,graph);

            return total;
        }

        //join all related nodes together in this path
        public string conCatPath(string[] initialPath, string[] FinalPath, int index)
        {
            string path;
            StringBuilder sb = new StringBuilder();
            for (int cnt = 0; cnt < initialPath.Count(); ++cnt)
            {
                sb.Append(initialPath[cnt].ToString() + ",");
            }

            for (int cntA = index; cntA < FinalPath.Count(); ++cntA)
            {
                sb.Append(FinalPath[cntA].ToString() + ",");
            }

            path = sb.ToString().Substring(0, sb.ToString().Length - 1);

                return path;
        }

        

        

    }   
}
