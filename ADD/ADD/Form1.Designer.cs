namespace ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            buttonAdicionarCliente = new Button();
            buttonRemoverCliente = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.Lime;
            buttonAdicionar.BackgroundImageLayout = ImageLayout.None;
            buttonAdicionar.Location = new Point(12, 64);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(158, 23);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Adicionar Produto";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.BackColor = Color.Red;
            buttonRemover.Location = new Point(12, 93);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(158, 23);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover Produto";
            buttonRemover.UseVisualStyleBackColor = false;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(855, 333);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(158, 46);
            button1.TabIndex = 3;
            button1.Text = "Produtos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LawnGreen;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.BottomLeft;
            button2.Location = new Point(189, 12);
            button2.Name = "button2";
            button2.Size = new Size(159, 46);
            button2.TabIndex = 4;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LawnGreen;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.BottomLeft;
            button3.Location = new Point(364, 12);
            button3.Name = "button3";
            button3.Size = new Size(154, 46);
            button3.TabIndex = 5;
            button3.Text = "Vendas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LawnGreen;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.BottomLeft;
            button4.Location = new Point(537, 13);
            button4.Name = "button4";
            button4.Size = new Size(157, 46);
            button4.TabIndex = 6;
            button4.Text = "Fornecedores";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LawnGreen;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.BottomLeft;
            button5.Location = new Point(712, 13);
            button5.Name = "button5";
            button5.Size = new Size(155, 46);
            button5.TabIndex = 7;
            button5.Text = "Compras";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Location = new Point(364, 93);
            button6.Name = "button6";
            button6.Size = new Size(154, 23);
            button6.TabIndex = 8;
            button6.Text = "Remover Venda";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.Location = new Point(364, 64);
            button7.Name = "button7";
            button7.Size = new Size(154, 23);
            button7.TabIndex = 9;
            button7.Text = "Adicionar Venda";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.BackColor = Color.Lime;
            buttonAdicionarCliente.Location = new Point(189, 64);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(159, 23);
            buttonAdicionarCliente.TabIndex = 10;
            buttonAdicionarCliente.Text = "Adicionar Cliente";
            buttonAdicionarCliente.UseVisualStyleBackColor = false;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.BackColor = Color.Red;
            buttonRemoverCliente.Location = new Point(189, 93);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(159, 23);
            buttonRemoverCliente.TabIndex = 11;
            buttonRemoverCliente.Text = "Remover Cliente";
            buttonRemoverCliente.UseVisualStyleBackColor = false;
            buttonRemoverCliente.Click += buttonRemoverCliente_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Lime;
            button10.Location = new Point(537, 64);
            button10.Name = "button10";
            button10.Size = new Size(157, 23);
            button10.TabIndex = 12;
            button10.Text = "Adicionar Formecedor";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Red;
            button11.Location = new Point(537, 93);
            button11.Name = "button11";
            button11.Size = new Size(157, 23);
            button11.TabIndex = 13;
            button11.Text = "Remover Fornecedor";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click_1;
            // 
            // button12
            // 
            button12.BackColor = Color.Lime;
            button12.Location = new Point(712, 65);
            button12.Name = "button12";
            button12.Size = new Size(155, 23);
            button12.TabIndex = 14;
            button12.Text = "Adicionar Compra";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Red;
            button13.Location = new Point(712, 95);
            button13.Name = "button13";
            button13.Size = new Size(155, 23);
            button13.TabIndex = 15;
            button13.Text = "Remover Compra";
            button13.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(883, 467);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(buttonRemoverCliente);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionar;
        private Button buttonRemover;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button buttonAdicionarCliente;
        private Button buttonRemoverCliente;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}
