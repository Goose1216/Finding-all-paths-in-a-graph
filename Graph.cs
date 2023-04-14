using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Program
{
    internal class Graph<T>
    {
        private List<Bush<T>> Edges;

        public Graph()
        {
            Edges = new List<Bush<T>>(20);
        }

        public string GetGraph()
        {
            string res = String.Empty;
            foreach(Bush<T> n in Edges)
            {
                res += n.Name.ToString() + ": ";
                foreach(Bush<T> i in n.Neigh)
                {
                    res += i.Name.ToString() + ", ";
                }
                res = res[..^2];
                res += "\n";
            }
            return res;
        }
        public void AddNode(Bush<T> x) 
        {
            foreach (var edge in Edges)
            {
                if (edge.Name.Equals(x.Name))
                {
                    MessageBox.Show("Такая вершина уже существует");
                    return;
                }
            }
            Edges.Add(x);
        }

        public void AddNode(T name, List<Bush<T>> edges) 
        {
            foreach (var edge in Edges)
            {
                if (edge.Name.Equals(name))
                {
                    MessageBox.Show("Такая вершина уже существует");
                    return;
                }
            }
            Edges.Add(new Bush<T>(name, edges));
        }

        public void AddEdge(Bush<T> x, Bush<T> y)
        {
            int cntVortex = 0;
            foreach (var node in Edges)
            {
                if (cntVortex == 2) { break; }
                else if (node.Name.Equals(x.Name))
                {
                    node.Neigh.Add(y);
                    cntVortex++;
                }
                else if (node.Name.Equals(y.Name))
                {
                    cntVortex++;
                }
            }
            if (cntVortex != 2) { MessageBox.Show("Одна из вершин не существует"); }
        }

        public void _DepthTravel(Bush<T> node, List<T> tabu)
        {
            foreach(var vortex in node.Neigh)
            {
                if (!tabu.Contains(vortex.Name))
                {
                    tabu.Add(vortex.Name);
                    _DepthTravel(vortex, tabu);
                    tabu.Remove(vortex.Name);
                }
            }
            if (tabu.Count > 1)
            {
                MessageBox.Show(string.Join("-", tabu));
            }
        }

        public void DepthTravel(T name) // Обход в глубину
        {
            var tabu = new List<T> { name };
            string res = String.Empty;
            bool IsExists = false;
            foreach (var node in Edges)
            {
                if (node.Name.Equals(name))
                {
                    IsExists = true;
                    if (node.Neigh.Count == 0)
                    {
                        MessageBox.Show("Конечная вершина");
                        return;
                    }
                    _DepthTravel(node, tabu);
                }
            }
            if (!IsExists)
            {
                MessageBox.Show("Такой вершины не существует");
            }
            
        }
    }
}
