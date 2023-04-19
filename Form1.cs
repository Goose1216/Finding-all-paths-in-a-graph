namespace Program
{
    public partial class Form1 : Form
    {
        Graph<int> graph1;
        Graph<int> graph2;
        Graph<int> graph3;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Graph1
            graph1 = new Graph<int>();
            Bush<int> a1 = new Bush<int>(1); graph1.AddNode(a1);
            Bush<int> b1 = new Bush<int>(2); graph1.AddNode(b1);
            Bush<int> c1 = new Bush<int>(3); graph1.AddNode(c1);
            Bush<int> d1 = new Bush<int>(4); graph1.AddNode(d1);
            Bush<int> e1 = new Bush<int>(5); graph1.AddNode(e1);
            Bush<int> f1 = new Bush<int>(6); graph1.AddNode(f1);
            Bush<int> g1 = new Bush<int>(7); graph1.AddNode(g1);
            Bush<int> h1 = new Bush<int>(8); graph1.AddNode(h1);
            Bush<int> n1 = new Bush<int>(9); graph1.AddNode(n1);
            Bush<int> m1 = new Bush<int>(10);graph1.AddNode(m1);
            graph1.AddEdge(a1, new List<Bush<int>> { b1, c1, d1, e1 });
            graph1.AddEdge(c1, h1);
            graph1.AddEdge(h1, n1);
            graph1.AddEdge(b1, new List<Bush<int>> { f1, g1 });
            graph1.AddEdge(f1, m1);
            //Tests
            graph1.AddEdge(d1, c1);
        }

        private void PrintGraph1()
        {
            g = CreateGraphics();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bredth.Enabled = true;
            Depth.Enabled = true;
            g = CreateGraphics();
            g.DrawEllipse(Pens.Black, 200,200,300,200);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PathsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bredth_Click(object sender, EventArgs e)
        {
            try 
            {
                graph1.BreadthTravel(int.Parse(VortexBox.Text));
                PathsTextBox.Text = graph1.res;
            }
            catch
            {
                MessageBox.Show("Некоректо введённые данные");
            }
        }

        private void Depth_Click(object sender, EventArgs e)
        {
            try
            {
                graph1.DepthTravel(int.Parse(VortexBox.Text));
                PathsTextBox.Text = graph1.res;
            }
            catch
            {
                MessageBox.Show("Некоректо введённые данные");
            }
        }
    }
}