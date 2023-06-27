using JP.Estoque.Model;
using JP.Estoque.Repository;
using JP.Estoque.Util;
using JP.Estoque.View.CadastroView;

namespace JP.Estoque.Presenter
{
    internal class CadastroUsuarioPresenter
    {
        private UsuarioRepository _repository;
        private ICadastroUsuario _view;

        public CadastroUsuarioPresenter(ICadastroUsuario view)
        {
            _view = view;
            _repository = new UsuarioRepository();
            view.Cadastrar += View_Cadastrar;
        }

        private async void View_Cadastrar(object? sender, EventArgs e)
        {
            try
            {
                if (await Existe())
                    throw new Exception("Usuário já cadastrado!");

                await _repository.Insert(new Usuario()
                {
                    Nome = _view.Nome,
                    Senha = _view.Senha,
                    dataCadastro = DateTime.Now,
                });

                Mensagens.MensagemSucesso("Usuário cadastrado com sucesso!");

            }
            catch (Exception ex)
            {
                Mensagens.MensagemErro(ex);
            }
        }

        private async Task<bool> Existe()
        {
            IEnumerable<Usuario> usuarios = await _repository.GetAll();
            return usuarios.Where(x => x.Nome == _view.Nome && x.Senha == _view.Senha).FirstOrDefault() != null ? true : false;
        }
    }
}
