using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Livraria : Form
    {
        int idAlterar;
        int idAlterarEditora; // Variável para guardar o ID da editora

        public Livraria()
        {
            InitializeComponent();
        }

        // --- Navegação ---
        private void btnNavCadCliente_Click(object sender, EventArgs e) { BuscaCliente.SelectedIndex = 0; }
        private void btnNavCadEditora_Click(object sender, EventArgs e) { BuscaCliente.SelectedIndex = 1; }
        private void btnNavListaClientes_Click(object sender, EventArgs e) { listaCliente(); BuscaCliente.SelectedIndex = 2; }
        private void btnNavListaEditoras_Click(object sender, EventArgs e) { lista_Editora(); BuscaCliente.SelectedIndex = 3; }
        private void closebtn_Click(object sender, EventArgs e) { Application.Exit(); }

        // --- Carregamento ---
        private void Livraria_Load_1(object sender, EventArgs e)
        {
            lista_Editora();
            listaCliente();
        }

        private void lista_Editora()
        {
            ConectaBanco con = new ConectaBanco();
            dgEditora.DataSource = con.lista_editora();
        }

        private void listaCliente()
        {
            ConectaBanco con = new ConectaBanco();
            dgClientes.DataSource = con.listaCliente();
        }

        // --- CLIENTES ---
        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcliente.Text)) { MessageBox.Show("Nome obrigatório"); return; }
            Cliente b = new Cliente();
            b.Nome = txtcliente.Text;
            b.DataNascimento = txtdata.Text;
            b.CPF = txtcpf.Text;
            b.UF = txtuf.Text;
            b.Endereco = txtendereco.Text;
            b.Bairro = txtbairro.Text;
            b.Cidade = txtcidade.Text;
            b.CEP = txtcep.Text;
            b.Email = txtemail.Text;

            ConectaBanco conecta = new ConectaBanco();
            if (conecta.insereCliente(b))
            {
                MessageBox.Show("Sucesso!");
                txtcliente.Clear();
            }
            listaCliente();
        }

        private void button2_Click(object sender, EventArgs e) // Remover Cliente
        {
            if (dgClientes.SelectedRows.Count > 0 && dgClientes.CurrentRow.Cells["codCliente"].Value != null)
            {
                int idRemove = Convert.ToInt32(dgClientes.CurrentRow.Cells["codCliente"].Value);
                if (MessageBox.Show("Remover cliente?", "Confirma", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConectaBanco con = new ConectaBanco();
                    if (con.deletaCliente(idRemove)) listaCliente();
                }
            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (dgClientes.CurrentRow != null && dgClientes.CurrentRow.Cells["codCliente"].Value != null)
            {
                idAlterar = Convert.ToInt32(dgClientes.CurrentRow.Cells["codCliente"].Value.ToString());
                txtAltCliente.Text = dgClientes.CurrentRow.Cells["nome"].Value.ToString();
                txtAltData.Text = dgClientes.CurrentRow.Cells["dataNascimento"].Value.ToString();
                txtAltCpf.Text = dgClientes.CurrentRow.Cells["cpf"].Value.ToString();
                txtAltUF.Text = dgClientes.CurrentRow.Cells["uf"].Value.ToString();
                txtAltEndereco.Text = dgClientes.CurrentRow.Cells["endereco"].Value.ToString();
                txtAltBairro.Text = dgClientes.CurrentRow.Cells["bairro"].Value.ToString();
                txtAltCidade.Text = dgClientes.CurrentRow.Cells["cidade"].Value.ToString();
                txtAltCEP.Text = dgClientes.CurrentRow.Cells["cep"].Value.ToString();
                txtAltEmail.Text = dgClientes.CurrentRow.Cells["email"].Value.ToString();
                BuscaCliente.SelectedIndex = 4;
            }
        }

        private void button3_Click(object sender, EventArgs e) // Confirmar Alterar Cliente
        {
            Cliente l = new Cliente();
            l.Nome = txtAltCliente.Text;
            l.DataNascimento = txtAltData.Text;
            l.CPF = txtAltCpf.Text;
            l.UF = txtAltUF.Text;
            l.Endereco = txtAltEndereco.Text;
            l.Bairro = txtAltBairro.Text;
            l.Cidade = txtAltCidade.Text;
            l.CEP = txtAltCEP.Text;
            l.Email = txtAltEmail.Text;

            ConectaBanco con = new ConectaBanco();
            if (con.alteraCliente(l, idAlterar))
            {
                MessageBox.Show("Alterado com sucesso!");
                BuscaCliente.SelectedIndex = 2; // Volta para lista
            }
            listaCliente();
        }

        // --- EDITORAS ---
        private void button1_Click(object sender, EventArgs e) // Cadastro Editora
        {
            if (string.IsNullOrWhiteSpace(txtnomeEditora.Text)) return;
            Editora b = new Editora();
            b.Nome = txtnomeEditora.Text;
            ConectaBanco con = new ConectaBanco();
            if (con.insereEditora(b))
            {
                MessageBox.Show("Editora salva!");
                txtnomeEditora.Clear();
            }
            lista_Editora();
        }

        private void btnRemoveBanda_Click(object sender, EventArgs e) // Remover Editora
        {
            if (dgEditora.SelectedRows.Count > 0 && dgEditora.CurrentRow.Cells["codEditora"].Value != null)
            {
                int idRemove = Convert.ToInt32(dgEditora.CurrentRow.Cells["codEditora"].Value);
                if (MessageBox.Show("Tem certeza que deseja apagar esta editora?", "Apagar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConectaBanco con = new ConectaBanco();
                    if (con.deletaEditora(idRemove))
                    {
                        MessageBox.Show("Editora apagada!");
                        lista_Editora();
                    }
                    else MessageBox.Show("Erro: " + con.mensagem);
                }
            }
            else MessageBox.Show("Selecione uma editora.");
        }

        private void btnAlterar_Click(object sender, EventArgs e) // Ir para alterar Editora
        {
            if (dgEditora.CurrentRow != null && dgEditora.CurrentRow.Cells["codEditora"].Value != null)
            {
                idAlterarEditora = Convert.ToInt32(dgEditora.CurrentRow.Cells["codEditora"].Value.ToString());
                txtAltNomeEditora.Text = dgEditora.CurrentRow.Cells["nome"].Value.ToString();
                BuscaCliente.SelectedIndex = 5; // Vai para a aba nova (Altera Editora)
            }
            else MessageBox.Show("Selecione uma editora.");
        }

        private void btnConfirmarAltEditora_Click(object sender, EventArgs e) // Salvar Editora
        {
            if (string.IsNullOrWhiteSpace(txtAltNomeEditora.Text)) return;

            ConectaBanco con = new ConectaBanco();
            if (con.alteraEditora(txtAltNomeEditora.Text, idAlterarEditora))
            {
                MessageBox.Show("Editora alterada!");
                BuscaCliente.SelectedIndex = 3; // Volta para lista
                lista_Editora();
            }
            else MessageBox.Show("Erro: " + con.mensagem);
        }

        // --- Filtros ---
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (dgClientes.DataSource as DataTable != null)
                (dgClientes.DataSource as DataTable).DefaultView.RowFilter = String.Format("nome like '%{0}%'", txtBuscaCliente.Text);
        }

        private void txtEditoras_TextChanged(object sender, EventArgs e)
        {
            if (dgEditora.DataSource as DataTable != null)
                (dgEditora.DataSource as DataTable).DefaultView.RowFilter = String.Format("nome like '%{0}%'", txtEditoras.Text);
        }

        // Placeholders
        private void txtnomeEditora_TextChanged(object sender, EventArgs e) { }
        private void tabCadastrar_Click(object sender, EventArgs e) { }
        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}