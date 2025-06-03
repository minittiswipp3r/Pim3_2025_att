namespace Pim3_2025.Telas_De_Administrador
{
    partial class TelaAdminPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAdminPrincipal));
            pnlPrincipalAdm = new Panel();
            label1 = new Label();
            lblCadastroLivros_TelaAdm = new Label();
            pictureBox2 = new PictureBox();
            btnSair_TelaAdm = new Button();
            lblEstoque_TelaAdm = new Label();
            lblDevolucao_TelaAdm = new Label();
            lblEmprestimo_TelaAdm = new Label();
            lblCadastroPessoa_TelaAdm = new Label();
            pictureBox1 = new PictureBox();
            lblSuspenderRetomarLivrosAdm = new Label();
            lblSuspenderRetomarClienteAdm = new Label();
            lblLivrosCadastradosAdm = new Label();
            lblBiblioteca = new Label();
            panel2 = new Panel();
            lblDesconectarAdm = new Label();
            lblLivrosEmprestadosAdm = new Label();
            lblClientesCadastradosAdm = new Label();
            panel1 = new Panel();
            pnlPrincipalAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipalAdm
            // 
            pnlPrincipalAdm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipalAdm.BackColor = SystemColors.Menu;
            pnlPrincipalAdm.Controls.Add(label1);
            pnlPrincipalAdm.Location = new Point(275, 180);
            pnlPrincipalAdm.Margin = new Padding(3, 2, 3, 2);
            pnlPrincipalAdm.Name = "pnlPrincipalAdm";
            pnlPrincipalAdm.Size = new Size(1342, 559);
            pnlPrincipalAdm.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 111);
            label1.Name = "label1";
            label1.Size = new Size(780, 336);
            label1.TabIndex = 0;
            label1.Text = "     Bem Vindo\r\n            ao\r\nBiblioteca de Povo";
            // 
            // lblCadastroLivros_TelaAdm
            // 
            lblCadastroLivros_TelaAdm.AutoSize = true;
            lblCadastroLivros_TelaAdm.Cursor = Cursors.Hand;
            lblCadastroLivros_TelaAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCadastroLivros_TelaAdm.ForeColor = Color.White;
            lblCadastroLivros_TelaAdm.Location = new Point(646, 44);
            lblCadastroLivros_TelaAdm.Name = "lblCadastroLivros_TelaAdm";
            lblCadastroLivros_TelaAdm.Size = new Size(168, 25);
            lblCadastroLivros_TelaAdm.TabIndex = 8;
            lblCadastroLivros_TelaAdm.Text = "Cadastro de Livro";
            lblCadastroLivros_TelaAdm.Click += lblCadastroLivros_TelaAdm_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1526, 10);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnSair_TelaAdm
            // 
            btnSair_TelaAdm.BackColor = Color.Red;
            btnSair_TelaAdm.Cursor = Cursors.Hand;
            btnSair_TelaAdm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair_TelaAdm.ForeColor = Color.White;
            btnSair_TelaAdm.Location = new Point(1364, 34);
            btnSair_TelaAdm.Margin = new Padding(3, 2, 3, 2);
            btnSair_TelaAdm.Name = "btnSair_TelaAdm";
            btnSair_TelaAdm.Size = new Size(89, 35);
            btnSair_TelaAdm.TabIndex = 7;
            btnSair_TelaAdm.Text = "SAIR";
            btnSair_TelaAdm.UseVisualStyleBackColor = false;
            btnSair_TelaAdm.Click += btnSair_TelaAdm_Click;
            // 
            // lblEstoque_TelaAdm
            // 
            lblEstoque_TelaAdm.AutoSize = true;
            lblEstoque_TelaAdm.Cursor = Cursors.Hand;
            lblEstoque_TelaAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEstoque_TelaAdm.ForeColor = Color.White;
            lblEstoque_TelaAdm.Location = new Point(1217, 44);
            lblEstoque_TelaAdm.Name = "lblEstoque_TelaAdm";
            lblEstoque_TelaAdm.Size = new Size(83, 25);
            lblEstoque_TelaAdm.TabIndex = 6;
            lblEstoque_TelaAdm.Text = "Estoque";
            lblEstoque_TelaAdm.Click += lblEstoque_TelaAdm_Click;
            // 
            // lblDevolucao_TelaAdm
            // 
            lblDevolucao_TelaAdm.AutoSize = true;
            lblDevolucao_TelaAdm.Cursor = Cursors.Hand;
            lblDevolucao_TelaAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblDevolucao_TelaAdm.ForeColor = Color.White;
            lblDevolucao_TelaAdm.Location = new Point(1042, 44);
            lblDevolucao_TelaAdm.Name = "lblDevolucao_TelaAdm";
            lblDevolucao_TelaAdm.Size = new Size(106, 25);
            lblDevolucao_TelaAdm.TabIndex = 4;
            lblDevolucao_TelaAdm.Text = "Devolução";
            lblDevolucao_TelaAdm.Click += lblDevolucao_TelaAdm_Click;
            // 
            // lblEmprestimo_TelaAdm
            // 
            lblEmprestimo_TelaAdm.AutoSize = true;
            lblEmprestimo_TelaAdm.Cursor = Cursors.Hand;
            lblEmprestimo_TelaAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEmprestimo_TelaAdm.ForeColor = Color.White;
            lblEmprestimo_TelaAdm.Location = new Point(853, 44);
            lblEmprestimo_TelaAdm.Name = "lblEmprestimo_TelaAdm";
            lblEmprestimo_TelaAdm.Size = new Size(118, 25);
            lblEmprestimo_TelaAdm.TabIndex = 3;
            lblEmprestimo_TelaAdm.Text = "Empréstimo";
            lblEmprestimo_TelaAdm.Click += lblEmprestimo_TelaAdm_Click;
            // 
            // lblCadastroPessoa_TelaAdm
            // 
            lblCadastroPessoa_TelaAdm.AutoSize = true;
            lblCadastroPessoa_TelaAdm.Cursor = Cursors.Hand;
            lblCadastroPessoa_TelaAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCadastroPessoa_TelaAdm.ForeColor = Color.White;
            lblCadastroPessoa_TelaAdm.Location = new Point(422, 44);
            lblCadastroPessoa_TelaAdm.Name = "lblCadastroPessoa_TelaAdm";
            lblCadastroPessoa_TelaAdm.Size = new Size(182, 25);
            lblCadastroPessoa_TelaAdm.TabIndex = 1;
            lblCadastroPessoa_TelaAdm.Text = "Cadastro de Pessoa";
            lblCadastroPessoa_TelaAdm.Click += lblCadastroCliente_TelaAdm_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 7);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblSuspenderRetomarLivrosAdm
            // 
            lblSuspenderRetomarLivrosAdm.AutoSize = true;
            lblSuspenderRetomarLivrosAdm.Cursor = Cursors.Hand;
            lblSuspenderRetomarLivrosAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblSuspenderRetomarLivrosAdm.ForeColor = Color.White;
            lblSuspenderRetomarLivrosAdm.Location = new Point(16, 385);
            lblSuspenderRetomarLivrosAdm.Name = "lblSuspenderRetomarLivrosAdm";
            lblSuspenderRetomarLivrosAdm.Size = new Size(191, 50);
            lblSuspenderRetomarLivrosAdm.TabIndex = 11;
            lblSuspenderRetomarLivrosAdm.Text = "Suspender/Retomar\r\n            Livro";
            lblSuspenderRetomarLivrosAdm.Click += lblSuspenderRetomarLivrosAdm_Click;
            // 
            // lblSuspenderRetomarClienteAdm
            // 
            lblSuspenderRetomarClienteAdm.AutoSize = true;
            lblSuspenderRetomarClienteAdm.Cursor = Cursors.Hand;
            lblSuspenderRetomarClienteAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblSuspenderRetomarClienteAdm.ForeColor = Color.White;
            lblSuspenderRetomarClienteAdm.Location = new Point(16, 287);
            lblSuspenderRetomarClienteAdm.Name = "lblSuspenderRetomarClienteAdm";
            lblSuspenderRetomarClienteAdm.Size = new Size(196, 50);
            lblSuspenderRetomarClienteAdm.TabIndex = 10;
            lblSuspenderRetomarClienteAdm.Text = "Suspender/Retomar \r\n          Cliente";
            lblSuspenderRetomarClienteAdm.Click += lblSuspenderRetomarClienteAdm_Click;
            // 
            // lblLivrosCadastradosAdm
            // 
            lblLivrosCadastradosAdm.AutoSize = true;
            lblLivrosCadastradosAdm.Cursor = Cursors.Hand;
            lblLivrosCadastradosAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblLivrosCadastradosAdm.ForeColor = Color.White;
            lblLivrosCadastradosAdm.Location = new Point(16, 132);
            lblLivrosCadastradosAdm.Name = "lblLivrosCadastradosAdm";
            lblLivrosCadastradosAdm.Size = new Size(179, 25);
            lblLivrosCadastradosAdm.TabIndex = 9;
            lblLivrosCadastradosAdm.Text = "Livros Cadastrados";
            lblLivrosCadastradosAdm.Click += lblLivrosCadastradosAdm_Click;
            // 
            // lblBiblioteca
            // 
            lblBiblioteca.AutoSize = true;
            lblBiblioteca.Cursor = Cursors.Hand;
            lblBiblioteca.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBiblioteca.ForeColor = Color.White;
            lblBiblioteca.Location = new Point(207, 14);
            lblBiblioteca.Name = "lblBiblioteca";
            lblBiblioteca.Size = new Size(127, 81);
            lblBiblioteca.TabIndex = 0;
            lblBiblioteca.Text = "Biblioteca\r\n     de \r\n   Povo";
            lblBiblioteca.TextAlign = ContentAlignment.MiddleLeft;
            lblBiblioteca.Click += lblBiblioteca_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(lblDesconectarAdm);
            panel2.Controls.Add(lblLivrosEmprestadosAdm);
            panel2.Controls.Add(lblSuspenderRetomarLivrosAdm);
            panel2.Controls.Add(lblSuspenderRetomarClienteAdm);
            panel2.Controls.Add(lblLivrosCadastradosAdm);
            panel2.Controls.Add(lblClientesCadastradosAdm);
            panel2.Location = new Point(0, 147);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 592);
            panel2.TabIndex = 4;
            // 
            // lblDesconectarAdm
            // 
            lblDesconectarAdm.AutoSize = true;
            lblDesconectarAdm.Cursor = Cursors.Hand;
            lblDesconectarAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesconectarAdm.ForeColor = Color.White;
            lblDesconectarAdm.Location = new Point(46, 482);
            lblDesconectarAdm.Name = "lblDesconectarAdm";
            lblDesconectarAdm.Size = new Size(121, 25);
            lblDesconectarAdm.TabIndex = 16;
            lblDesconectarAdm.Text = "Desconectar";
            lblDesconectarAdm.Click += lblDesconectarAdm_Click;
            // 
            // lblLivrosEmprestadosAdm
            // 
            lblLivrosEmprestadosAdm.AutoSize = true;
            lblLivrosEmprestadosAdm.Cursor = Cursors.Hand;
            lblLivrosEmprestadosAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLivrosEmprestadosAdm.ForeColor = Color.White;
            lblLivrosEmprestadosAdm.Location = new Point(16, 211);
            lblLivrosEmprestadosAdm.Name = "lblLivrosEmprestadosAdm";
            lblLivrosEmprestadosAdm.Size = new Size(184, 25);
            lblLivrosEmprestadosAdm.TabIndex = 15;
            lblLivrosEmprestadosAdm.Text = "Livros Emprestados";
            lblLivrosEmprestadosAdm.Click += lblLivrosEmprestadosAdm_Click;
            // 
            // lblClientesCadastradosAdm
            // 
            lblClientesCadastradosAdm.AutoSize = true;
            lblClientesCadastradosAdm.Cursor = Cursors.Hand;
            lblClientesCadastradosAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientesCadastradosAdm.ForeColor = Color.White;
            lblClientesCadastradosAdm.Location = new Point(16, 54);
            lblClientesCadastradosAdm.Name = "lblClientesCadastradosAdm";
            lblClientesCadastradosAdm.Size = new Size(195, 25);
            lblClientesCadastradosAdm.TabIndex = 8;
            lblClientesCadastradosAdm.Text = "Clientes Cadastrados";
            lblClientesCadastradosAdm.Click += lblClientesCadastradosAdm_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(lblCadastroLivros_TelaAdm);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnSair_TelaAdm);
            panel1.Controls.Add(lblEstoque_TelaAdm);
            panel1.Controls.Add(lblDevolucao_TelaAdm);
            panel1.Controls.Add(lblEmprestimo_TelaAdm);
            panel1.Controls.Add(lblCadastroPessoa_TelaAdm);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblBiblioteca);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1660, 107);
            panel1.TabIndex = 3;
            // 
            // TelaAdminPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1660, 740);
            Controls.Add(pnlPrincipalAdm);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaAdminPrincipal";
            Text = "TelaAdminPrincipal";
            pnlPrincipalAdm.ResumeLayout(false);
            pnlPrincipalAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipalAdm;
        private Label lblCadastroLivros_TelaAdm;
        private PictureBox pictureBox2;
        private Button btnSair_TelaAdm;
        private Label lblEstoque_TelaAdm;
        private Label lblDevolucao_TelaAdm;
        private Label lblEmprestimo_TelaAdm;
        private Label lblCadastroCliente_TelaAdm;
        private PictureBox pictureBox1;
        private Label lblSuspenderRetomarLivrosAdm;
        private Label lblSuspenderRetomarClienteAdm;
        private Label lblLivrosCadastradosAdm;
        private Label lblBiblioteca;
        private Panel panel2;
        private Label lblClientesCadastradosAdm;
        private Panel panel1;
        private Label lblLivrosEmprestadosAdm;
        private Label label1;
        private Label lblDesconectarAdm;
        private Label lblCadastroPessoa_TelaAdm;
    }
}