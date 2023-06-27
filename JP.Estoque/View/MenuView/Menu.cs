using JP.Estoque.View.Produto;

namespace JP.Estoque.View.MenuView
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.BackColor = Program.COLOR_BACKGROUND;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProdutosView().ShowDialog();
        }
    }
}
