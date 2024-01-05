using ProjetoInter.DB;
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
    public partial class frmLogin : Form
    {
        public static class Global
        {
            public static string FuncaoSelecionada { get; set; }
        }
        public frmLogin()
        {
            InitializeComponent();
            
            
        }

        private void InputLogin_TextChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }


        private void Logar(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            string cargoSelecionado = cmbFuncao.SelectedItem?.ToString();

            // Caractere coringa para login durante o desenvolvimento
            if (login == "admin" && senha == "admin123")
            {
                RedirecionarUsuario(cargoSelecionado);
            }
            else
            {
                // Código de autenticação normal com o banco de dados
                PizzariaDB db = new PizzariaDB();
                Usuario user = db.Usuarios.FirstOrDefault(x => x.Login == login && x.Senha == senha);

                if (user != null)
                {
                    RedirecionarUsuario(cargoSelecionado);
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void RedirecionarUsuario(string cargo)
        {
            Global.FuncaoSelecionada = cargo; // Armazena a função selecionada globalmente

            if (cargo == "Administrador")
            {
                frmMenuAdministrador menuAdmin = new frmMenuAdministrador();
                this.Hide();
                menuAdmin.ShowDialog();
                this.Close();
            }
            else if (cargo == "Funcionário")
            {
                frmMenuFuncionario menuFunc = new frmMenuFuncionario();
                this.Hide();
                menuFunc.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhum tipo de acesso selecionado, tente novamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void VoltarAoFormAnterior()
        {
            if (Global.FuncaoSelecionada == "Administrador")
            {
                frmMenuAdministrador menuAdmin = new frmMenuAdministrador();
                this.Hide();
                menuAdmin.ShowDialog();
                this.Close();
            }
            else if (Global.FuncaoSelecionada == "Funcionário")
            {
                frmMenuFuncionario menuFunc = new frmMenuFuncionario();
                this.Hide();
                menuFunc.ShowDialog();
                this.Close();
            }
 
        }

        private void picEncerar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
