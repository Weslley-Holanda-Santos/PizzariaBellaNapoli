using ProjetoInter.DB;
using ProjetoInter.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoInter.frmLogin;

namespace ProjetoInter
{
    public partial class frmEstoque : Form
    {
        
        private string cargoUsuário;
        private frmLogin frmLogin;
        public frmEstoque()
        {
            InitializeComponent();
            //serve para armazenar o que foi selecionado no form de login
            string cargoUsuario = Global.FuncaoSelecionada;
            frmLogin = new frmLogin();

        }

       



        private void picVoltarEstoque_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin.VoltarAoFormAnterior();
            

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            PizzariaDB _context = new PizzariaDB();

            string txt_nome = txtNomeProduto.Text;
            string txt_descricao = txtDescricaoProd.Text;
            string txt_Categoria = txtCategoriaEstoque.Text;
            int txt_Quantidade;

            // Verifica se o valor em txtQuantidadeEstoque.Text é um número inteiro
            if (int.TryParse(txtQuantidadeEstoque.Text, out txt_Quantidade))
            {
                // Converte o valor de txt_Valor para double
                if (double.TryParse(txtValorEstoque.Text, out double txt_Valor))
                {
                    Estoque estoque = new Estoque
                    {
                        NomeProduto = txt_nome,
                        DescricaoProduto = txt_descricao,
                        QuantidadeProduto = txt_Quantidade,
                        CategoriaProduto = txt_Categoria,
                        Valor = txt_Valor  // Assume que há uma propriedade chamada ValorProduto no seu modelo Estoque
                    };

                    // comando para adicionar no banco de dados
                    _context.Estoque.AddAsync(estoque);
                    // comando para salvar as alterações no banco de dados
                    _context.SaveChangesAsync();
                    // Limpar os campos de texto após o cadastro bem-sucedido
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Valor inválido. Por favor, insira um número válido para o valor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Quantidade inválida. Por favor, insira um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string ProdutoCad = txtProcurarProd.Text;

            PizzariaDB _context = new PizzariaDB();
            Estoque estoque = _context.Estoque.FirstOrDefault(x => x.NomeProduto == ProdutoCad);

            if (estoque != null)
            {
               

                estoque.NomeProduto = txtNomeProduto.Text; 
                estoque.DescricaoProduto = txtDescricaoProd.Text;
                estoque.QuantidadeProduto = int.Parse(txtQuantidadeEstoque.Text);
                estoque.CategoriaProduto = txtCategoriaEstoque.Text;
                estoque.Valor = double.Parse(txtValorEstoque.Text);

                _context.Update(estoque);
                _context.SaveChanges();

                // Exibe Mensagem de Sucesso
                MessageBox.Show("Alteração feita com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Produto não encontrado, exibir mensagem de erro.
                MessageBox.Show("Produto não encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LimparCampos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtNomeProduto.Text;

            PizzariaDB _context = new PizzariaDB();
            Estoque estoque = _context.Estoque.FirstOrDefault(x => x.NomeProduto == nomeProduto);

            if (estoque != null)
            {
                // Remove o produto do banco de dados
                _context.Estoque.Remove(estoque);
                _context.SaveChanges();

                // Atualize o DataGridView
                dgvEstoqueDB.DataSource = _context.Estoque.ToList();
                LimparCampos();
                MessageBox.Show("Produto removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Caso o produto não exista
                MessageBox.Show("Produto não encontrado ou não existe", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {

            using (var db = new PizzariaDB())
            {
                var estoque = db.Estoque.ToList();
                dgvEstoqueDB.DataSource = estoque;
            }
        }

        private void dgvEstoqueDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certificar de que há um usuário cadastrado
            {
                DataGridViewRow row = dgvEstoqueDB.Rows[e.RowIndex];

                // DataGrid de Estoque
                txtNomeProduto.Text = row.Cells["NomeProduto"].Value.ToString();
                txtDescricaoProd.Text = row.Cells["DescricaoProduto"].Value.ToString();
                txtCategoriaEstoque.Text = row.Cells["CategoriaProduto"].Value.ToString();
                txtQuantidadeEstoque.Text = row.Cells["QuantidadeProduto"].Value.ToString();
                txtProcurarProd.Text = row.Cells["NomeProduto"].Value.ToString();
                txtValorEstoque.Text = row.Cells["Valor"].Value.ToString();


            }
        }

        private void LimparCampos()
        {
            txtProcurarProd.Text = "";
            txtNomeProduto.Text = "";
            txtDescricaoProd.Text = "";
            txtCategoriaEstoque.Text = "";
            txtQuantidadeEstoque.Text = "";
            txtValorEstoque.Text = "";

            // Limpe outros campos de texto conforme necessário
        }

        private void picLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void picBuscarEstoque_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtProcurarProd.Text;

            using (var db = new PizzariaDB())
            {
                var estoque = db.Estoque
                    .Where(u => u.NomeProduto.Contains(nomeProduto))
                    .ToList();

                dgvEstoqueDB.DataSource = estoque;

            }
        }

        private void txtProcurarProd_TextChanged(object sender, EventArgs e)
        {
            string procurarProd = txtProcurarProd.Text;

            // Faça uma consulta no banco de dados para encontrar o funcionário com o nome fornecido
            using (var db = new PizzariaDB())
            {
                var estoque = db.Estoque.FirstOrDefault(u => u.NomeProduto.Contains(procurarProd));

                if (estoque != null)
                {
                    // Preencha os campos de texto e combobox com os dados do funcionário encontrado
                    txtNomeProduto.Text = estoque.NomeProduto;
                    txtQuantidadeEstoque.Text = estoque.QuantidadeProduto.ToString();
                    txtDescricaoProd.Text = estoque.DescricaoProduto;
                    txtCategoriaEstoque.Text = estoque.CategoriaProduto;
                    txtValorEstoque.Text = estoque.Valor.ToString();



                }
                else
                {
                    // Se nenhum estoque for encontrado, limpe os campos de texto
                    LimparCampos();
                }
            }
        }

        
    }
}
