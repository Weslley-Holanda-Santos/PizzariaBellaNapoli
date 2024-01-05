using ProjetoInter.DB;
using ProjetoInter.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoInter.frmLogin;

namespace ProjetoInter
{
    public partial class frmCadFuncionario : Form
    {
        private string cargoUsuário;
        private frmLogin frmLogin;
        public frmCadFuncionario()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
            txtSenha.MaxLength = 10;
            string cargoUsuario = Global.FuncaoSelecionada;
            frmLogin = new frmLogin();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string nomeCadastro = txtNome.Text;

            PizzariaDB _context = new PizzariaDB();
            Usuario usuario = _context.Usuarios.FirstOrDefault(x => x.Nome == nomeCadastro);

            if (usuario != null)
            {
                //Remove usuario inserido
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();

                dgvFuncionarios.DataSource = _context.Usuarios.ToList();
                LimparCamposTexto();
                MessageBox.Show("Usuario removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                //Mensagem de Erro
                MessageBox.Show("Usuário não encontrado ou já excluido","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private async void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            PizzariaDB _context = new PizzariaDB();

            string txt_nome = txtNome.Text;
            string txt_usuario = txtUsuario.Text;
            string txt_senha = txtSenha.Text;
            string txt_confirm_senha = txtConfirmarSenha.Text;
            string txt_cargo = cmbAcesso.Text;

            if(txt_senha == txt_confirm_senha)
            {
                Usuario usuario = new Usuario
                {
                    Nome = txt_nome,
                    Login = txt_usuario,
                    Senha = txt_senha,
                    Cargo = txt_cargo
                };

                // comando para adicionar no banco de dados
                _context.Usuarios.AddAsync(usuario);

                // comando para salvar as alterações no banco de dados
                _context.SaveChangesAsync();

                // Limpar os campos de texto após o cadastro bem-sucedido
                LimparCamposTexto();
            } else
            {
                MessageBox.Show("Senhas diferentes", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimparCamposTexto()
        {

            txtNomeFuncionario.Text = "";
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
            cmbAcesso.SelectedIndex = -1;// Limpa a seleção do ComboBox
            
        }
        private void picVoltarCadastro_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin.VoltarAoFormAnterior();
            dgvFuncionarios.CellFormatting += dgvFuncionarios_CellFormatting;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string cargoSelecionado = cmbAcesso.SelectedItem?.ToString();
            string nomeCadastro = txtNomeFuncionario.Text;

            PizzariaDB _context = new PizzariaDB();
            Usuario usuario = _context.Usuarios.FirstOrDefault(x => x.Nome == nomeCadastro);

            if (usuario != null)
            {
                usuario.Nome = txtNome.Text;
                usuario.Cargo = cmbAcesso.Text;
                usuario.Senha = txtSenha.Text;

                _context.Update(usuario);

                _context.SaveChanges();

                //Exibe Mensagem de Sucesso
                MessageBox.Show("Alteração feita com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                //Caso não encontra o produto solicitado
                MessageBox.Show("Usuário não encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LimparCampos();

        }

        private void picProcurarFuncionario_Click(object sender, EventArgs e)
        {
            string nomeFuncionario = txtNomeFuncionario.Text;

            using (var db = new PizzariaDB())
            {
                var funcionarios = db.Usuarios
                    .Where(u => u.Nome.Contains(nomeFuncionario))
                    .ToList();

                dgvFuncionarios.DataSource = funcionarios;
            }
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            using (var db = new PizzariaDB())
            {
                var funcionarios = db.Usuarios.ToList(); // Ou qualquer outra consulta que você precise

                dgvFuncionarios.DataSource = funcionarios;
            }
        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que uma linha válida foi clicada
            {
                DataGridViewRow row = dgvFuncionarios.Rows[e.RowIndex];

                // Preencha os campos de texto e combobox com os dados da célula clicada
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtUsuario.Text = row.Cells["Login"].Value.ToString();
                txtSenha.Text = row.Cells["Senha"].Value.ToString();
                txtConfirmarSenha.Text = row.Cells["Senha"].Value.ToString(); // Supondo que a senha seja mostrada na célula
                cmbAcesso.Text = row.Cells["Cargo"].Value.ToString();
                txtNomeFuncionario.Text = row.Cells["Nome"].Value.ToString();
                // Preencha outros campos de texto conforme necessário
            }
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
            cmbAcesso.Text = "";
            txtNome.Focus();
            // Limpe outros campos de texto conforme necessário
        }
        private void txtNomeFuncionario_TextChanged(object sender, EventArgs e)
        {
            string nomeFuncionario = txtNomeFuncionario.Text;

            // Faça uma consulta no banco de dados para encontrar o funcionário com o nome fornecido
            using (var db = new PizzariaDB())
            {
                var funcionario = db.Usuarios.FirstOrDefault(u => u.Nome.Contains(nomeFuncionario));

                if (funcionario != null)
                {
                    // Preencha os campos de texto e combobox com os dados do funcionário encontrado
                    txtNome.Text = funcionario.Nome;
                    txtUsuario.Text = funcionario.Login;
                    txtSenha.Text = funcionario.Senha;
                    txtConfirmarSenha.Text = funcionario.Senha; // Supondo que a senha seja mostrada na célula
                    cmbAcesso.Text = funcionario.Cargo;
                    // Preencha outros campos de texto conforme necessário
                }
                else
                {
                    // Se nenhum funcionário foi encontrado, limpe os campos de texto e combobox
                    LimparCampos();
                }
            }
            
        }

        private void dgvFuncionarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Antes de fazer modificações no DataGridView
            dgvFuncionarios.SuspendLayout();
            // Especifique o índice da coluna que deseja alterar a cor
            int columnIndex = dgvFuncionarios.Columns["Nome"].Index;

            // Verifique se a célula atual está na coluna desejada e se o valor não é nulo
            if (e.ColumnIndex == columnIndex && e.Value != null)
            {
                // Verifique o valor da célula e defina a cor com base no valor
                string valor = e.Value.ToString().Trim(); // Remova espaços extras
                if (valor == "Admin")
                {
                    // Defina a cor de fundo para a célula com valor "Admin"
                    e.CellStyle.BackColor = Color.Purple;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (valor == "Funcionário")
                {
                    // Defina a cor de fundo para a célula com valor "Funcionário"
                    e.CellStyle.BackColor = Color.DarkBlue;
                    e.CellStyle.ForeColor = Color.White;
                }
                // Adicione mais condições conforme necessário
                dgvFuncionarios.ResumeLayout();
            }
        }

        private void picLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposTexto();
        }

        
    }
}
