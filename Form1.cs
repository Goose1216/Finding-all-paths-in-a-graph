namespace Program
{
    public partial class Form1 : Form
    {
        Graph<int> graph1;
        Graph<int> graph2;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Граф 1", "Граф 2"});
            g = CreateGraphics();
            CreateGraph1();
            CreateGraph2();
        }
        private void CreateGraph1()
        {
            graph1 = new Graph<int>();
            Bush<int> a = new Bush<int>(1); graph1.AddNode(a);
            Bush<int> b = new Bush<int>(2); graph1.AddNode(b);
            Bush<int> c = new Bush<int>(3); graph1.AddNode(c);
            Bush<int> d = new Bush<int>(4); graph1.AddNode(d);
            Bush<int> e = new Bush<int>(5); graph1.AddNode(e);
            Bush<int> f = new Bush<int>(6); graph1.AddNode(f);
            Bush<int> g = new Bush<int>(7); graph1.AddNode(g);
            Bush<int> h = new Bush<int>(8); graph1.AddNode(h);
            Bush<int> n = new Bush<int>(9); graph1.AddNode(n);
            Bush<int> m = new Bush<int>(10); graph1.AddNode(m);
            graph1.AddEdge(a, new List<Bush<int>> { b, c, d, e });
            graph1.AddEdge(c, h);
            graph1.AddEdge(h, n);
            graph1.AddEdge(b, new List<Bush<int>> { f, g });
            graph1.AddEdge(f, m);
            graph1.AddEdge(g, f);
            graph1.AddEdge(d, new List<Bush<int>> { a, c });
        }
        private void CreateGraph2()
        {
            graph2 = new Graph<int>();
            Bush<int> a = new Bush<int>(1); graph2.AddNode(a);
            Bush<int> b = new Bush<int>(2); graph2.AddNode(b);
            Bush<int> c = new Bush<int>(3); graph2.AddNode(c);
            Bush<int> d = new Bush<int>(4); graph2.AddNode(d);
            Bush<int> e = new Bush<int>(5); graph2.AddNode(e);
            Bush<int> f = new Bush<int>(6); graph2.AddNode(f);
            Bush<int> g = new Bush<int>(7); graph2.AddNode(g);
            Bush<int> h = new Bush<int>(8); graph2.AddNode(h);
            Bush<int> n = new Bush<int>(9); graph2.AddNode(n);
            Bush<int> m = new Bush<int>(10); graph2.AddNode(m);
            Bush<int> x = new Bush<int>(11); graph2.AddNode(x);
            Bush<int> z = new Bush<int>(12); graph2.AddNode(z);
            Bush<int> v = new Bush<int>(13); graph2.AddNode(v);
            graph2.AddEdge(a, new List<Bush<int>> { b, c, d, e });
            graph2.AddEdge(c, new List<Bush<int>> { h, n });
            graph2.AddEdge(b, new List<Bush<int>> { g, f });
            graph2.AddEdge(d, new List<Bush<int>> { x, m });
            graph2.AddEdge(e, new List<Bush<int>> { z, v});
            graph2.AddEdge(h, n);
            graph2.AddEdge(n, h);
            graph2.AddEdge(f, g);
            graph2.AddEdge(g, f);
            graph2.AddEdge(z, v);
            graph2.AddEdge(v, z);
            graph2.AddEdge(m, x);
            graph2.AddEdge(x, m);
        }

        private void PrintGraph1()
        {
            Brush brush1 = new SolidBrush(Color.PeachPuff);
            Brush brush2 = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
            Font font = new Font("Arial", 16);
            g.Clear(Color.RosyBrown);

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
            g.Clear(Color.RosyBrown);
            Brush brush1 = new SolidBrush(Color.PeachPuff);
            Brush brush2 = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
            Font font = new Font("Arial", 16);

            g.FillEllipse(brush1, 550, 300, 50, 50);
            g.DrawString("1", font, brush2, 565, 310);

            g.FillEllipse(brush1, 550, 220, 50, 50);
            g.DrawString("2", font, brush2, 565, 235);
            g.DrawLine(pen, 575, 300, 575, 270);
            g.DrawLine(pen, 575, 270, 580, 275);
            g.DrawLine(pen, 575, 270, 570, 275);

            g.FillEllipse(brush1, 625, 300, 50, 50);
            g.DrawString("3", font, brush2, 640, 310);
            g.DrawLine(pen, 600, 325, 625, 325);
            g.DrawLine(pen, 625, 325, 620, 320);
            g.DrawLine(pen, 625, 325, 620, 330);

            g.FillEllipse(brush1, 550, 375, 50, 50);
            g.DrawString("4", font, brush2, 565, 385);
            g.DrawLine(pen, 575, 350, 575, 375);
            g.DrawLine(pen, 575, 375, 580, 370);
            g.DrawLine(pen, 575, 375, 570, 370);

            g.FillEllipse(brush1, 470, 300, 50, 50);
            g.DrawString("5", font, brush2, 485, 310);
            g.DrawLine(pen, 550, 325, 520, 325);
            g.DrawLine(pen, 520, 325, 525, 330);
            g.DrawLine(pen, 520, 325, 525, 320);

            g.FillEllipse(brush1, 475, 185, 50, 50);
            g.DrawString("6", font, brush2, 490, 200);
            g.DrawLine(pen, 550, 235, 522, 220);
            g.DrawLine(pen, 522, 220, 530, 217);
            g.DrawLine(pen, 522, 220, 524, 230);
            g.DrawLine(pen, 525, 200, 625, 200);
            g.DrawLine(pen, 625, 200, 620, 205);
            g.DrawLine(pen, 625, 200, 620, 195);
            g.DrawLine(pen, 525, 210, 625, 210);
            g.DrawLine(pen, 525, 210, 530, 205);
            g.DrawLine(pen, 525, 210, 530, 215);

            g.FillEllipse(brush1, 625, 185, 50, 50);
            g.DrawString("7", font, brush2, 640, 195);
            g.DrawLine(pen, 600, 240, 625, 220);
            g.DrawLine(pen, 625, 220, 620, 217);
            g.DrawLine(pen, 625, 220, 624, 228);

            g.FillEllipse(brush1, 700, 340, 50, 50);
            g.DrawString("9", font, brush2, 715, 350);
            g.DrawLine(pen, 675, 335, 700, 355);
            g.DrawLine(pen, 700, 355, 695, 360);
            g.DrawLine(pen, 700, 355, 700, 345);

            g.FillEllipse(brush1, 700, 240, 50, 50);
            g.DrawString("8", font, brush2, 715, 250);
            g.DrawLine(pen, 670, 310, 705, 280);
            g.DrawLine(pen, 705, 280, 705, 290);
            g.DrawLine(pen, 705, 280, 695, 280);
            g.DrawLine(pen, 735, 290, 735, 340);
            g.DrawLine(pen, 735, 340, 740, 335);
            g.DrawLine(pen, 735, 340, 730, 335);
            g.DrawLine(pen, 720, 290, 720, 340);
            g.DrawLine(pen, 720, 290, 725, 300);
            g.DrawLine(pen, 720, 290, 715, 300);

            g.FillEllipse(brush1, 400, 340, 50, 50);
            g.DrawString("13", font, brush2, 410, 350);
            g.DrawLine(pen, 478, 343, 450, 360);
            g.DrawLine(pen, 450, 360, 455, 350);
            g.DrawLine(pen, 450, 360, 460, 360);

            g.FillEllipse(brush1, 400, 240, 50, 50);
            g.DrawString("12", font, brush2, 410, 255);
            g.DrawLine(pen, 480, 305, 443, 280);
            g.DrawLine(pen, 443, 280, 447, 290);
            g.DrawLine(pen, 443, 280, 452, 280);
            g.DrawLine(pen, 435, 288, 435, 342);
            g.DrawLine(pen, 435, 342, 440, 337);
            g.DrawLine(pen, 435, 342, 430, 337);
            g.DrawLine(pen, 420, 288, 420, 342);
            g.DrawLine(pen, 420, 288, 425, 295);
            g.DrawLine(pen, 420, 288, 415, 295);

            g.FillEllipse(brush1, 475, 435, 50, 50);
            g.DrawString("11", font, brush2, 490, 450);
            g.DrawLine(pen, 515, 440, 550, 410);
            g.DrawLine(pen, 515, 440, 520, 430);
            g.DrawLine(pen, 515, 440, 525, 440);
            g.DrawLine(pen, 525, 450, 625, 450);
            g.DrawLine(pen, 625, 450, 620, 455);
            g.DrawLine(pen, 625, 450, 620, 445);
            g.DrawLine(pen, 525, 460, 625, 460);
            g.DrawLine(pen, 525, 460, 530, 455);
            g.DrawLine(pen, 525, 460, 530, 465);

            g.FillEllipse(brush1, 625, 435, 50, 50);
            g.DrawString("10", font, brush2, 640, 445);
            g.DrawLine(pen, 600, 410, 636, 440);
            g.DrawLine(pen, 636, 440, 640, 430);
            g.DrawLine(pen, 636, 440, 626, 440);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bredth.Enabled = true;
            Depth.Enabled = true;
            // выбор графа
            string graph_switch = comboBox1.SelectedItem.ToString();
            switch (graph_switch)
            {
                case "Граф 1":
                    {
                        PrintGraph1();
                        break;
                    }
                case "Граф 2":
                    {
                        PrintGraph2();
                        break;
                    }
            }


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
            Graph<int> graph = null;
            string graph_switch = comboBox1.SelectedItem.ToString();
            switch (graph_switch)
            {
                case "Граф 1":
                    {
                        graph = graph1;
                        break;
                    }
                case "Граф 2":
                    {
                        graph = graph2;
                        break;
                    }
            }
            try 
            {
                graph.BreadthTravel(int.Parse(VortexBox.Text));
                PathsTextBox.Text = graph.res;
            }
            catch
            {
                MessageBox.Show("Некоректо введённые данные");
            }
        }

        private void Depth_Click(object sender, EventArgs e)
        {
            Graph<int> graph = null;
            string graph_switch = comboBox1.SelectedItem.ToString();
            switch (graph_switch)
            {
                case "Граф 1":
                    {
                        graph = graph1;
                        break;
                    }
                case "Граф 2":
                    {
                        graph = graph2;
                        break;
                    }
            }
            try
            {
                graph.DepthTravel(int.Parse(VortexBox.Text));
                PathsTextBox.Text = graph.res;
            }
            catch
            {
                MessageBox.Show("Некоректо введённые данные");
            }
        }
    }
}