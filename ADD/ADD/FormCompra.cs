using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADD
{
    public partial class FormCompra : Form
    {
        private BindingList<Fornecedor> Fornecedores {  get; set; }
        private Fornecedor Fornecedor { get { return Fornecedores.FirstOrDefault(f => f.Id == (int)comboBoxFornecedor1.SelectedValue); } }
        public int IdFornecedor { get { return (int)comboBoxFornecedor1.SelectedValue; } }

        private BindingList<Produto> Produtos { get; set; }
        private Produto Produto { get { return Produtos.FirstOrDefault(p => p.Id == (int)comboBoxProduto1.SelectedValue); } }
        public int IdProduto { get { return (int)comboBoxProduto1.SelectedValue; } }

        public decimal quantidade { get { return numericUpDownQuantidade1.Value; } }
        public decimal Desconto1 { get { return numericUpDown2.Value; } }

        private decimal PrecoUnitario { get { return Produto.PrecoCompra; } }
        private decimal ValorTotal { get { return PrecoUnitario * quantidade; } }
        private decimal ValorComDesconto { get { return ValorTotal * (1 - (Desconto1 / 100)); } }

        public FormCompra(BindingList<Fornecedor> fornecedores, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Fornecedores = fornecedores;
            comboBoxFornecedor1.DataSource = Fornecedores;
            comboBoxFornecedor1.ValueMember = "Id";
            comboBoxFornecedor1.DisplayMember = "NomeEmpresa";
            comboBoxFornecedor1.SelectedIndex = 0;

            Produtos = produtos;
            comboBoxProduto1.DataSource = Produtos;
            comboBoxProduto1.ValueMember = "Id";
            comboBoxProduto1.DisplayMember = "Nome";
            comboBoxProduto1.SelectedIndex = 0;
        }

        private void comboBoxProduto1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFornecedor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownQuantidade1_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void AtualizarValores()
        {
            if (Produto != null)
            {
                textBoxPrecoU.Text = PrecoUnitario.ToString("C", CultureInfo.CurrentCulture);
                textBoxTotalD.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                textBoxTotalD.Text = ValorComDesconto.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private void buttonOkCompra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
