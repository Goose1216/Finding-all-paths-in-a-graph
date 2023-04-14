namespace Program
{
    public partial class Form1 : Form
    {
        Graph<int> graph;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Test
            graph = new Graph<int>();
            Bush<int> o = new Bush<int>(0);
            Bush<int> a = new Bush<int>(1);
            Bush<int> b = new Bush<int>(2);
            Bush<int> c = new Bush<int>(3);
            Bush<int> d = new Bush<int>(4, new List<Bush<int>> { a, b}); // 1 2 
            Bush<int> e1 = new Bush<int>(5, new List<Bush<int>> { a, b, c }); // 1 2 3
            Bush<int> f = new Bush<int>(6, new List<Bush<int>> {e1, d, c});// 5 4 3
            graph.AddNode(a);
            graph.AddNode(b);
            graph.AddNode(c);
            graph.AddNode(d);
            graph.AddNode(e1);
            graph.AddNode(f);
            graph.AddEdge(a, b);
            graph.AddEdge(a, c);
            graph.AddEdge(a, d);
            graph.AddEdge(a, e1);
            graph.AddEdge(a, f);
            graph.AddEdge(f, a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graph.BreadthTravel(2);
            MessageBox.Show(graph.GetGraph());
        }
    }
}