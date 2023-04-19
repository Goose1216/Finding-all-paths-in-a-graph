namespace Program
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PathsTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bredth = new System.Windows.Forms.Button();
            this.Depth = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(22, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Визуализировать граф";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 57);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(365, 25);
            this.comboBox1.TabIndex = 2;
            // 
            // PathsTextBox
            // 
            this.PathsTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.PathsTextBox.Location = new System.Drawing.Point(1124, 10);
            this.PathsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PathsTextBox.Name = "PathsTextBox";
            this.PathsTextBox.ReadOnly = true;
            this.PathsTextBox.Size = new System.Drawing.Size(136, 597);
            this.PathsTextBox.TabIndex = 3;
            this.PathsTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбор графа";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bredth
            // 
            this.Bredth.Enabled = false;
            this.Bredth.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bredth.Location = new System.Drawing.Point(509, 57);
            this.Bredth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bredth.Name = "Bredth";
            this.Bredth.Size = new System.Drawing.Size(271, 83);
            this.Bredth.TabIndex = 5;
            this.Bredth.Text = "Поиск в ширину";
            this.Bredth.UseVisualStyleBackColor = true;
            this.Bredth.Click += new System.EventHandler(this.Bredth_Click);
            // 
            // Depth
            // 
            this.Depth.Enabled = false;
            this.Depth.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Depth.Location = new System.Drawing.Point(880, 57);
            this.Depth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(264, 83);
            this.Depth.TabIndex = 6;
            this.Depth.Text = "Поиск в глубину";
            this.Depth.UseVisualStyleBackColor = true;
            this.Depth.Click += new System.EventHandler(this.Depth_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Depth);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Bredth);
            this.panel1.Location = new System.Drawing.Point(-8, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 156);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1267, 764);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PathsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1287, 808);
            this.Name = "Form1";
            this.Text = "Графы";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private RichTextBox PathsTextBox;
        private Label label1;
        private Button Bredth;
        private Button Depth;
        private ColorDialog colorDialog1;
        private Panel panel1;
    }
}