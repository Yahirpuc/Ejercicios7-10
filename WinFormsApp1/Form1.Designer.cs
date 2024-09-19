namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBox1;
        private Button buttonEjecutar;
        private Panel panelPractica7;
        private Panel panelPractica8;
        private Panel panelPractica9;
        private Panel panelPractica10;
        private TextBox textBoxResultado7;
        private TextBox textBoxResultado8;
        private TextBox textBoxResultado9;
        private TextBox textBoxResultado10;
        private TextBox[,] matriz7TextBoxes;
        private TextBox[,] matriz8TextBoxes;
        private TextBox[,] matriz1TextBoxes;
        private TextBox[,] matriz2TextBoxes;
        private TextBox[,] matriz10TextBoxes;
        private TextBox textBoxTamaño10;

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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            buttonEjecutar = new Button();
            panelPractica7 = new Panel();
            panelPractica8 = new Panel();
            panelPractica9 = new Panel();
            panelPractica10 = new Panel();
            Titulo = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(0, 192, 192);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Práctica 7", "Práctica 8", "Práctica 9", "Práctica 10" });
            comboBox1.Location = new Point(557, 26);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // buttonEjecutar
            // 
            buttonEjecutar.BackColor = Color.DarkSlateGray;
            buttonEjecutar.Dock = DockStyle.Right;
            buttonEjecutar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEjecutar.ForeColor = SystemColors.Control;
            buttonEjecutar.Location = new Point(817, 0);
            buttonEjecutar.Margin = new Padding(4, 3, 4, 3);
            buttonEjecutar.Name = "buttonEjecutar";
            buttonEjecutar.Size = new Size(116, 519);
            buttonEjecutar.TabIndex = 1;
            buttonEjecutar.Text = "Calcular";
            buttonEjecutar.UseVisualStyleBackColor = false;
            buttonEjecutar.Click += ButtonEjecutar_Click;
            // 
            // panelPractica7
            // 
            panelPractica7.Location = new Point(122, 94);
            panelPractica7.Margin = new Padding(4, 3, 4, 3);
            panelPractica7.Name = "panelPractica7";
            panelPractica7.Size = new Size(583, 346);
            panelPractica7.TabIndex = 2;
            panelPractica7.Visible = false;
            // 
            // panelPractica8
            // 
            panelPractica8.Location = new Point(122, 94);
            panelPractica8.Margin = new Padding(4, 3, 4, 3);
            panelPractica8.Name = "panelPractica8";
            panelPractica8.Size = new Size(583, 346);
            panelPractica8.TabIndex = 3;
            panelPractica8.Visible = false;
            // 
            // panelPractica9
            // 
            panelPractica9.Location = new Point(122, 94);
            panelPractica9.Margin = new Padding(4, 3, 4, 3);
            panelPractica9.Name = "panelPractica9";
            panelPractica9.Size = new Size(583, 346);
            panelPractica9.TabIndex = 4;
            panelPractica9.Visible = false;
            // 
            // panelPractica10
            // 
            panelPractica10.Location = new Point(122, 94);
            panelPractica10.Margin = new Padding(4, 3, 4, 3);
            panelPractica10.Name = "panelPractica10";
            panelPractica10.Size = new Size(583, 346);
            panelPractica10.TabIndex = 5;
            panelPractica10.Visible = false;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = SystemColors.Control;
            Titulo.Location = new Point(81, 19);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(463, 42);
            Titulo.TabIndex = 6;
            Titulo.Text = "Selecciona una opcion:";
            Titulo.Click += Titulo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(933, 519);
            Controls.Add(Titulo);
            Controls.Add(comboBox1);
            Controls.Add(buttonEjecutar);
            Controls.Add(panelPractica7);
            Controls.Add(panelPractica8);
            Controls.Add(panelPractica9);
            Controls.Add(panelPractica10);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Practicas de Matrices";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label Titulo;
    }
}
