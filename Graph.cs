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
       
        private Stack<Bush<T>> nodes_stack = new Stack<Bush<T>>();
        private Stack<List<T>> paths_stack = new Stack<List<T>>();
        private Queue<Bush<T>> nodes_queue = new Queue<Bush<T>>();
        private Queue<List<T>> paths_queue = new Queue<List<T>>(); 
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

        private void _DepththTravel(Bush<T> node, List<T> internals)
        {
            List<T> path = new List<T>(internals);
            path.Add(node.Name);
            foreach (var vortex in node.Neigh)
            {
                if (!path.Contains(vortex.Name))
                {
                    nodes_stack.Push(vortex);
                    paths_stack.Push(path);
                }
            }
            if (path.Count > 1) { res += String.Join('-', path) + "\r\n"; }
            if (nodes_stack.Count > 0)
            {
                _DepththTravel(nodes_stack.Pop(), paths_stack.Pop());
            }
        }

        public void DepthTravel(T name) // обход в ширину
        {
            res = String.Empty;
            bool IsExists = false;
            var internals = new List<T>(); // пройденные вершины
            foreach (var node in Edges)
            {
                if (node.Name.Equals(name))
                {
                    IsExists = true;
                    if (node.Neigh.Count == 0) { MessageBox.Show("У вершины нет соседей"); return; }
                    _DepththTravel(node, internals);
                    return;
                }
            }
            if (!IsExists) { MessageBox.Show("Такой вершины не существует"); }
        }

        private void _BreadthTravel(Bush<T> node, List<T> internals)
        {
            List<T> path = new List<T>(internals);
            path.Add(node.Name);
            foreach(var vortex in node.Neigh)
            {
                if (!path.Contains(vortex.Name))
                {
                    nodes_queue.Enqueue(vortex);
                    paths_queue.Enqueue(path);
                    res += String.Join('-', path) + '-' + vortex.Name + "\r\n";
                }
            }
            if (nodes_queue.Count > 0)
            {
                _BreadthTravel(nodes_queue.Dequeue(), paths_queue.Dequeue());
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
                    paths_queue.Clear();
                    return;
                }
            }
            if (!IsExists) { MessageBox.Show("Такой вершины не существует"); }
        } 
    }
}
