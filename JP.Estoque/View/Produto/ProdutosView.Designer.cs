namespace JP.Estoque.View.Produto
{
    partial class ProdutosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutosView));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLimparTab1 = new Button();
            btnPesquisa = new Button();
            txtNome = new TextBox();
            gridPesq = new DataGridView();
            tabPage2 = new TabPage();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            gridCad = new DataGridView();
            txtVenda = new TextBox();
            txtCusto = new TextBox();
            txtEstoque = new TextBox();
            txtNomeTab2 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPesq).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCad).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(815, 352);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLimparTab1);
            tabPage1.Controls.Add(btnPesquisa);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(gridPesq);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(807, 324);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listagem";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimparTab1
            // 
            btnLimparTab1.Location = new Point(665, 34);
            btnLimparTab1.Name = "btnLimparTab1";
            btnLimparTab1.Size = new Size(134, 23);
            btnLimparTab1.TabIndex = 8;
            btnLimparTab1.Text = "Limpar";
            btnLimparTab1.UseVisualStyleBackColor = true;
            btnLimparTab1.Click += btnLimparTab1_Click;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(665, 5);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(134, 23);
            btnPesquisa.TabIndex = 3;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(8, 6);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(651, 23);
            txtNome.TabIndex = 2;
            // 
            // gridPesq
            // 
            gridPesq.AllowUserToAddRows = false;
            gridPesq.AllowUserToDeleteRows = false;
            gridPesq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPesq.Dock = DockStyle.Bottom;
            gridPesq.Location = new Point(3, 65);
            gridPesq.Name = "gridPesq";
            gridPesq.ReadOnly = true;
            gridPesq.RowTemplate.Height = 25;
            gridPesq.Size = new Size(801, 256);
            gridPesq.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnLimpar);
            tabPage2.Controls.Add(btnExcluir);
            tabPage2.Controls.Add(btnSalvar);
            tabPage2.Controls.Add(gridCad);
            tabPage2.Controls.Add(txtVenda);
            tabPage2.Controls.Add(txtCusto);
            tabPage2.Controls.Add(txtEstoque);
            tabPage2.Controls.Add(txtNomeTab2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(807, 324);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(490, 35);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(99, 23);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(595, 36);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(99, 23);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(700, 35);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(99, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // gridCad
            // 
            gridCad.AllowUserToAddRows = false;
            gridCad.AllowUserToDeleteRows = false;
            gridCad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCad.Dock = DockStyle.Bottom;
            gridCad.Location = new Point(3, 65);
            gridCad.Name = "gridCad";
            gridCad.ReadOnly = true;
            gridCad.RowTemplate.Height = 25;
            gridCad.Size = new Size(801, 256);
            gridCad.TabIndex = 10;
            // 
            // txtVenda
            // 
            txtVenda.Location = new Point(700, 6);
            txtVenda.MaxLength = 15;
            txtVenda.Name = "txtVenda";
            txtVenda.PlaceholderText = "Valor de venda";
            txtVenda.Size = new Size(100, 23);
            txtVenda.TabIndex = 3;
            // 
            // txtCusto
            // 
            txtCusto.Location = new Point(594, 6);
            txtCusto.MaxLength = 15;
            txtCusto.Name = "txtCusto";
            txtCusto.PlaceholderText = "Valor de custo";
            txtCusto.Size = new Size(100, 23);
            txtCusto.TabIndex = 2;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(488, 6);
            txtEstoque.MaxLength = 15;
            txtEstoque.Name = "txtEstoque";
            txtEstoque.PlaceholderText = "Estoque";
            txtEstoque.Size = new Size(100, 23);
            txtEstoque.TabIndex = 1;
            // 
            // txtNomeTab2
            // 
            txtNomeTab2.Location = new Point(8, 6);
            txtNomeTab2.MaxLength = 30;
            txtNomeTab2.Name = "txtNomeTab2";
            txtNomeTab2.PlaceholderText = "Nome";
            txtNomeTab2.Size = new Size(474, 23);
            txtNomeTab2.TabIndex = 0;
            // 
            // ProdutosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 352);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ProdutosView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPesq).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView gridPesq;
        private TextBox txtNome;
        private Button btnPesquisa;
        private TextBox txtVenda;
        private TextBox txtCusto;
        private TextBox txtEstoque;
        private TextBox txtNomeTab2;
        private DataGridView gridCad;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnLimparTab1;
    }
}