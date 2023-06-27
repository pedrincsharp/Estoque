namespace JP.Estoque.View.CadastroView
{
    partial class CadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            chkMostrar = new CheckBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // chkMostrar
            // 
            chkMostrar.AutoSize = true;
            chkMostrar.Location = new Point(12, 123);
            chkMostrar.Name = "chkMostrar";
            chkMostrar.Size = new Size(101, 19);
            chkMostrar.TabIndex = 8;
            chkMostrar.Text = "Mostrar senha";
            chkMostrar.UseVisualStyleBackColor = true;
            chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 48);
            txtUsuario.MaxLength = 30;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(290, 23);
            txtUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 94);
            txtSenha.MaxLength = 16;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(290, 23);
            txtSenha.TabIndex = 7;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 6;
            label1.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 148);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(290, 31);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 194);
            Controls.Add(chkMostrar);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "CadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            KeyDown += CadastroUsuario_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkMostrar;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label1;
        private Button btnCadastrar;
    }
}