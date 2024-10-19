namespace ADD
{
    partial class FormCriaProdutos
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
            numericUpDownPrecoVenda = new NumericUpDown();
            numericUpDownPrecoCompra = new NumericUpDown();
            textBoxNomeProduto = new TextBox();
            textBoxNomeFabricante = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonOk = new Button();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoCompra).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownPrecoVenda
            // 
            numericUpDownPrecoVenda.DecimalPlaces = 2;
            numericUpDownPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownPrecoVenda.Location = new Point(149, 107);
            numericUpDownPrecoVenda.Name = "numericUpDownPrecoVenda";
            numericUpDownPrecoVenda.Size = new Size(120, 23);
            numericUpDownPrecoVenda.TabIndex = 1;
            numericUpDownPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownPrecoCompra
            // 
            numericUpDownPrecoCompra.DecimalPlaces = 2;
            numericUpDownPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownPrecoCompra.Location = new Point(149, 72);
            numericUpDownPrecoCompra.Name = "numericUpDownPrecoCompra";
            numericUpDownPrecoCompra.Size = new Size(120, 23);
            numericUpDownPrecoCompra.TabIndex = 1;
            numericUpDownPrecoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.Location = new Point(153, 9);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(116, 23);
            textBoxNomeProduto.TabIndex = 2;
            // 
            // textBoxNomeFabricante
            // 
            textBoxNomeFabricante.Location = new Point(149, 43);
            textBoxNomeFabricante.Name = "textBoxNomeFabricante";
            textBoxNomeFabricante.Size = new Size(120, 23);
            textBoxNomeFabricante.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 3;
            label1.Text = "Nome do produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(132, 16);
            label2.TabIndex = 4;
            label2.Text = "Nome do fabricante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 6;
            label3.Text = "Preço de venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 82);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 5;
            label4.Text = "Preço de compra";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(12, 148);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(166, 148);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormCriaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 365);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNomeFabricante);
            Controls.Add(textBoxNomeProduto);
            Controls.Add(numericUpDownPrecoCompra);
            Controls.Add(numericUpDownPrecoVenda);
            Name = "FormCriaProdutos";
            Text = "FormCriaProdutos";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numericUpDownPrecoVenda;
        private NumericUpDown numericUpDownPrecoCompra;
        private TextBox textBoxNomeProduto;
        private TextBox textBoxNomeFabricante;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonOk;
        private Button buttonCancelar;
    }
}