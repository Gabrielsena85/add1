using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD
{
    public class Cliente
    {
        [DisplayName("ID")] public int id{get;set;}
        [DisplayName("Nome do Cliente")] public string nome { get;set;}
        [DisplayName("Número de Telefone")] public string fone{get;set;}
        [DisplayName("Endereço de E-mail")] public string email{get;set;}
        [DisplayName("Endereço Físico")] public string endereco{get;set;}
    }
}
