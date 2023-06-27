using JP.Estoque.Presenter;
using JP.Estoque.Util;

namespace JP.Estoque.View.Produto
{
    public partial class ProdutosView : Form, IProdutosView
    {
        ProdutoPresenter presenter;

        public ProdutosView()
        {
            InitializeComponent();
            this.BackColor = Program.COLOR_BACKGROUND;
            presenter = new ProdutoPresenter(this);


            //Setar eventos
            btnSalvar.Click += delegate { Salvar?.Invoke(this, EventArgs.Empty); };
            btnExcluir.Click += delegate { Excluir?.Invoke(this, EventArgs.Empty); };
            btnPesquisa.Click += delegate { Pesquisar?.Invoke(this, EventArgs.Empty); };
            gridPesq.Click += delegate { Selecionar?.Invoke(this, EventArgs.Empty); if (!string.IsNullOrWhiteSpace(txtNomeTab2.Text)) tabControl1.SelectedTab = tabPage2; };
            gridCad.Click += delegate { SelecionarCad?.Invoke(this, EventArgs.Empty); };
        }

        public int Id { get; set; }
        public string Nome { get => txtNomeTab2.Text; set => txtNomeTab2.Text = value; }
        public double Estoque { get => Convert.ToDouble(txtEstoque.Text); set => txtEstoque.Text = value.ToString(); }
        public double valorCusto { get => Convert.ToDouble(txtCusto.Text); set => txtCusto.Text = value.ToString(); }
        public double valorVenda { get => Convert.ToDouble(txtVenda.Text); set => txtVenda.Text = value.ToString(); }
        public string NomePesquisa { get => txtNome.Text; set => txtNome.Text = value; }
        public object Selecionado
        {
            get
            {
                int rowIndex;
                if (tabControl1.SelectedTab == tabPage2)
                    rowIndex = gridCad.SelectedCells[0].RowIndex;
                else
                    rowIndex = gridPesq.SelectedCells[0].RowIndex;

                return gridPesq.Rows[rowIndex].DataBoundItem;
            }
        }

        public event EventHandler Salvar;
        public event EventHandler Excluir;
        public event EventHandler Pesquisar;
        public event EventHandler Selecionar;
        public event EventHandler SelecionarCad;

        public void SetListBindingSource(BindingSource binding)
        {
            gridCad.DataSource = binding;
        }

        public void SetListBindingSourceSearch(BindingSource binding)
        {
            gridPesq.DataSource = binding;
        }

        private void btnLimparTab1_Click(object sender, EventArgs e)
        {
            presenter = new ProdutoPresenter(this);
            FuncoesView.LimparTelas(tabPage1);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            presenter = new ProdutoPresenter(this);
            FuncoesView.LimparTelas(tabPage2);
        }
    }
}
