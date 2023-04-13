namespace Program
{
    public partial class Form1 : Form
    {
        Graph graph;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(graph.GetGraph());
        }
    }
}