using JP.Estoque.Presenter;
using JP.Estoque.Util;

namespace JP.Estoque.View.CadastroView
{
    public partial class CadastroUsuario : Form, ICadastroUsuario
    {
        CadastroUsuarioPresenter presenter;

        public CadastroUsuario()
        {
            InitializeComponent();
            presenter = new CadastroUsuarioPresenter(this);
            this.BackColor = Program.COLOR_WINDOW;
            btnCadastrar.Click += delegate { Cadastrar?.Invoke(this, EventArgs.Empty); FuncoesView.LimparTelas(this); };
        }

        public string Nome { get => txtUsuario.Text; set => txtUsuario.Text = value; }
        public string Senha { get => txtSenha.Text; set => txtSenha.Text = value; }

        public event EventHandler Cadastrar;

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !chkMostrar.Checked;
        }

        private void CadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
