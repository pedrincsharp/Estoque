namespace JP.Estoque.View.CadastroView
{
    internal interface ICadastroUsuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        event EventHandler Cadastrar;
    }
}
