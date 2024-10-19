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
    public partial class FormCliente : Form
    {
        public string Nome { get { return this.textBox1Nome.Text; } }
        public string Telefone { get { return this.textBox1Telefone.Text; } }
        public string Email { get { return this.textBox1Email.Text; } }

        public string Endereco
        {
            get
            {
                string endereco = "";
                endereco += $"({textBox1Endereco.Text}), ";
                endereco += $"({textBox1Numero.Text}), ";
                endereco += $"({textBox1Rua.Text}), ";
                endereco += $"({textBox1Cidade.Text}), ";
                endereco += $"CEP: {textBox1CEP.Text}";
                return endereco;
            }
        }

        public FormCliente()
        {
            InitializeComponent();
        }

        private void button1OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button2Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
