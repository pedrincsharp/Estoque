namespace JP.Estoque.Util
{
    internal class Mensagens
    {
        public static void MensagemErro(Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MensagemSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult MensagemPergunta(string mensagem)
        {
            return MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
