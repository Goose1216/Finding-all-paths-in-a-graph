using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Program
{
    internal class Graph
    {
        private List<Bush> Edges;

        public Graph()
        {
            Edges = new List<Bush>(20);
        }

        public string GetGraph()
        {
            string res = String.Empty;
            foreach(Bush n in Edges)
            {
                res += n.Name.ToString() + ": ";
                foreach(int i in n.Neigh)
                {
                    res += i.ToString() + ", ";
                }
                res = res[..^2];
                res += "\n";
            }
            return res;
        }
        public void AddNode(Bush x) 
        {
            foreach (var edge in Edges)
            {
                if (edge.Name == x.Name)
                {
                    MessageBox.Show("Такая вершина уже существует");
                    return;
                }
            }
            Edges.Add(x);
        }

        public void AddNode(int name, List<int> edges) 
        {
            foreach (var edge in Edges)
            {
                if (edge.Name == name)
                {
                    MessageBox.Show("Такая вершина уже существует");
                    return;
                }
            }
            Edges.Add(new Bush(name, edges));
        }
        

    }
}
