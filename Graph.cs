using System;
using System.Collections.Generic;
using System.IO.Pipes;
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
        public string res;

        public Graph()
        {
            Edges = new List<Bush<T>>(20);
        }

        public string GetGraph()
        {
            string graph = String.Empty;
            foreach(Bush<T> n in Edges)
            {
                graph += n.Name.ToString() + ": ";
                foreach(Bush<T> i in n.Neigh)
                {
                    graph += i.Name.ToString() + ", ";
                }
                graph = graph[..^2];
                graph += "\n";
            }
            return graph;
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
        public void AddEdge(Bush<T> x, List<Bush<T>> List)
        {
            bool IsExistX = false;
            foreach (var node in Edges)
            {
               if (node.Name.Equals(x.Name))
                {
                    IsExistX = true;
                    foreach(var vortex in List)
                    {
                        node.Neigh.Add(vortex);
                        if (!Edges.Contains(vortex)) { this.AddNode(vortex); }
                    }
                }
            }
            if (!IsExistX)
            {
                MessageBox.Show("Такой вершины не существует");
            }
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
                    res += (string.Join("-", tabu)) + "\r\n";
                    _DepthTravel(vortex, tabu);
                    tabu.Remove(vortex.Name);
                }
            }
        }

        public void DepthTravel(T name) // Обход в глубину
        {
            var tabu = new List<T> { name };
            res = String.Empty;
            bool IsExists = false;
            foreach (var node in Edges)
            {
                if (node.Name.Equals(name))
                {
                    IsExists = true;
                    if (node.Neigh.Count == 0)
                    {
                        MessageBox.Show("У вершины нет соседей");
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
        public void _BreadthTravel(Bush<T> node, List<T> internals)
        {
            internals.Add(node.Name);
            var externals = new List<Bush<T>>();
            foreach(var vortex in node.Neigh)
            {
                if (!internals.Contains(vortex.Name))
                {
                    externals.Add(vortex);
                    res += String.Join('-', internals) + '-' + vortex.Name + "\r\n";
                }
            }
            foreach(var vortex in externals)
            {
                _BreadthTravel(vortex, internals);
                internals.Remove(vortex.Name);
            }
        }
            
        public void BreadthTravel(T name) // обход в ширину
        {
            res = String.Empty;
            bool IsExists = false;
            var internals = new List<T>(); // пройденные вершины
            foreach(var node in Edges)
            {
                if (node.Name.Equals(name))
                {
                    IsExists = true;
                    if (node.Neigh.Count == 0) { MessageBox.Show("У вершины нет соседей"); return; }
                    _BreadthTravel(node, internals);
                    return;
                }
            }
            if (!IsExists) { MessageBox.Show("Такой вершины не существует"); }
        } 
    }
}
