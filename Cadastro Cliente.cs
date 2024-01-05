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
using static ProjetoInter.frmLogin;

namespace ProjetoInter
{
    public partial class frmCadastroCliente : Form
    {
        private string cargoUsuário;
        private frmLogin frmLogin;
        public frmCadastroCliente()
        {
            InitializeComponent();
            string cargoUsuario = Global.FuncaoSelecionada;
            frmLogin = new frmLogin();
        }
        private void LimparCampos()
        {
            txtNomeCliente.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskTelefone.Text = "";
            txtNome.Focus();

        }
        private void picLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void picVoltarCadastro_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin.VoltarAoFormAnterior();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que há uma linha selecionada
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                // Preencha os campos com os dados da célula clicada
                txtNome.Text = row.Cells["Name"].Value.ToString();
                txtEndereco.Text = row.Cells["Endereco"].Value.ToString();
                mskTelefone.Text = row.Cells["Telefone"].Value.ToString();
                txtNomeCliente.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            PizzariaDB _context = new PizzariaDB();

            string txt_nome = txtNome.Text;
            string txt_Endereco = txtEndereco.Text;
            string txt_Telefone = mskTelefone.Text;

            Cliente clientes = new Cliente
            {
                Name = txt_nome,
                Endereco = txt_Endereco,
                Telefone = txt_Telefone
            };

            // comando para adicionar no banco de dados
            _context.Clientes.Add(clientes);

            // comando para salvar as alterações no banco de dados
            await _context.SaveChangesAsync(); // Usando await para garantir que SaveChangesAsync seja concluído antes de continuar

            // Limpar os campos de texto após o cadastro bem-sucedido
            LimparCamposTexto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string Name = txtNomeCliente.Text;

            PizzariaDB _context = new PizzariaDB();
            Cliente cliente = _context.Clientes.FirstOrDefault(x => x.Name == Name);
            if (cliente != null)
            {
                cliente.Name = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Telefone = mskTelefone.Text;

                _context.Update(cliente);
                _context.SaveChanges();

                MessageBox.Show("Alteração feita com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Usuário não encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LimparCamposTexto();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNome.Text;

            PizzariaDB _context = new PizzariaDB();
            Cliente cliente = _context.Clientes.FirstOrDefault(x => x.Name == nomeCliente);

            if (cliente != null)
            {
                //Remove usuário 
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
                dgvClientes.DataSource = _context.Clientes.ToList();
                LimparCamposTexto();
                MessageBox.Show("Usuário removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //Caso usuário não exista
                MessageBox.Show("Usuário não encontrado ou não existe", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            using (var db = new PizzariaDB())
            {
                var Clientes = db.Clientes.ToList(); // Ou qualquer outra consulta que você precise

                dgvClientes.DataSource = Clientes;
            }
        }

        private void mskTelefone_Enter(object sender, EventArgs e)
        {
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void mskTelefone_Leave(object sender, EventArgs e)
        {
            mskTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }
        private void LimparCamposTexto()
        {

            txtNomeCliente.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskTelefone.Text = "";

        }

        private void picProcurarFuncionario_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNomeCliente.Text;

            using (var db = new PizzariaDB())
            {
                var cliente = db.Clientes
                    .Where(u => u.Name.Contains(nomeCliente))
                    .ToList();

                dgvClientes.DataSource = cliente;
            }
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            string procurarCliente = txtNomeCliente.Text;

            // Faça uma consulta no banco de dados para encontrar o funcionário com o nome fornecido
            using (var db = new PizzariaDB())
            {
                var cliente = db.Clientes.FirstOrDefault(u => u.Name.Contains(procurarCliente));

                if (cliente != null)
                {
                    // Preencha os campos de texto e combobox com os dados do funcionário encontrado
                    txtNome.Text = cliente.Name;
                    txtEndereco.Text = cliente.Endereco;
                    mskTelefone.Text = cliente.Telefone;




                }
                else
                {
                    // Se nenhum estoque for encontrado, limpe os campos de texto
                    LimparCampos();
                }
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}