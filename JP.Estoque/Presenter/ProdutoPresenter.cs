using JP.Estoque.Model;
using JP.Estoque.Repository;
using JP.Estoque.Util;
using JP.Estoque.View.Produto;

namespace JP.Estoque.Presenter
{
    internal class ProdutoPresenter
    {
        private IProdutosView _view;
        private ProdutoRepository _produtosRepository;
        private IEnumerable<Produto> _produtos;
        private BindingSource _produtoBinding;
        private IEnumerable<Produto> _produtosPesquisa;
        private BindingSource _produtoBindingPesquisa;

        public ProdutoPresenter(IProdutosView view)
        {
            _produtoBinding = new BindingSource();
            _produtoBindingPesquisa = new BindingSource();
            _view = view;
            _produtosRepository = new ProdutoRepository();
            _view.SetListBindingSource(_produtoBinding);
            _view.SetListBindingSourceSearch(_produtoBindingPesquisa);
            _view.Salvar += _view_Salvar;
            _view.Pesquisar += _view_Pesquisar;
            _view.Excluir += _view_Excluir;
            _view.Selecionar += _view_Selecionar;
            _view.SelecionarCad += _view_SelecionarCad;
            CarregarProdutos();
        }

        private void _view_SelecionarCad(object? sender, EventArgs e)
        {
            try
            {
                var resp = Mensagens.MensagemPergunta("Deseja alterar esse registro?");
                if (resp == DialogResult.No)
                    return;
                PreencheProduto(CarregarProduto());
            }
            catch (Exception ex)
            {
                Mensagens.MensagemErro(ex);
            }

        }

        private Produto CarregarProduto()
        {
            if (_view.Selecionado == null)
                throw new Exception("Erro ao carregar produto!");
            return (Produto)_view.Selecionado;
        }

        private void PreencheProduto(Produto prod)
        {
            _view.Id = prod.Id;
            _view.Nome = prod.Nome;
            _view.Estoque = prod.Estoque;
            _view.valorCusto = prod.valorCusto;
            _view.valorVenda = prod.valorVenda;
        }

        private void _view_Selecionar(object? sender, EventArgs e)
        {
            try
            {
                var resp = Mensagens.MensagemPergunta("Deseja alterar esse registro?");
                if (resp == DialogResult.No)
                    return;
                PreencheProduto(CarregarProduto());
            }
            catch (Exception ex)
            {
                Mensagens.MensagemErro(ex);
            }
        }

        private async void _view_Excluir(object? sender, EventArgs e)
        {
            try
            {
                if (_view.Id == 0 || !await Existe(_view.Id))
                {
                    throw new Exception("Necessário selecionar um produto válido!");
                }

                await _produtosRepository.Delete(_view.Id);

                Mensagens.MensagemSucesso("Produuto excluido com sucesso!");
                CarregarProdutos();
            }
            catch (Exception ex)
            {
                Mensagens.MensagemErro(ex);
            }
        }

        private async void CarregarProdutos()
        {
            _produtos = await _produtosRepository.GetAll();
            _produtosPesquisa = _produtos;
            _produtoBindingPesquisa.DataSource = _produtosPesquisa;
            _produtoBinding.DataSource = _produtos;
        }

        private void _view_Pesquisar(object? sender, EventArgs e)
        {
            CarregarProdutos();
            _produtosPesquisa = _produtos.Where(x => x.Nome.Contains(_view.NomePesquisa)) ?? _produtos;
            _produtoBindingPesquisa.DataSource = _produtosPesquisa;
        }

        private async Task<bool> Existe(int Id)
        {
            Produto produto = await _produtosRepository.Get(Id);
            return produto != null;
        }

        private async void _view_Salvar(object? sender, EventArgs e)
        {
            try
            {
                if (await Existe(_view.Id))
                {
                    await _produtosRepository.Update(new Produto()
                    {
                        Id = _view.Id,
                        Estoque = _view.Estoque,
                        Nome = _view.Nome,
                        valorCusto = _view.valorCusto,
                        valorVenda = _view.valorVenda,
                        dataCadastro = DateTime.Now
                    });
                }
                else
                {
                    await _produtosRepository.Insert(new Produto()
                    {
                        Estoque = _view.Estoque,
                        Nome = _view.Nome,
                        valorCusto = _view.valorCusto,
                        valorVenda = _view.valorVenda,
                        dataCadastro = DateTime.Now
                    });
                }
                Mensagens.MensagemSucesso("Produto salvo com sucesso!");
                CarregarProdutos();
            }
            catch (Exception ex)
            {
                Mensagens.MensagemErro(ex);
            }
        }
    }
}
