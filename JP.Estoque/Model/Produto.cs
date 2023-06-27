namespace JP.Estoque.Model
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime dataCadastro { get; set; }
        public double Estoque { get; set; }
        public double valorCusto { get; set; }
        public double valorVenda { get; set; }
    }
}
