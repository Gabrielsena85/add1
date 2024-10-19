namespace ADD
{
    partial class FormCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxProduto1 = new ComboBox();
            comboBoxFornecedor1 = new ComboBox();
            numericUpDownQuantidade1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBoxPrecoU = new TextBox();
            textBoxValorT = new TextBox();
            textBoxTotalD = new TextBox();
            label8 = new Label();
            buttonOkCompra = new Button();
            buttonCancelarCompra = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 23);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 63);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 107);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 146);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Desconto (%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 185);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "Preço Unitário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 227);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Valor Total:";
            // 
            // comboBoxProduto1
            // 
            comboBoxProduto1.FormattingEnabled = true;
            comboBoxProduto1.Location = new Point(151, 23);
            comboBoxProduto1.Name = "comboBoxProduto1";
            comboBoxProduto1.Size = new Size(121, 23);
            comboBoxProduto1.TabIndex = 7;
            comboBoxProduto1.SelectedIndexChanged += comboBoxProduto1_SelectedIndexChanged;
            // 
            // comboBoxFornecedor1
            // 
            comboBoxFornecedor1.FormattingEnabled = true;
            comboBoxFornecedor1.Location = new Point(151, 63);
            comboBoxFornecedor1.Name = "comboBoxFornecedor1";
            comboBoxFornecedor1.Size = new Size(121, 23);
            comboBoxFornecedor1.TabIndex = 8;
            comboBoxFornecedor1.SelectedIndexChanged += comboBoxFornecedor1_SelectedIndexChanged;
            // 
            // numericUpDownQuantidade1
            // 
            numericUpDownQuantidade1.Location = new Point(153, 99);
            numericUpDownQuantidade1.Name = "numericUpDownQuantidade1";
            numericUpDownQuantidade1.Size = new Size(120, 23);
            numericUpDownQuantidade1.TabIndex = 9;
            numericUpDownQuantidade1.ValueChanged += numericUpDownQuantidade1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(153, 138);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 10;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // textBoxPrecoU
            // 
            textBoxPrecoU.BackColor = SystemColors.ActiveBorder;
            textBoxPrecoU.ForeColor = SystemColors.Window;
            textBoxPrecoU.Location = new Point(153, 177);
            textBoxPrecoU.Name = "textBoxPrecoU";
            textBoxPrecoU.ReadOnly = true;
            textBoxPrecoU.Size = new Size(120, 23);
            textBoxPrecoU.TabIndex = 11;
            // 
            // textBoxValorT
            // 
            textBoxValorT.BackColor = SystemColors.ActiveBorder;
            textBoxValorT.ForeColor = SystemColors.Window;
            textBoxValorT.Location = new Point(153, 219);
            textBoxValorT.Name = "textBoxValorT";
            textBoxValorT.ReadOnly = true;
            textBoxValorT.Size = new Size(100, 23);
            textBoxValorT.TabIndex = 12;
            // 
            // textBoxTotalD
            // 
            textBoxTotalD.BackColor = SystemColors.AppWorkspace;
            textBoxTotalD.ForeColor = SystemColors.Window;
            textBoxTotalD.Location = new Point(153, 265);
            textBoxTotalD.Name = "textBoxTotalD";
            textBoxTotalD.Size = new Size(100, 23);
            textBoxTotalD.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 265);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 14;
            label8.Text = "Total Com Desconto:";
            // 
            // buttonOkCompra
            // 
            buttonOkCompra.Location = new Point(37, 328);
            buttonOkCompra.Name = "buttonOkCompra";
            buttonOkCompra.Size = new Size(75, 23);
            buttonOkCompra.TabIndex = 15;
            buttonOkCompra.Text = "Ok";
            buttonOkCompra.UseVisualStyleBackColor = true;
            buttonOkCompra.Click += buttonOkCompra_Click;
            // 
            // buttonCancelarCompra
            // 
            buttonCancelarCompra.Location = new Point(197, 328);
            buttonCancelarCompra.Name = "buttonCancelarCompra";
            buttonCancelarCompra.Size = new Size(75, 23);
            buttonCancelarCompra.TabIndex = 16;
            buttonCancelarCompra.Text = "Cancelar";
            buttonCancelarCompra.UseVisualStyleBackColor = true;
            buttonCancelarCompra.Click += buttonCancelarCompra_Click;
            // 
            // FormCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelarCompra);
            Controls.Add(buttonOkCompra);
            Controls.Add(label8);
            Controls.Add(textBoxTotalD);
            Controls.Add(textBoxValorT);
            Controls.Add(textBoxPrecoU);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDownQuantidade1);
            Controls.Add(comboBoxFornecedor1);
            Controls.Add(comboBoxProduto1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCompra";
            Text = "FormCompra";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxProduto1;
        private ComboBox comboBoxFornecedor1;
        private NumericUpDown numericUpDownQuantidade1;
        private NumericUpDown numericUpDown2;
        private TextBox textBoxPrecoU;
        private TextBox textBoxValorT;
        private TextBox textBoxTotalD;
        private Label label8;
        private Button buttonOkCompra;
        private Button buttonCancelarCompra;
    }
}