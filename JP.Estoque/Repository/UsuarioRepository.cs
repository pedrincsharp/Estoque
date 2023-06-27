using Dapper;
using JP.Estoque.Model;

namespace JP.Estoque.Repository
{
    internal class UsuarioRepository : IRepo<Usuario>
    {
        private Conexao _conexao;

        public UsuarioRepository()
        {
            _conexao = new Conexao();
        }

        public async Task Delete(int id)
        {
            string ssql = "DELETE FROM usuario WHERE Id = @id";
            using (var db = _conexao.AbrirConexao())
            {
                await db.ExecuteAsync(ssql, new { id });
            }
        }

        public async Task<Usuario> Get(int id)
        {
            string ssql = "SELECT * FROM usuario WHERE Id = @id";
            using (var db = _conexao.AbrirConexao())
            {
                return await db.QueryFirstOrDefaultAsync<Usuario>(ssql, new { id });
            }
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            string ssql = "SELECT * FROM usuario";
            using (var db = _conexao.AbrirConexao())
            {
                return await db.QueryAsync<Usuario>(ssql);
            }
        }

        public async Task Insert(Usuario item)
        {
            string ssql = "INSERT INTO usuario (Nome,Senha,dataCadastro) VALUES(@Nome,@Senha,@dataCadastro)";
            using (var db = _conexao.AbrirConexao())
            {
                await db.ExecuteAsync(ssql, item);
            }
        }

        public async Task Update(Usuario item)
        {
            string ssql = "UPDATE usuario SET Nome = @Nome, Senha = @Senha, dataCadastro = @dataCadastro" +
                " WHERE Id = @Id";
            using (var db = _conexao.AbrirConexao())
            {
                await db.ExecuteAsync(ssql, item);
            }
        }
    }
}
