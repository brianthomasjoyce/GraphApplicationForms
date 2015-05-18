using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApplicationForms
{
    public class ParsePath
    {

        private string pathToParse;

        public ParsePath(string path)
        {
            this.pathToParse = path;
        }

        public DirectedGraphNode<string>[] processPath() // parse the add to split the variables by comma
        {

            string[] PathArray = pathToParse.Split(',');
            List<DirectedGraphNode<string>> nodes = new List<DirectedGraphNode<string>>(); //list of nodes
            DirectedGraphNode<string>[] path;
            foreach(string s in PathArray)
            {
                nodes.Add(new DirectedGraphNode<string>(s));
            }

            path = nodes.ToArray();

            return path;
        }


    }

}

  
