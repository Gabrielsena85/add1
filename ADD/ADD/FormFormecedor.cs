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
    public partial class FormFormecedor : Form
    {
        public string Nome { get { return this.textBoxNomeEmpresa.Text; } }
        public string Telefone { get { return this.textBoxNomeTelefone.Text; } }
        public string Email { get { return this.textBoxNomeEmail.Text; } }
        public string NomeContato { get { return this.textBoxNomeContato.Text; } }

        public string endereco
        {
            get
            {
                string endereco = $"";
                endereco += $"({textBoxNomeEndereco.Text}), ";
                endereco += $"({textBoxNomeCNPJ.Text}), ";
                endereco += $"({textBoxNomeComplemento}), ";
                endereco += $"({textBoxNomeNumero}), ";
                endereco += $"({textBoxNomeRua}), ";
                endereco += $"({textBoxNomeUF}), ";
                endereco += $"({textBoxNomeCidade}), ";
                endereco += $"CEP:({textBoxNomeCEP}) ";
                return endereco;
            }
        }

        public FormFormecedor()
        {
            InitializeComponent();
        }


        private void button2OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
