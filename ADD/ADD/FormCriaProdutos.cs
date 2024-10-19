using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADD
{
    public partial class FormCriaProdutos : Form
    {
        public string nomeProduto { get { return this.textBoxNomeProduto.Text; } }
        public string nomeFabricante { get { return this.textBoxNomeFabricante.Text; } }
        public decimal precoCompra { get { return this.numericUpDownPrecoCompra.Value; } }   
        public decimal precoVenda { get { return this.numericUpDownPrecoVenda.Value; } }
        public FormCriaProdutos()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
