namespace JP.Estoque.View.LoginView
{
    internal interface ILogin
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        event EventHandler Entrar;
        event EventHandler Cadastro;
    }
}
