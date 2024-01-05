using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInter.Modelos
{
    public class Estoque
    {
        public int Id { get; set; }

        public string NomeProduto { get; set; }

        public int QuantidadeProduto { get; set; }

        public string DescricaoProduto { get; set; }

        public string CategoriaProduto { get; set; }

        public double Valor { get; set; }
    }
}
