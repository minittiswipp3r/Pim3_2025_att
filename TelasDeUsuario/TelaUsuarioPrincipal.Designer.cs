namespace Pim3_2025.TelasDeUsuario
{
    partial class TelaUsuarioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaUsuarioPrincipal));
            pnlPrincipalUsuario = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btnSairUser = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            lbl = new Label();
            label10 = new Label();
            panel2 = new Panel();
            lblRegrasUser = new Label();
            lblHistoricoEmprestimoUser = new Label();
            lblDadosPessoalUser = new Label();
            lblDesconectar = new Label();
            label11 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            lblNotificasoesUser = new Label();
            lblFaqUser = new Label();
            lblLivrosFamososUser = new Label();
            lblTelaBuscaUser = new Label();
            pnlPrincipalUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipalUsuario
            // 
            pnlPrincipalUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipalUsuario.BackColor = SystemColors.Menu;
            pnlPrincipalUsuario.Controls.Add(label1);
            pnlPrincipalUsuario.Location = new Point(275, 180);
            pnlPrincipalUsuario.Margin = new Padding(3, 2, 3, 2);
            pnlPrincipalUsuario.Name = "pnlPrincipalUsuario";
            pnlPrincipalUsuario.Size = new Size(1342, 559);
            pnlPrincipalUsuario.TabIndex = 5;
            pnlPrincipalUsuario.Paint += pnlPrincipalUsuario_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 120);
            label1.Name = "label1";
            label1.Size = new Size(780, 336);
            label1.TabIndex = 1;
            label1.Text = "     Bem Vindo\r\n            ao\r\nBiblioteca de Povo";
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
            // btnSairUser
            // 
            btnSairUser.BackColor = Color.Red;
            btnSairUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSairUser.ForeColor = Color.White;
            btnSairUser.Location = new Point(1365, 34);
            btnSairUser.Margin = new Padding(3, 2, 3, 2);
            btnSairUser.Name = "btnSairUser";
            btnSairUser.Size = new Size(89, 35);
            btnSairUser.TabIndex = 7;
            btnSairUser.Text = "SAIR";
            btnSairUser.UseVisualStyleBackColor = false;
            btnSairUser.Click += btnSairUser_Click;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(17, 295);
            label8.Name = "label8";
            label8.Size = new Size(170, 19);
            label8.TabIndex = 0;
            label8.Text = "Informaçoes Da Biblioteca:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(207, 16);
            lbl.Name = "lbl";
            lbl.Size = new Size(119, 75);
            lbl.TabIndex = 0;
            lbl.Text = "Biblioteca\r\n     de \r\n   Povo";
            lbl.TextAlign = ContentAlignment.MiddleLeft;
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
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(lblRegrasUser);
            panel2.Controls.Add(lblHistoricoEmprestimoUser);
            panel2.Controls.Add(lblDadosPessoalUser);
            panel2.Controls.Add(lblDesconectar);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(0, 147);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 592);
            panel2.TabIndex = 4;
            // 
            // lblRegrasUser
            // 
            lblRegrasUser.AutoSize = true;
            lblRegrasUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegrasUser.ForeColor = Color.White;
            lblRegrasUser.Location = new Point(17, 153);
            lblRegrasUser.Name = "lblRegrasUser";
            lblRegrasUser.Size = new Size(180, 21);
            lblRegrasUser.TabIndex = 15;
            lblRegrasUser.Text = "Regras de Empréstimo";
            lblRegrasUser.Click += lblRegrasUser_Click;
            // 
            // lblHistoricoEmprestimoUser
            // 
            lblHistoricoEmprestimoUser.AutoSize = true;
            lblHistoricoEmprestimoUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHistoricoEmprestimoUser.ForeColor = Color.White;
            lblHistoricoEmprestimoUser.Location = new Point(17, 90);
            lblHistoricoEmprestimoUser.Name = "lblHistoricoEmprestimoUser";
            lblHistoricoEmprestimoUser.Size = new Size(205, 21);
            lblHistoricoEmprestimoUser.TabIndex = 15;
            lblHistoricoEmprestimoUser.Text = "Histórico de Empréstimos";
            lblHistoricoEmprestimoUser.Click += lblHistoricoEmprestimoUser_Click;
            // 
            // lblDadosPessoalUser
            // 
            lblDadosPessoalUser.AutoSize = true;
            lblDadosPessoalUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDadosPessoalUser.ForeColor = Color.White;
            lblDadosPessoalUser.Location = new Point(47, 33);
            lblDadosPessoalUser.Name = "lblDadosPessoalUser";
            lblDadosPessoalUser.Size = new Size(132, 25);
            lblDadosPessoalUser.TabIndex = 12;
            lblDadosPessoalUser.Text = "Dados Pessoal";
            lblDadosPessoalUser.Click += lblDadosPessoalUser_Click;
            // 
            // lblDesconectar
            // 
            lblDesconectar.AutoSize = true;
            lblDesconectar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDesconectar.ForeColor = Color.White;
            lblDesconectar.Location = new Point(47, 207);
            lblDesconectar.Name = "lblDesconectar";
            lblDesconectar.Size = new Size(117, 25);
            lblDesconectar.TabIndex = 9;
            lblDesconectar.Text = "Desconectar";
            lblDesconectar.Click += lblDesconectar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(4, 416);
            label11.Name = "label11";
            label11.Size = new Size(202, 38);
            label11.TabIndex = 1;
            label11.Text = "E-mail:\r\nsuporte@bibliotecadepovo.com";
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
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(lblNotificasoesUser);
            panel1.Controls.Add(lblFaqUser);
            panel1.Controls.Add(lblLivrosFamososUser);
            panel1.Controls.Add(lblTelaBuscaUser);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnSairUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1660, 107);
            panel1.TabIndex = 3;
            // 
            // lblNotificasoesUser
            // 
            lblNotificasoesUser.AutoSize = true;
            lblNotificasoesUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblNotificasoesUser.ForeColor = Color.White;
            lblNotificasoesUser.Location = new Point(920, 42);
            lblNotificasoesUser.Name = "lblNotificasoesUser";
            lblNotificasoesUser.Size = new Size(118, 25);
            lblNotificasoesUser.TabIndex = 15;
            lblNotificasoesUser.Text = "Notificações";
            lblNotificasoesUser.Click += lblNotificasoesUser_Click;
            // 
            // lblFaqUser
            // 
            lblFaqUser.AutoSize = true;
            lblFaqUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFaqUser.ForeColor = Color.White;
            lblFaqUser.Location = new Point(1138, 44);
            lblFaqUser.Name = "lblFaqUser";
            lblFaqUser.Size = new Size(47, 25);
            lblFaqUser.TabIndex = 11;
            lblFaqUser.Text = "FAQ";
            lblFaqUser.Click += lblFaqUser_Click;
            // 
            // lblLivrosFamososUser
            // 
            lblLivrosFamososUser.AutoSize = true;
            lblLivrosFamososUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblLivrosFamososUser.ForeColor = Color.White;
            lblLivrosFamososUser.Location = new Point(682, 40);
            lblLivrosFamososUser.Name = "lblLivrosFamososUser";
            lblLivrosFamososUser.Size = new Size(139, 25);
            lblLivrosFamososUser.TabIndex = 10;
            lblLivrosFamososUser.Text = "Livros Famosos";
            lblLivrosFamososUser.Click += lblLivrosFamososUser_Click;
            // 
            // lblTelaBuscaUser
            // 
            lblTelaBuscaUser.AutoSize = true;
            lblTelaBuscaUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTelaBuscaUser.ForeColor = Color.White;
            lblTelaBuscaUser.Location = new Point(471, 40);
            lblTelaBuscaUser.Name = "lblTelaBuscaUser";
            lblTelaBuscaUser.Size = new Size(124, 25);
            lblTelaBuscaUser.TabIndex = 8;
            lblTelaBuscaUser.Text = "Buscar Livros";
            lblTelaBuscaUser.Click += lblTelaBuscaUser_Click;
            // 
            // TelaUsuarioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1660, 740);
            Controls.Add(pnlPrincipalUsuario);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaUsuarioPrincipal";
            Text = "TelaPrincipalUsuario";
            Load += TelaUsuarioPrincipal_Load;
            pnlPrincipalUsuario.ResumeLayout(false);
            pnlPrincipalUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal_Bibliotecario;
        private PictureBox pictureBox2;
        private Button btnSairUser;
        private PictureBox pictureBox1;
        private Label label8;
        private Label lbl;
        private Label label10;
        private Panel panel2;
        private Label label9;
        private Panel panel1;
        private Label label11;
        private Label lblHistoricoEmprestimoUser;
        private Label lblDadosPessoalUser;
        private Label lblTelaBuscaUser;
        private Label lblLivrosFamososUser;
        private Label lblDesconectar;
        private Label lblFaqUser;
        private Label lblRegrasUser;
        private Label lblNotificasoesUser;
        public Panel pnlPrincipalUsuario;
        private Guna.UI2.WinForms.Guna2TextBox tbxBuscarUsuario;
        private Label label1;
        private Button button1;
    }
}