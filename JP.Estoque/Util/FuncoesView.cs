namespace JP.Estoque.Util
{
    internal class FuncoesView
    {
        public static void LimparTelas(Control tela)
        {
            foreach (Control control in tela.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).Text = string.Empty;
                }

                if (control.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }
    }
}
