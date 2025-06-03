namespace Pim3_2025
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblNaoTenhoCadastro = new Label();
            lblClickaAquiLogin = new Label();
            btnLogin = new Button();
            txbUsuarioLogin = new TextBox();
            txbSenhaLogin = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.Thistle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-125, 33);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(970, 838);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(950, 236);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(950, 312);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "SENHA";
            // 
            // lblNaoTenhoCadastro
            // 
            lblNaoTenhoCadastro.AutoSize = true;
            lblNaoTenhoCadastro.ForeColor = Color.DarkViolet;
            lblNaoTenhoCadastro.Location = new Point(950, 399);
            lblNaoTenhoCadastro.Name = "lblNaoTenhoCadastro";
            lblNaoTenhoCadastro.Size = new Size(141, 15);
            lblNaoTenhoCadastro.TabIndex = 3;
            lblNaoTenhoCadastro.Text = "NÃO TENHO CADASTRO!";
            // 
            // lblClickaAquiLogin
            // 
            lblClickaAquiLogin.AutoSize = true;
            lblClickaAquiLogin.Cursor = Cursors.Hand;
            lblClickaAquiLogin.ForeColor = Color.Blue;
            lblClickaAquiLogin.Location = new Point(1116, 399);
            lblClickaAquiLogin.Name = "lblClickaAquiLogin";
            lblClickaAquiLogin.Size = new Size(78, 15);
            lblClickaAquiLogin.TabIndex = 4;
            lblClickaAquiLogin.Text = "CLIQUE AQUI";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(1034, 466);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(88, 28);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txbUsuarioLogin
            // 
            txbUsuarioLogin.Location = new Point(950, 265);
            txbUsuarioLogin.Margin = new Padding(3, 2, 3, 2);
            txbUsuarioLogin.Name = "txbUsuarioLogin";
            txbUsuarioLogin.Size = new Size(241, 23);
            txbUsuarioLogin.TabIndex = 6;
            // 
            // txbSenhaLogin
            // 
            txbSenhaLogin.Location = new Point(950, 340);
            txbSenhaLogin.Margin = new Padding(3, 2, 3, 2);
            txbSenhaLogin.Name = "txbSenhaLogin";
            txbSenhaLogin.PasswordChar = '*';
            txbSenhaLogin.Size = new Size(241, 23);
            txbSenhaLogin.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(990, 110);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1499, 612);
            Controls.Add(pictureBox2);
            Controls.Add(txbSenhaLogin);
            Controls.Add(txbUsuarioLogin);
            Controls.Add(btnLogin);
            Controls.Add(lblClickaAquiLogin);
            Controls.Add(lblNaoTenhoCadastro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lblNaoTenhoCadastro;
        private Label lblClickaAquiLogin;
        private Button btnLogin;
        private TextBox txbUsuarioLogin;
        private TextBox txbSenhaLogin;
        private PictureBox pictureBox2;
    }
}