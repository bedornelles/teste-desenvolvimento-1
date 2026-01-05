using System.Data;
using Npgsql;

namespace CadastroProdutosCervantes.Data
{
    public class ProdutoRepository
    {
        public DataTable ListarProdutos()
        {
            using (var conexao = Database.GetConnection())
            {
                conexao.Open();

                string sql =
                    "SELECT codigo_produto, nome_produto " +
                    "FROM produto " +
                    "ORDER BY codigo_produto";

                using (var cmd = new NpgsqlCommand(sql, conexao))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    var tabela = new DataTable();
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }
        public void InserirProduto(int codigo, string nome)
        {
            using (var conexao = Database.GetConnection())
            {
                conexao.Open();

                string sql =
                    "INSERT INTO produto (codigo_produto, nome_produto) " +
                    "VALUES (@codigo, @nome)";

                using (var cmd = new NpgsqlCommand (sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@nome", nome);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool AtualizarProduto(int codigo, string nome)
        {
            using (var conexao = Database.GetConnection())
            { 
                conexao.Open();

                string sql =
                    "UPDATE produto " +
                    "SET nome_produto = @nome " +
                    "WHERE codigo_produto = @codigo";
                
                using (var cmd = new NpgsqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@nome", nome);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    return linhasAfetadas > 0;
                }
            }
        }

        public void ExcluirProduto(int codigo)
        {
            using (var conexao = Database.GetConnection())
            {
                conexao.Open();

                string sql =
                    "DELETE FROM produto " +
                    "WHERE codigo_produto = @codigo";


                using (var cmd = new NpgsqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
