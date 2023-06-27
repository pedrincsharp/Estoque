using JP.Estoque.Presenter;
using JP.Estoque.View.LoginView;
using JP.Estoque.View.MenuView;

namespace JP.Estoque
{
    public partial class Login : Form, ILogin
    {
        LoginPresenter presenter;
        public Login()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
            this.BackColor = Program.COLOR_WINDOW;
            btnEntrar.Click += delegate { Entrar?.Invoke(this, EventArgs.Empty); AbrirMenu(); };
            lblCadastro.Click += delegate { Cadastro?.Invoke(this, EventArgs.Empty); };
        }

        public string Nome { get => txtUsuario.Text; set => txtUsuario.Text = value; }
        public string Senha { get => txtSenha.Text; set => txtSenha.Text = value; }

        public event EventHandler Entrar;
        public event EventHandler Cadastro;

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !chkMostrar.Checked;
        }

        private void AbrirMenu()
        {
            if (!presenter.Logado)
                return;

            new Menu().Show();
            this.Hide();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}