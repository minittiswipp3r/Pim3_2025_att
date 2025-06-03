namespace Pim3_2025.TelasDeBibliotecario
{
    partial class UcCadastraraCliente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCadastraraCliente));
            txbCodFuncionario_CadastroCliente = new TextBox();
            label2 = new Label();
            txbNomeCliente_CadastroCliente = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txbConfSenha_CadastroCliente = new TextBox();
            label5 = new Label();
            txbSenha_CadastroCliente = new TextBox();
            label6 = new Label();
            txbTelefone_CadastroCliente = new TextBox();
            label7 = new Label();
            txbEmail_CadastroCliente = new TextBox();
            label8 = new Label();
            dttmDataCadastro_CadastroCliente = new DateTimePicker();
            btnCadastrar_CadastroCliente = new Button();
            txbLempar_CadastroCliente = new Button();
            btnCancelar_CadastroCliente = new Button();
            lblCadaCliente = new Label();
            pictureBox1 = new PictureBox();
            txbCpf_CadastroCliente = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txbCodFuncionario_CadastroCliente
            // 
            txbCodFuncionario_CadastroCliente.Location = new Point(61, 183);
            txbCodFuncionario_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            txbCodFuncionario_CadastroCliente.Name = "txbCodFuncionario_CadastroCliente";
            txbCodFuncionario_CadastroCliente.Size = new Size(283, 23);
            txbCodFuncionario_CadastroCliente.TabIndex = 3;
            txbCodFuncionario_CadastroCliente.KeyPress += ValidarApenasNumeros;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 152);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 2;
            label2.Text = "*CÓDIGO DO FUNCIONÁRIO";
            // 
            // txbNomeCliente_CadastroCliente
            // 
            txbNomeCliente_CadastroCliente.Location = new Point(453, 183);
            txbNomeCliente_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            txbNomeCliente_CadastroCliente.Name = "txbNomeCliente_CadastroCliente";
            txbNomeCliente_CadastroCliente.Size = new Size(274, 23);
            txbNomeCliente_CadastroCliente.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 152);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 4;
            label3.Text = "NOME DO CLIENTE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(811, 352);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 10;
            label4.Text = "DATA DE CADASTRO";
            // 
            // txbConfSenha_CadastroCliente
            // 
            txbConfSenha_CadastroCliente.Location = new Point(404, 382);
            txbConfSenha_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            txbConfSenha_CadastroCliente.Name = "txbConfSenha_CadastroCliente";
            txbConfSenha_CadastroCliente.PasswordChar = '*';
            txbConfSenha_CadastroCliente.Size = new Size(283, 23);
            txbConfSenha_CadastroCliente.TabIndex = 9;
            txbConfSenha_CadastroCliente.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 352);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 8;
            label5.Text = "CONFIRME A SENHA";
            // 
            // txbSenha_CadastroCliente
            // 
            txbSenha_CadastroCliente.Location = new Point(61, 382);
            txbSenha_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            txbSenha_CadastroCliente.Name = "txbSenha_CadastroCliente";
            txbSenha_CadastroCliente.PasswordChar = '*';
            txbSenha_CadastroCliente.Size = new Size(279, 23);
            txbSenha_CadastroCliente.TabIndex = 7;
            txbSenha_CadastroCliente.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 352);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 6;
            label6.Text = "SENHA";
            // 
            // txbTelefone_CadastroCliente
            // 
            txbTelefone_CadastroCliente.Location = new Point(597, 292);
            txbTelefone_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            txbTelefone_CadastroCliente.Name = "txbTelefone_CadastroCliente";
            txbTelefone_CadastroCliente.Size = new Size(283, 23);
            txbTelefone_CadastroCliente.TabIndex = 15;
            txbTelefone_CadastroCliente.KeyPress += ValidarTelefone;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(597, 261);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 14;
            label7.Text = "TELEFONE";
            // 
            // txbEmail_CadastroCliente
            // 
            txbEmail_CadastroCliente.Location = new Point(254, 292);
            txbEmail_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            txbEmail_CadastroCliente.Name = "txbEmail_CadastroCliente";
            txbEmail_CadastroCliente.Size = new Size(279, 23);
            txbEmail_CadastroCliente.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(254, 261);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 12;
            label8.Text = "E-MAIL";
            // 
            // dttmDataCadastro_CadastroCliente
            // 
            dttmDataCadastro_CadastroCliente.Location = new Point(811, 382);
            dttmDataCadastro_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            dttmDataCadastro_CadastroCliente.Name = "dttmDataCadastro_CadastroCliente";
            dttmDataCadastro_CadastroCliente.Size = new Size(264, 23);
            dttmDataCadastro_CadastroCliente.TabIndex = 16;
            // 
            // btnCadastrar_CadastroCliente
            // 
            btnCadastrar_CadastroCliente.BackColor = Color.Green;
            btnCadastrar_CadastroCliente.Location = new Point(514, 470);
            btnCadastrar_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar_CadastroCliente.Name = "btnCadastrar_CadastroCliente";
            btnCadastrar_CadastroCliente.Size = new Size(132, 37);
            btnCadastrar_CadastroCliente.TabIndex = 17;
            btnCadastrar_CadastroCliente.Text = "CADASTRAR";
            btnCadastrar_CadastroCliente.UseVisualStyleBackColor = false;
            btnCadastrar_CadastroCliente.Click += btnCadastrar_Click;
            // 
            // txbLempar_CadastroCliente
            // 
            txbLempar_CadastroCliente.BackColor = Color.Gray;
            txbLempar_CadastroCliente.Location = new Point(738, 470);
            txbLempar_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            txbLempar_CadastroCliente.Name = "txbLempar_CadastroCliente";
            txbLempar_CadastroCliente.Size = new Size(132, 37);
            txbLempar_CadastroCliente.TabIndex = 18;
            txbLempar_CadastroCliente.Text = "LIMPAR";
            txbLempar_CadastroCliente.UseVisualStyleBackColor = false;
            txbLempar_CadastroCliente.Click += btnLimpar_Click;
            // 
            // btnCancelar_CadastroCliente
            // 
            btnCancelar_CadastroCliente.BackColor = Color.Red;
            btnCancelar_CadastroCliente.Location = new Point(956, 470);
            btnCancelar_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            btnCancelar_CadastroCliente.Name = "btnCancelar_CadastroCliente";
            btnCancelar_CadastroCliente.Size = new Size(132, 37);
            btnCancelar_CadastroCliente.TabIndex = 19;
            btnCancelar_CadastroCliente.Text = "CANCELAR";
            btnCancelar_CadastroCliente.UseVisualStyleBackColor = false;
            btnCancelar_CadastroCliente.Click += btnCancelar_Click;
            // 
            // lblCadaCliente
            // 
            lblCadaCliente.AutoSize = true;
            lblCadaCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadaCliente.Location = new Point(161, 68);
            lblCadaCliente.Name = "lblCadaCliente";
            lblCadaCliente.Size = new Size(233, 30);
            lblCadaCliente.TabIndex = 21;
            lblCadaCliente.Text = "CADASTRAR CLIENTE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // txbCpf_CadastroCliente
            // 
            txbCpf_CadastroCliente.Location = new Point(814, 183);
            txbCpf_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            txbCpf_CadastroCliente.MaxLength = 11;
            txbCpf_CadastroCliente.Name = "txbCpf_CadastroCliente";
            txbCpf_CadastroCliente.Size = new Size(274, 23);
            txbCpf_CadastroCliente.TabIndex = 25;
            txbCpf_CadastroCliente.KeyPress += ValidarCPF;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(817, 152);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 24;
            label1.Text = "CPF";
            // 
            // UcCadastraraCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            Controls.Add(txbCpf_CadastroCliente);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadaCliente);
            Controls.Add(btnCancelar_CadastroCliente);
            Controls.Add(txbLempar_CadastroCliente);
            Controls.Add(btnCadastrar_CadastroCliente);
            Controls.Add(dttmDataCadastro_CadastroCliente);
            Controls.Add(txbTelefone_CadastroCliente);
            Controls.Add(label7);
            Controls.Add(txbEmail_CadastroCliente);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txbConfSenha_CadastroCliente);
            Controls.Add(label5);
            Controls.Add(txbSenha_CadastroCliente);
            Controls.Add(label6);
            Controls.Add(txbNomeCliente_CadastroCliente);
            Controls.Add(label3);
            Controls.Add(txbCodFuncionario_CadastroCliente);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcCadastraraCliente";
            Size = new Size(1342, 559);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbCpf_CadastroCliente;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblCadaCliente;
        private TextBox txbCodFuncionario_CadastroCliente;
        private TextBox txbNomeCliente_CadastroCliente;
        private TextBox txbConfSenha_CadastroCliente;
        private TextBox txbSenha_CadastroCliente;
        private TextBox txbTelefone_CadastroCliente;
        private TextBox txbEmail_CadastroCliente;
        private DateTimePicker dttmDataCadastro_CadastroCliente;
        private Button btnCadastrar_CadastroCliente;
        private Button txbLempar_CadastroCliente;
        private Button btnCancelar_CadastroCliente;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
