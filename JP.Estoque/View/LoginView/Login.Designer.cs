namespace JP.Estoque
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnEntrar = new Button();
            label1 = new Label();
            txtSenha = new TextBox();
            chkMostrar = new CheckBox();
            txtUsuario = new TextBox();
            lblCadastro = new LinkLabel();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(12, 144);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(290, 31);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 1;
            label1.Text = "Bem Vindo!";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 90);
            txtSenha.MaxLength = 16;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(290, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // chkMostrar
            // 
            chkMostrar.AutoSize = true;
            chkMostrar.Location = new Point(12, 119);
            chkMostrar.Name = "chkMostrar";
            chkMostrar.Size = new Size(101, 19);
            chkMostrar.TabIndex = 3;
            chkMostrar.Text = "Mostrar senha";
            chkMostrar.UseVisualStyleBackColor = true;
            chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 44);
            txtUsuario.MaxLength = 30;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(290, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Location = new Point(242, 120);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(54, 15);
            lblCadastro.TabIndex = 5;
            lblCadastro.TabStop = true;
            lblCadastro.Text = "Cadastro";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(314, 189);
            Controls.Add(lblCadastro);
            Controls.Add(chkMostrar);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            KeyDown += Login_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label label1;
        private TextBox txtSenha;
        private CheckBox chkMostrar;
        private TextBox txtUsuario;
        private LinkLabel lblCadastro;
    }
}