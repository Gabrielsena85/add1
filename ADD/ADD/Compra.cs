using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD
{
    public class Compra
    {
        public int id {  get; set; }
        [DisplayName("ID")] public int Id { get; set; }
        [DisplayName("ID do Produto")] public int idProduto { get; set; }
        [DisplayName("ID do Fornecedor")] public int idFornecedor { get; set; }
        [DisplayName("Quantidade Comprada")] public int Quantidade { get; set; }
        [DisplayName("Porcentagem de Desconto")] public float Desconto { get; set; }
        [DisplayName("Data da Compra")] public DateTime DataCompra { get; set; }

        public void loadData(string dataString)
        {
            string[] data = dataString.Split(';');
            Id = int.Parse(data[0]);
            idProduto = int.Parse(data[1]);
            idFornecedor = int.Parse(data[2]);
            Quantidade = int.Parse(data[3]);
            Desconto = int.Parse(data[4]);
            DataCompra = DateTime.Parse(data[5]);
        }

        public override string ToString()
        {
            return $"{Id};{idFornecedor};{Quantidade};{Desconto.ToString()};{DataCompra};{Quantidade}";
        }
    }
}
