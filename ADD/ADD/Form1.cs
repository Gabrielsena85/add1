using System.ComponentModel;

namespace ADD
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public BindingList<Cliente> clientes { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }
        public BindingList<Venda> vendas { get; set; }
        public BindingList<Compra> compras { get; set; }

        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            clientes = new BindingList<Cliente>();
            fornecedores = new BindingList<Fornecedor>();
            vendas = new BindingList<Venda>();
            compras = new BindingList<Compra>();
            this.dataGridView1.DataSource = produtos;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormCriaProdutos fcp = new FormCriaProdutos();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();
                if (produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(x => x.Id) + 1;

                produto.Nome = fcp.nomeProduto;
                produto.Fabricante = fcp.nomeFabricante;
                produto.PrecoVenda = fcp.precoVenda;
                produto.PrecoCompra = fcp.precoCompra;

                produtos.Add(produto);
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = produtos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = clientes;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = vendas;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = fornecedores;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = compras;
        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            FormCliente fcp = new FormCliente();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();
                cliente.nome = fcp.Nome;
                cliente.fone = fcp.Telefone;
                cliente.email = fcp.Email;
                cliente.endereco = fcp.Endereco;

                clientes.Add(cliente);

            }
        }

        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                clientes.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormFormecedor fcp = new FormFormecedor();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.nome = fcp.Nome;
                fornecedor.email = fcp.Email;
                fornecedor.fone = fcp.Telefone;
                fornecedor.nome = fcp.NomeContato;
                fornecedor.endereco = fcp.endereco;

                fornecedores.Add(fornecedor);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (fornecedores.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar Fornecedores antes de efetuar uma compra.");
                return;
            }

            if (produtos.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastar Produtos antes de efetuar uma Compra.");
                return;
            }

            FormCompra fcc = new FormCompra(fornecedores, produtos);
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (compras.Count == 0) compra.id = 1;
                else compra.id = compras.Max(x => x.id) + 1;

                compra.idProduto = fcc.IdProduto;
                compra.idFornecedor = fcc.IdFornecedor;
                compra.Quantidade = (int)fcc.quantidade;
                compra.Desconto = (int)fcc.Desconto1;
                compra.DataCompra = DateTime.Now;

                compras.Add(compra);

            }
        }
    }
}
