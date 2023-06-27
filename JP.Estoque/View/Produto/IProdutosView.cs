namespace JP.Estoque.View.Produto
{
    internal interface IProdutosView
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomePesquisa { get; set; }
        public double Estoque { get; set; }
        public double valorCusto { get; set; }
        public double valorVenda { get; set; }
        public object Selecionado { get; }

        event EventHandler Salvar;
        event EventHandler Excluir;
        event EventHandler Pesquisar;
        event EventHandler Selecionar;
        event EventHandler SelecionarCad;

        void SetListBindingSource(BindingSource binding);
        void SetListBindingSourceSearch(BindingSource binding);
    }
}

