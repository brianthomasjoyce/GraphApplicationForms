using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphApplicationForms
{
    public partial class Form1 : Form
    {

        private GraphDeclare<string> graph;
        private RouteQuestions routes;
        private LinkedList<DirectedGraphNode<string>> listOfNodes;
        public Form1()
        {
        
            InitializeComponent();
            graph = new GraphDeclare<string>();
            listOfNodes = new LinkedList<DirectedGraphNode<string>>();
        }

        private void btn_open_file_dialog_Click(object sender, EventArgs e)
        {
           // Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string strfilename = openFileDialog1.FileName;

                textBox_GetTextFile.Text = strfilename;

            }
        }

        private void textBox_GetTextFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listView_coordinates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_LoadTextFile_Click(object sender, EventArgs e)
        {
            //intance of the graph and pass it to the load class to populate all nodes

            if(textBox_GetTextFile.Text=="")
            {
                ExceptionLabel.Text = "Cannot process as file is not valid";
            }
            else if(!textBox_GetTextFile.Text.EndsWith(".txt"))
            {
                ExceptionLabel.Text = "Not a Valid Text File";
            }
            else
            {
                LoadTextFile<string> load = new LoadTextFile<string>(label3, textBox_GetTextFile.Text, graph);
                this.tabControl1.SelectedTab = this.tabControl1.TabPages["tabPage2"];
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button_calcResult_Click(object sender, EventArgs e)
        {

            bool error = false;
            if(textBox2_noOfTrips.Text!="" &&textBox_minStops.Text!="")
            {
                int max, min;
                if(int.TryParse(textBox2_noOfTrips.Text,out max))
                {
                    if (int.TryParse(textBox_minStops.Text, out min))
                    {
                        if(min> max)
                        {
                            MessageBox.Show("Min Number of stops cannot be greater than max number of stops");
                            error = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Minimum number of stops Must be an integer. ");
                        error = true;
                    }
                }
                else
                {
                    MessageBox.Show("Maximum number of stops Must be an integer. ");
                    error = true;
                }
            }

            
            if(radioButton1_add.Checked ==true && !error)
            {
                DirectedGraphNode<string>[] pathToParse = new ParsePath(textBox1_add.Text).processPath();
                new depthFirst<string>(pathToParse, label_result).add(pathToParse, graph);
            }
            if (radioButton2_NoOfTrips.Checked == true && !error)
            {
                routes = new RouteQuestions(graph, listOfNodes, double.MaxValue, new DirectedGraphNode<string>(textBox4_from.Text), new DirectedGraphNode<string>(textBox4_to.Text), label_result);
                routes.NumberOfTripsWithMaxOF(textBox2_noOfTrips, textBox_minStops);
            }

            if (radioButton3_shortestRoute.Checked == true && !error)
            {
                routes = new RouteQuestions(graph, listOfNodes, double.MaxValue, new DirectedGraphNode<string>(textBox4_from.Text), new DirectedGraphNode<string>(textBox4_to.Text), label_result);
                routes.CalcShortestRoute();
            }

            if (radioButton4_noOfRoutes.Checked == true && !error)
            {
                routes = new RouteQuestions(graph, listOfNodes, Convert.ToDouble(TxtBox_lessThanDist.Text),new DirectedGraphNode<string>(textBox4_from.Text), new DirectedGraphNode<string>(textBox4_to.Text), label_result);
                routes.calculateNumberOfRoutes();
            }
        }

        private void label_result_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_add_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1_add.Checked == true)
            {
                textBox4_from.Clear();
                textBox4_to.Clear();
                textBox4_to.ReadOnly = true;

                textBox4_from.ReadOnly = true;
            }
            else
            {         
                textBox4_to.ReadOnly = false;
                textBox4_from.ReadOnly = false;
            }

        }

        private void TxtBox_lessThanDist_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
