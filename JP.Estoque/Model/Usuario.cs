namespace JP.Estoque.Model
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public DateTime dataCadastro { get; set; }

        public Usuario() { }

        public Usuario(int id, string nome, string senha, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            this.dataCadastro = dataCadastro;
        }
    }
}
