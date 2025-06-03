namespace Pim3_2025.TelasDeBibliotecario
{
    partial class UcCadastrarLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCadastrarLivros));
            pictureBox1 = new PictureBox();
            lblCadaLivro = new Label();
            btnCancelar_CadastroLIvro = new Button();
            txbLempar_CadastroLIvro = new Button();
            btnCadastrar_CadastroLIvro = new Button();
            dttmDataCadastro_CadastroCliente = new DateTimePicker();
            txbCategoria_CadastroLivro = new TextBox();
            label7 = new Label();
            txbNomeAutor_CadastroLivro = new TextBox();
            label8 = new Label();
            label4 = new Label();
            txbLocalizacao_CadastroLivro = new TextBox();
            label5 = new Label();
            txbPrateleira_CadastroLivro = new TextBox();
            label6 = new Label();
            txbIsban_CadastroLivro = new TextBox();
            label3 = new Label();
            txbTituloLivro_CadastroLivro = new TextBox();
            label2 = new Label();
            txbCodFuncionario_CadastroLivro = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // lblCadaLivro
            // 
            lblCadaLivro.AutoSize = true;
            lblCadaLivro.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadaLivro.Location = new Point(161, 68);
            lblCadaLivro.Name = "lblCadaLivro";
            lblCadaLivro.Size = new Size(211, 30);
            lblCadaLivro.TabIndex = 42;
            lblCadaLivro.Text = "CADASTRAR LIVRO";
            // 
            // btnCancelar_CadastroLIvro
            // 
            btnCancelar_CadastroLIvro.BackColor = Color.Red;
            btnCancelar_CadastroLIvro.Location = new Point(956, 470);
            btnCancelar_CadastroLIvro.Margin = new Padding(3, 2, 3, 2);
            btnCancelar_CadastroLIvro.Name = "btnCancelar_CadastroLIvro";
            btnCancelar_CadastroLIvro.Size = new Size(132, 37);
            btnCancelar_CadastroLIvro.TabIndex = 41;
            btnCancelar_CadastroLIvro.Text = "CANCELAR";
            btnCancelar_CadastroLIvro.UseVisualStyleBackColor = false;
            btnCancelar_CadastroLIvro.Click += btnCancelar_Click;
            // 
            // txbLempar_CadastroLIvro
            // 
            txbLempar_CadastroLIvro.BackColor = Color.Gray;
            txbLempar_CadastroLIvro.Location = new Point(738, 470);
            txbLempar_CadastroLIvro.Margin = new Padding(3, 2, 3, 2);
            txbLempar_CadastroLIvro.Name = "txbLempar_CadastroLIvro";
            txbLempar_CadastroLIvro.Size = new Size(132, 37);
            txbLempar_CadastroLIvro.TabIndex = 40;
            txbLempar_CadastroLIvro.Text = "LIMPAR";
            txbLempar_CadastroLIvro.UseVisualStyleBackColor = false;
            txbLempar_CadastroLIvro.Click += btnLimpar_Click;
            // 
            // btnCadastrar_CadastroLIvro
            // 
            btnCadastrar_CadastroLIvro.BackColor = Color.Green;
            btnCadastrar_CadastroLIvro.Location = new Point(514, 470);
            btnCadastrar_CadastroLIvro.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar_CadastroLIvro.Name = "btnCadastrar_CadastroLIvro";
            btnCadastrar_CadastroLIvro.Size = new Size(132, 37);
            btnCadastrar_CadastroLIvro.TabIndex = 39;
            btnCadastrar_CadastroLIvro.Text = "CADASTRAR";
            btnCadastrar_CadastroLIvro.UseVisualStyleBackColor = false;
            btnCadastrar_CadastroLIvro.Click += btnCadastrar_Click;
            // 
            // dttmDataCadastro_CadastroCliente
            // 
            dttmDataCadastro_CadastroCliente.Location = new Point(811, 382);
            dttmDataCadastro_CadastroCliente.Margin = new Padding(3, 2, 3, 2);
            dttmDataCadastro_CadastroCliente.Name = "dttmDataCadastro_CadastroCliente";
            dttmDataCadastro_CadastroCliente.Size = new Size(264, 23);
            dttmDataCadastro_CadastroCliente.TabIndex = 38;
            // 
            // txbCategoria_CadastroLivro
            // 
            txbCategoria_CadastroLivro.Location = new Point(597, 292);
            txbCategoria_CadastroLivro.Margin = new Padding(3, 2, 3, 2);
            txbCategoria_CadastroLivro.Name = "txbCategoria_CadastroLivro";
            txbCategoria_CadastroLivro.Size = new Size(283, 23);
            txbCategoria_CadastroLivro.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(597, 261);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 36;
            label7.Text = "GENÊRO";
            // 
            // txbNomeAutor_CadastroLivro
            // 
            txbNomeAutor_CadastroLivro.Location = new Point(254, 292);
            txbNomeAutor_CadastroLivro.Margin = new Padding(3, 2, 3, 2);
            txbNomeAutor_CadastroLivro.Name = "txbNomeAutor_CadastroLivro";
            txbNomeAutor_CadastroLivro.Size = new Size(279, 23);
            txbNomeAutor_CadastroLivro.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(254, 261);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 34;
            label8.Text = "NOME DO AUTOR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(811, 352);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 33;
            label4.Text = "DATA DE CADASTRO";
            // 
            // txbLocalizacao_CadastroLivro
            // 
            txbLocalizacao_CadastroLivro.Location = new Point(404, 382);
            txbLocalizacao_CadastroLivro.Margin = new Padding(3, 2, 3, 2);
            txbLocalizacao_CadastroLivro.Name = "txbLocalizacao_CadastroLivro";
            txbLocalizacao_CadastroLivro.Size = new Size(283, 23);
            txbLocalizacao_CadastroLivro.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 352);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 31;
            label5.Text = "STATUS";
            // 
            // txbPrateleira_CadastroLivro
            // 
            txbPrateleira_CadastroLivro.Location = new Point(61, 382);
            txbPrateleira_CadastroLivro.Margin = new Padding(3, 2, 3, 2);
            txbPrateleira_CadastroLivro.Name = "txbPrateleira_CadastroLivro";
            txbPrateleira_CadastroLivro.Size = new Size(279, 23);
            txbPrateleira_CadastroLivro.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 352);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 29;
            label6.Text = "EDITORA";
            // 
            // txbIsban_CadastroLivro
            // 
            txbIsban_CadastroLivro.Location = new Point(802, 183);
            txbIsban_CadastroLivro.Margin = new Padding(3, 2, 3, 2);
            txbIsban_CadastroLivro.Name = "txbIsban_CadastroLivro";
            txbIsban_CadastroLivro.Size = new Size(274, 23);
            txbIsban_CadastroLivro.TabIndex = 28;
            txbIsban_CadastroLivro.KeyPress += ValidarApenasNumeros;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(802, 152);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 27;
            label3.Text = "ANO DE PUBLICAÇÃO";
            // 
            // txbTituloLivro_CadastroLivro
            // 
            txbTituloLivro_CadastroLivro.Location = new Point(395, 183);
            txbTituloLivro_CadastroLivro.Margin = new Padding(3, 2, 3, 2);
            txbTituloLivro_CadastroLivro.Name = "txbTituloLivro_CadastroLivro";
            txbTituloLivro_CadastroLivro.Size = new Size(283, 23);
            txbTituloLivro_CadastroLivro.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 152);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 25;
            label2.Text = "TÍTULO DO LIVRO";
            // 
            // txbCodFuncionario_CadastroLivro
            // 
            txbCodFuncionario_CadastroLivro.Location = new Point(52, 183);
            txbCodFuncionario_CadastroLivro.Margin = new Padding(3, 2, 3, 2);
            txbCodFuncionario_CadastroLivro.Name = "txbCodFuncionario_CadastroLivro";
            txbCodFuncionario_CadastroLivro.Size = new Size(279, 23);
            txbCodFuncionario_CadastroLivro.TabIndex = 24;
            txbCodFuncionario_CadastroLivro.KeyPress += ValidarApenasNumeros;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 152);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 23;
            label1.Text = "*CÓDIGO DO FUNCIONÁRIO";
            // 
            // UcCadastrarLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(lblCadaLivro);
            Controls.Add(btnCancelar_CadastroLIvro);
            Controls.Add(txbLempar_CadastroLIvro);
            Controls.Add(btnCadastrar_CadastroLIvro);
            Controls.Add(dttmDataCadastro_CadastroCliente);
            Controls.Add(txbCategoria_CadastroLivro);
            Controls.Add(label7);
            Controls.Add(txbNomeAutor_CadastroLivro);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txbLocalizacao_CadastroLivro);
            Controls.Add(label5);
            Controls.Add(txbPrateleira_CadastroLivro);
            Controls.Add(label6);
            Controls.Add(txbIsban_CadastroLivro);
            Controls.Add(label3);
            Controls.Add(txbTituloLivro_CadastroLivro);
            Controls.Add(label2);
            Controls.Add(txbCodFuncionario_CadastroLivro);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcCadastrarLivros";
            Size = new Size(1342, 559);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCadaLivro;
        private Button btnCancelar_CadastroCliente;
        private Button txbLempar_CadastroCliente;
        private Button btnCadastrar_CadastroCliente;
        private DateTimePicker dttmDataCadastro_CadastroCliente;
        private TextBox txbEmail_CadastroCliente;
        private Label label7;
        private TextBox txbCpf_CadastroCliente;
        private Label label8;
        private Label label4;
        private TextBox txbTelefone_CadastroCliente;
        private Label label5;
        private TextBox txbEndereco_CadastroCliente;
        private Label label6;
        private TextBox txbRG_CadastroCliente;
        private Label label3;
        private TextBox txbNomeCliente_CadastroCliente;
        private Label label2;
        private TextBox txbCodFuncionario_CadastroCliente;
        private Label label1;
        private Button btnCancelar_CadastroLIvros;
        private Button txbLempar_CadastroLIvros;
        private Button btnCadastrar_CadastroLIvros;
        private TextBox txbCategoria_CadastroLivro;
        private TextBox txbNomeAutor_CadastroLivro;
        private TextBox txbPrateleira_CadastroLivro;
        private TextBox txbIsban_CadastroLivro;
        private TextBox txbTituloLivro_CadastroLivro;
        private TextBox txbCodFuncionario_CadastroLivro;
        private Button btnCancelar_CadastroLIvro;
        private Button txbLempar_CadastroLIvro;
        private Button btnCadastrar_CadastroLIvro;
        private TextBox txbLocalizacao_CadastroLivro;
    }
}
