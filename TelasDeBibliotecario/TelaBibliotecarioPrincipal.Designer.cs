namespace Pim3_2025.TelasDeBibliotecario
{
    partial class TelaBibliotecarioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBibliotecarioPrincipal));
            panel1 = new Panel();
            lblCadastroLivros_TelaBibliotecario = new Label();
            pictureBox2 = new PictureBox();
            btnSair_TelaBibliotecario = new Button();
            lblEstoque_TelaBibliotecario = new Label();
            lblDevolucao_TelaBibliotecario = new Label();
            lblEmprestimo_TelaBibliotecario = new Label();
            lblCadastroCliente_TelaBibliotecario = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            lblDesconectarBibliotecario = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            lblSuspenderRetomarCliente = new Label();
            lblLivrosCadastrados = new Label();
            lblClientesCadastrados = new Label();
            pnlPrincipal_Bibliotecario = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            pnlPrincipal_Bibliotecario.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(lblCadastroLivros_TelaBibliotecario);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnSair_TelaBibliotecario);
            panel1.Controls.Add(lblEstoque_TelaBibliotecario);
            panel1.Controls.Add(lblDevolucao_TelaBibliotecario);
            panel1.Controls.Add(lblEmprestimo_TelaBibliotecario);
            panel1.Controls.Add(lblCadastroCliente_TelaBibliotecario);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1660, 107);
            panel1.TabIndex = 0;
            // 
            // lblCadastroLivros_TelaBibliotecario
            // 
            lblCadastroLivros_TelaBibliotecario.AutoSize = true;
            lblCadastroLivros_TelaBibliotecario.Cursor = Cursors.Hand;
            lblCadastroLivros_TelaBibliotecario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCadastroLivros_TelaBibliotecario.ForeColor = Color.White;
            lblCadastroLivros_TelaBibliotecario.Location = new Point(646, 44);
            lblCadastroLivros_TelaBibliotecario.Name = "lblCadastroLivros_TelaBibliotecario";
            lblCadastroLivros_TelaBibliotecario.Size = new Size(168, 25);
            lblCadastroLivros_TelaBibliotecario.TabIndex = 8;
            lblCadastroLivros_TelaBibliotecario.Text = "Cadastro de Livro";
            lblCadastroLivros_TelaBibliotecario.Click += lblCadastroLivros_TelaBibliotecario_Click;
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
            // btnSair_TelaBibliotecario
            // 
            btnSair_TelaBibliotecario.BackColor = Color.Red;
            btnSair_TelaBibliotecario.Cursor = Cursors.Hand;
            btnSair_TelaBibliotecario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair_TelaBibliotecario.ForeColor = Color.White;
            btnSair_TelaBibliotecario.Location = new Point(1364, 34);
            btnSair_TelaBibliotecario.Margin = new Padding(3, 2, 3, 2);
            btnSair_TelaBibliotecario.Name = "btnSair_TelaBibliotecario";
            btnSair_TelaBibliotecario.Size = new Size(89, 35);
            btnSair_TelaBibliotecario.TabIndex = 7;
            btnSair_TelaBibliotecario.Text = "SAIR";
            btnSair_TelaBibliotecario.UseVisualStyleBackColor = false;
            btnSair_TelaBibliotecario.Click += btnSair_TelaBibliotecario_Click;
            // 
            // lblEstoque_TelaBibliotecario
            // 
            lblEstoque_TelaBibliotecario.AutoSize = true;
            lblEstoque_TelaBibliotecario.Cursor = Cursors.Hand;
            lblEstoque_TelaBibliotecario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEstoque_TelaBibliotecario.ForeColor = Color.White;
            lblEstoque_TelaBibliotecario.Location = new Point(1217, 44);
            lblEstoque_TelaBibliotecario.Name = "lblEstoque_TelaBibliotecario";
            lblEstoque_TelaBibliotecario.Size = new Size(83, 25);
            lblEstoque_TelaBibliotecario.TabIndex = 6;
            lblEstoque_TelaBibliotecario.Text = "Estoque";
            lblEstoque_TelaBibliotecario.Click += lblEstoque_TelaBibliotecario_Click;
            // 
            // lblDevolucao_TelaBibliotecario
            // 
            lblDevolucao_TelaBibliotecario.AutoSize = true;
            lblDevolucao_TelaBibliotecario.Cursor = Cursors.Hand;
            lblDevolucao_TelaBibliotecario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblDevolucao_TelaBibliotecario.ForeColor = Color.White;
            lblDevolucao_TelaBibliotecario.Location = new Point(1042, 44);
            lblDevolucao_TelaBibliotecario.Name = "lblDevolucao_TelaBibliotecario";
            lblDevolucao_TelaBibliotecario.Size = new Size(106, 25);
            lblDevolucao_TelaBibliotecario.TabIndex = 4;
            lblDevolucao_TelaBibliotecario.Text = "Devolução";
            lblDevolucao_TelaBibliotecario.Click += lblDevolucao_TelaBibliotecario_Click;
            // 
            // lblEmprestimo_TelaBibliotecario
            // 
            lblEmprestimo_TelaBibliotecario.AutoSize = true;
            lblEmprestimo_TelaBibliotecario.Cursor = Cursors.Hand;
            lblEmprestimo_TelaBibliotecario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEmprestimo_TelaBibliotecario.ForeColor = Color.White;
            lblEmprestimo_TelaBibliotecario.Location = new Point(853, 44);
            lblEmprestimo_TelaBibliotecario.Name = "lblEmprestimo_TelaBibliotecario";
            lblEmprestimo_TelaBibliotecario.Size = new Size(118, 25);
            lblEmprestimo_TelaBibliotecario.TabIndex = 3;
            lblEmprestimo_TelaBibliotecario.Text = "Empréstimo";
            lblEmprestimo_TelaBibliotecario.Click += lblEmprestimo_TelaBibliotecario_Click;
            // 
            // lblCadastroCliente_TelaBibliotecario
            // 
            lblCadastroCliente_TelaBibliotecario.AutoSize = true;
            lblCadastroCliente_TelaBibliotecario.Cursor = Cursors.Hand;
            lblCadastroCliente_TelaBibliotecario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCadastroCliente_TelaBibliotecario.ForeColor = Color.White;
            lblCadastroCliente_TelaBibliotecario.Location = new Point(422, 44);
            lblCadastroCliente_TelaBibliotecario.Name = "lblCadastroCliente_TelaBibliotecario";
            lblCadastroCliente_TelaBibliotecario.Size = new Size(184, 25);
            lblCadastroCliente_TelaBibliotecario.TabIndex = 1;
            lblCadastroCliente_TelaBibliotecario.Text = "Cadastro de Cliente";
            lblCadastroCliente_TelaBibliotecario.Click += lblCadastroCliente_TelaBibliotecario_Click;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(207, 14);
            label1.Name = "label1";
            label1.Size = new Size(127, 81);
            label1.TabIndex = 0;
            label1.Text = "Biblioteca\r\n     do \r\n   Povo";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(lblDesconectarBibliotecario);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblSuspenderRetomarCliente);
            panel2.Controls.Add(lblLivrosCadastrados);
            panel2.Controls.Add(lblClientesCadastrados);
            panel2.Location = new Point(0, 147);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 592);
            panel2.TabIndex = 1;
            // 
            // lblDesconectarBibliotecario
            // 
            lblDesconectarBibliotecario.AutoSize = true;
            lblDesconectarBibliotecario.Cursor = Cursors.Hand;
            lblDesconectarBibliotecario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblDesconectarBibliotecario.ForeColor = Color.White;
            lblDesconectarBibliotecario.Location = new Point(10, 220);
            lblDesconectarBibliotecario.Name = "lblDesconectarBibliotecario";
            lblDesconectarBibliotecario.Size = new Size(121, 25);
            lblDesconectarBibliotecario.TabIndex = 11;
            lblDesconectarBibliotecario.Text = "Desconectar";
            lblDesconectarBibliotecario.Click += lblDesconectarBibliotecario_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(4, 410);
            label11.Name = "label11";
            label11.Size = new Size(202, 38);
            label11.TabIndex = 0;
            label11.Text = "E-mail:\r\nsuporte@bibliotecadepovo.com";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(4, 478);
            label10.Name = "label10";
            label10.Size = new Size(202, 95);
            label10.TabIndex = 0;
            label10.Text = "Endereço:\r\n    Av. das Nações Unidas,\r\n    1234 - Sala 501\r\n    Bairro Centro, São Paulo- SP,\r\n     04567-000, Brasil";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(10, 320);
            label9.Name = "label9";
            label9.Size = new Size(133, 76);
            label9.TabIndex = 0;
            label9.Text = "Telefone:\r\n    (11)123-456-789\r\n    (11)987-654-321\r\n    (11)159-753-852";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(17, 295);
            label8.Name = "label8";
            label8.Size = new Size(170, 19);
            label8.TabIndex = 0;
            label8.Text = "Informaçoes Da Biblioteca:";
            // 
            // lblSuspenderRetomarCliente
            // 
            lblSuspenderRetomarCliente.AutoSize = true;
            lblSuspenderRetomarCliente.Cursor = Cursors.Hand;
            lblSuspenderRetomarCliente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblSuspenderRetomarCliente.ForeColor = Color.White;
            lblSuspenderRetomarCliente.Location = new Point(8, 160);
            lblSuspenderRetomarCliente.Name = "lblSuspenderRetomarCliente";
            lblSuspenderRetomarCliente.Size = new Size(184, 25);
            lblSuspenderRetomarCliente.TabIndex = 10;
            lblSuspenderRetomarCliente.Text = "Livros Emprestados";
            lblSuspenderRetomarCliente.Click += lblSuspenderRetomarCliente_Click;
            // 
            // lblLivrosCadastrados
            // 
            lblLivrosCadastrados.AutoSize = true;
            lblLivrosCadastrados.Cursor = Cursors.Hand;
            lblLivrosCadastrados.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblLivrosCadastrados.ForeColor = Color.White;
            lblLivrosCadastrados.Location = new Point(10, 92);
            lblLivrosCadastrados.Name = "lblLivrosCadastrados";
            lblLivrosCadastrados.Size = new Size(179, 25);
            lblLivrosCadastrados.TabIndex = 9;
            lblLivrosCadastrados.Text = "Livros Cadastrados";
            lblLivrosCadastrados.Click += lblLivrosCadastrados_Click;
            // 
            // lblClientesCadastrados
            // 
            lblClientesCadastrados.AutoSize = true;
            lblClientesCadastrados.Cursor = Cursors.Hand;
            lblClientesCadastrados.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientesCadastrados.ForeColor = Color.White;
            lblClientesCadastrados.Location = new Point(11, 31);
            lblClientesCadastrados.Name = "lblClientesCadastrados";
            lblClientesCadastrados.Size = new Size(195, 25);
            lblClientesCadastrados.TabIndex = 8;
            lblClientesCadastrados.Text = "Clientes Cadastrados";
            lblClientesCadastrados.Click += lblClientesCadastrados_Click;
            // 
            // pnlPrincipal_Bibliotecario
            // 
            pnlPrincipal_Bibliotecario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal_Bibliotecario.BackColor = SystemColors.Menu;
            pnlPrincipal_Bibliotecario.Controls.Add(label2);
            pnlPrincipal_Bibliotecario.Location = new Point(275, 180);
            pnlPrincipal_Bibliotecario.Margin = new Padding(3, 2, 3, 2);
            pnlPrincipal_Bibliotecario.Name = "pnlPrincipal_Bibliotecario";
            pnlPrincipal_Bibliotecario.Size = new Size(1342, 559);
            pnlPrincipal_Bibliotecario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("High Tower Text", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 120);
            label2.Name = "label2";
            label2.Size = new Size(780, 336);
            label2.TabIndex = 2;
            label2.Text = "     Bem Vindo\r\n            ao\r\nBiblioteca de Povo";
            // 
            // TelaBibliotecarioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Thistle;
            ClientSize = new Size(1660, 740);
            Controls.Add(pnlPrincipal_Bibliotecario);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaBibliotecarioPrincipal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlPrincipal_Bibliotecario.ResumeLayout(false);
            pnlPrincipal_Bibliotecario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlPrincipal_Bibliotecario;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblEstoque_TelaBibliotecario;
        private Label label6;
        private Label lblDevolucao_TelaBibliotecario;
        private Label lblEmprestimo_TelaBibliotecario;
        private Label label3;
        private Label lblCadastroCliente_TelaBibliotecario;
        private Button btnSair_TelaBibliotecario;
        private Label lblSuspenderRetomarCliente;
        private Label lblLivrosCadastrados;
        private Label lblClientesCadastrados;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label11;
        private PictureBox pictureBox2;
        private Label lblCadastroLivros_TelaBibliotecario;
        private Label label2;
        private Label lblDesconectarBibliotecario;
        private Label label4;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label lblTotalCliente_UcBiblioteca;
        private Label label5;
        private PictureBox pictureBox5;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Label lblTotalLivros_UcBiblioteca;
        private Label label7;
        private Panel panel5;
        private PictureBox pictureBox6;
        private Label lblTotalEstoque_UcBiblioteca;
        private Label label12;
        private Label label13;
        private Panel panel6;
        private PictureBox pictureBox7;
        private Label lblTotalEmprestados;
        private Label label14;
        private Label label15;
    }
}