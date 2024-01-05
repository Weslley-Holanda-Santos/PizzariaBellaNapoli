using ProjetoInter.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInter
{
    public partial class frmMenuFuncionario : Form
    {
        public frmMenuFuncionario()
        {
            InitializeComponent();
        }

        private void picPedidos_Click(object sender, EventArgs e)
        {
            //Acesso a tela de Pedidos como Funcionario
            frmPedido PedidoFuncionario = new frmPedido();
            this.Dispose();
            PedidoFuncionario.ShowDialog();
        }

        private void picEstoque_Click(object sender, EventArgs e)
        {
            //Acesso a tela de Estoque como Funcionario
            frmEstoque EstoqueFuncionario = new frmEstoque();
            this.Dispose();
            EstoqueFuncionario.ShowDialog();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            //Volta para a tela de login
            frmLogin Login = new frmLogin();
            this.Dispose();
            Login.ShowDialog();
        }

        private void picCadCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadastroCliente = new frmCadastroCliente();
            this.Dispose();
            cadastroCliente.ShowDialog();

        }
    }
}
