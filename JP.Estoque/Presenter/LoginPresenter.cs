using JP.Estoque.Model;
using JP.Estoque.Repository;
using JP.Estoque.Util;
using JP.Estoque.View.CadastroView;
using JP.Estoque.View.LoginView;

namespace JP.Estoque.Presenter
{
    internal class LoginPresenter
    {
        private ILogin _view;
        private UsuarioRepository _repository;
        public bool Logado { get; set; }

        public LoginPresenter(ILogin view)
        {
            _view = view;
            _repository = new UsuarioRepository();
            _view.Entrar += _view_Entrar;
            _view.Cadastro += _view_Cadastro;
        }

        private void _view_Cadastro(object? sender, EventArgs e)
        {
            new CadastroUsuario().ShowDialog();
        }

        private async void _view_Entrar(object? sender, EventArgs e)
        {
            try
            {
                IEnumerable<Usuario> usuarios = await _repository.GetAll();
                Usuario usuario = usuarios.Where(x => x.Nome == _view.Nome && x.Senha == _view.Senha).FirstOrDefault()
                    ?? throw new Exception("Usuário ou senha inválido!");
                Mensagens.MensagemSucesso("Logado com sucesso!");
                this.Logado = true;
            }
            catch (Exception ex)
            {
                Mensagens.MensagemErro(ex);
                this.Logado = false;
            }
        }
    }
}
