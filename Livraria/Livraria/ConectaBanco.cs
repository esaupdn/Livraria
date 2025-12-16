using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Livraria
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=livraria2si");
        public String? mensagem;

        

        public DataTable? lista_editora()
        {
            MySqlCommand cmd = new MySqlCommand("Lista_Editora", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try { conexao.Open(); MySqlDataAdapter da = new MySqlDataAdapter(cmd); DataTable tabela = new DataTable(); da.Fill(tabela); return tabela; }
            catch (MySqlException e) { mensagem = "Erro:" + e.Message; return null; }
            finally { conexao.Close(); }
        }

        public DataTable? listaCliente()
        {
            MySqlCommand cmd = new MySqlCommand("lista_cliente", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try { conexao.Open(); MySqlDataAdapter da = new MySqlDataAdapter(cmd); DataTable tabela = new DataTable(); da.Fill(tabela); return tabela; }
            catch (MySqlException e) { mensagem = "Erro:" + e.Message; return null; }
            finally { conexao.Close(); }
        }

        public bool insereCliente(Cliente cliente)
        {
            MySqlCommand cmd = new MySqlCommand("insere_cliente", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", cliente.Nome);
            cmd.Parameters.AddWithValue("dataNascimento", cliente.DataNascimento);
            cmd.Parameters.AddWithValue("cpf", cliente.CPF);
            cmd.Parameters.AddWithValue("uf", cliente.UF);
            cmd.Parameters.AddWithValue("endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("cep", cliente.CEP);
            cmd.Parameters.AddWithValue("email", cliente.Email);
            try { conexao.Open(); cmd.ExecuteNonQuery(); return true; }
            catch (MySqlException e) { mensagem = "Erro:" + e.Message; return false; }
            finally { conexao.Close(); }
        }

        public bool alteraCliente(Cliente b, int idAlterar)
        {
            MySqlCommand cmd = new MySqlCommand("altera_Cliente", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("novoNome", b.Nome);
            cmd.Parameters.AddWithValue("novaData", b.DataNascimento);
            cmd.Parameters.AddWithValue("novoCpf", b.CPF);
            cmd.Parameters.AddWithValue("novoUf", b.UF);
            cmd.Parameters.AddWithValue("novoEnd", b.Endereco);
            cmd.Parameters.AddWithValue("novoBairro", b.Bairro);
            cmd.Parameters.AddWithValue("novaCity", b.Cidade);
            cmd.Parameters.AddWithValue("novoCep", b.CEP);
            cmd.Parameters.AddWithValue("novoEmail", b.Email);
            cmd.Parameters.AddWithValue("codigo", idAlterar);
            try { conexao.Open(); cmd.ExecuteNonQuery(); return true; }
            catch (MySqlException e) { mensagem = "Erro:" + e.Message; return false; }
            finally { conexao.Close(); }
        }

        public bool deletaCliente(int idDeletar)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deleteCliente", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codExcluir", idDeletar);
            try { conexao.Open(); cmd.ExecuteNonQuery(); return true; }
            catch (MySqlException e) { mensagem = "Erro:" + e.Message; return false; }
            finally { conexao.Close(); }
        }

        public bool insereEditora(Editora editora)
        {
            MySqlCommand cmd = new MySqlCommand("insere_editora", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("novoNome", editora.Nome);
            try { conexao.Open(); cmd.ExecuteNonQuery(); return true; }
            catch (MySqlException e) { mensagem = "Erro:" + e.Message; return false; }
            finally { conexao.Close(); }
        }

        

        public bool deletaEditora(int idDeletar)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deleteEditora", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codExcluir", idDeletar);
            try { conexao.Open(); cmd.ExecuteNonQuery(); return true; }
            catch (MySqlException e) { mensagem = "Erro:" + e.Message; return false; }
            finally { conexao.Close(); }
        }

        public bool alteraEditora(string novoNome, int idAlterar)
        {
            // SQL direto para evitar erros com procedures antigas
            string sql = "UPDATE editora SET nome = @nome WHERE codEditora = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", novoNome);
            cmd.Parameters.AddWithValue("@id", idAlterar);
            try { conexao.Open(); cmd.ExecuteNonQuery(); return true; }
            catch (MySqlException e) { mensagem = "Erro:" + e.Message; return false; }
            finally { conexao.Close(); }
        }

        public bool verifica(string user, string pass)
        {
            string senhaHash = BibliotecaHash.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0) return true;
                else return false;
            }
            catch (MySqlException er) { mensagem = "Erro" + er.Message; return false; }
            finally { conexao.Close(); }
        }
    }
}