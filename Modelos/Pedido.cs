using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInter.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }

        public string Produto { get; set; }

        public double Valor { get; set; }

        public int ClienteId { get; set; }
        
        // propriedade virtual permite que uma instancia desse tipo de objeto seja criada em tempo de execução para manipulação dos dados
        public virtual Cliente Cliente { get; set; }    
    }
}
