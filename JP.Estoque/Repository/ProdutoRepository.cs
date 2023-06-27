using Dapper;
using JP.Estoque.Model;

namespace JP.Estoque.Repository
{
    internal class ProdutoRepository : IRepo<Produto>
    {
        private Conexao _conexao;

        public ProdutoRepository()
        {
            _conexao = new Conexao();
        }

        public async Task Delete(int id)
        {
            string ssql = "DELETE FROM produto WHERE Id = @id";
            using (var db = _conexao.AbrirConexao())
            {
                await db.ExecuteAsync(ssql, new { id });
            }
        }

        public async Task<Produto> Get(int id)
        {
            string ssql = "SELECT * FROM produto WHERE Id = @id";
            using (var db = _conexao.AbrirConexao())
            {
                return await db.QueryFirstOrDefaultAsync<Produto>(ssql, new { id });
            }
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            string ssql = "SELECT * FROM produto";
            using (var db = _conexao.AbrirConexao())
            {
                return await db.QueryAsync<Produto>(ssql);
            }
        }

        public async Task Insert(Produto item)
        {
            string ssql = "INSERT INTO produto (Nome,dataCadastro,Estoque,valorCusto,valorVenda) " +
                "VALUES(@Nome,@dataCadastro,@Estoque,@valorCusto,@valorVenda)";
            using (var db = _conexao.AbrirConexao())
            {
                await db.ExecuteAsync(ssql, item);
            }
        }

        public async Task Update(Produto item)
        {
            string ssql = "UPDATE produto SET Nome = @Nome, " +
                "dataCadastro = @dataCadastro, Estoque = @Estoque, valorCusto = @valorCusto," +
                "valorVenda = @valorVenda WHERE Id = @Id";
            using (var db = _conexao.AbrirConexao())
            {
                await db.ExecuteAsync(ssql, item);
            }
        }
    }
}
