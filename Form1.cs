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
            graph1.AddEdge(g1, f1);
            graph1.AddEdge(d1, new List<Bush<int>> { a1, c1 });
        }

        private void PrintGraph1()
        {
            g = CreateGraphics();
            Brush brush1 = new SolidBrush(Color.PeachPuff);
            Brush brush2 = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
            Font font = new Font("Arial", 16);

            g.FillEllipse(brush1, 550, 300, 50, 50);
            g.DrawString("1", font, brush2, 565, 310);

            g.FillEllipse(brush1, 550, 225, 50, 50);
            g.DrawString("2", font, brush2, 565, 235);
            g.DrawLine(pen, 575, 275, 575, 300);
            g.DrawLine(pen, 575, 275, 580, 280);
            g.DrawLine(pen, 575, 275, 570, 280);

            g.FillEllipse(brush1, 550, 375, 50, 50);
            g.DrawString("4", font, brush2, 565, 385);
            g.DrawLine(pen, 580, 350, 580, 375);
            g.DrawLine(pen, 580, 375, 585, 370);
            g.DrawLine(pen, 580, 375, 575, 370);
            g.DrawLine(pen, 570, 350, 570, 375);
            g.DrawLine(pen, 570, 350, 575, 355);
            g.DrawLine(pen, 570, 350, 565, 355);

            g.FillEllipse(brush1, 475, 300, 50, 50);
            g.DrawString("5", font, brush2, 490, 315);
            g.DrawLine(pen, 525, 325, 550, 325);
            g.DrawLine(pen, 525, 325, 530, 330);
            g.DrawLine(pen, 525, 325, 530, 320);

            g.FillEllipse(brush1, 625, 300, 50, 50);
            g.DrawString("3", font, brush2, 640, 315);
            g.DrawLine(pen, 600, 325, 625, 325);
            g.DrawLine(pen, 625, 325, 620, 330);
            g.DrawLine(pen, 625, 325, 620, 320);
            g.DrawLine(pen, 600, 400, 650, 350);
            g.DrawLine(pen, 650, 350, 655, 357);
            g.DrawLine(pen, 650, 350, 640, 352);

            g.FillEllipse(brush1, 700, 300, 50, 50);
            g.DrawString("8", font, brush2, 715, 315);
            g.DrawLine(pen, 675, 325, 700, 325);
            g.DrawLine(pen, 700, 325, 695, 330);
            g.DrawLine(pen, 700, 325, 695, 320);

            g.FillEllipse(brush1, 775, 300, 50, 50);
            g.DrawString("9", font, brush2, 790, 315);
            g.DrawLine(pen, 750, 325, 775, 325);
            g.DrawLine(pen, 775, 325, 770, 330);
            g.DrawLine(pen, 775, 325, 770, 320);

            g.FillEllipse(brush1, 475, 225, 50, 50);
            g.DrawString("6", font, brush2, 490, 235);
            g.DrawLine(pen, 550, 250, 525, 250);
            g.DrawLine(pen, 525, 250, 530, 255);
            g.DrawLine(pen, 525, 250, 530, 245);

            g.FillEllipse(brush1, 475, 150, 50, 50);
            g.DrawString("10", font, brush2, 485, 160);
            g.DrawLine(pen, 500, 225, 500, 200);
            g.DrawLine(pen, 500, 200, 505, 205);
            g.DrawLine(pen, 500, 200, 495, 205);

            g.FillEllipse(brush1, 550, 150, 50, 50);
            g.DrawString("7", font, brush2, 565, 160);
            g.DrawLine(pen, 575, 225, 575, 200);
            g.DrawLine(pen, 575, 200, 580, 205);
            g.DrawLine(pen, 575, 200, 570, 205);
            g.DrawLine(pen, 550, 175, 515, 230);
            g.DrawLine(pen, 515, 230, 525, 225);
            g.DrawLine(pen, 515, 230, 515, 220);

        }
        private void PrintGraph2()
        {
            g = CreateGraphics();

        }
        private void PrintGraph3()
        {
            g = CreateGraphics();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bredth.Enabled = true;
            Depth.Enabled = true;
            // выбор графа
            PrintGraph1();


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