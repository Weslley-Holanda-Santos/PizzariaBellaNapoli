using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInter.Modelos
{
     public class Cliente
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set;}

        // Relacionamento 1 pra muitos/ 1 pra N

        // propriedade que representa uma lista de pedidos

        // Id é a chave primária 
        public List<Pedido> Pedidos { get; set; }

    }
}
