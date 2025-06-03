namespace Pim3_2025.TelasDeBibliotecario
{
    partial class UcEmprestado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcEmprestado));
            pictureBox1 = new PictureBox();
            lblCadaCliente = new Label();
            btnCancelar__LivroEmprestado = new Button();
            txbVerificar_LivroEmprestado = new Button();
            btnEmprestar_LivroEmprestado = new Button();
            dttmdataPrevistaDevolver_LivroEmprestado = new DateTimePicker();
            txbIDLivro_LivroEmprestado = new TextBox();
            label7 = new Label();
            txbTitulolivro_LivroEmprestado = new TextBox();
            label8 = new Label();
            label4 = new Label();
            txbIDClienteEmprestado = new TextBox();
            label3 = new Label();
            txbNomeCliente_LivroEmprestado = new TextBox();
            label2 = new Label();
            txbCodFuncionario_LivroEmprestado = new TextBox();
            label1 = new Label();
            dttmDataEmprestimo_LivroEmprestado = new DateTimePicker();
            label5 = new Label();
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
            // lblCadaCliente
            // 
            lblCadaCliente.AutoSize = true;
            lblCadaCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadaCliente.Location = new Point(161, 68);
            lblCadaCliente.Name = "lblCadaCliente";
            lblCadaCliente.Size = new Size(208, 30);
            lblCadaCliente.TabIndex = 42;
            lblCadaCliente.Text = "EMPRESTAR LIVRO";
            // 
            // btnCancelar__LivroEmprestado
            // 
            btnCancelar__LivroEmprestado.BackColor = Color.Red;
            btnCancelar__LivroEmprestado.Location = new Point(956, 470);
            btnCancelar__LivroEmprestado.Margin = new Padding(3, 2, 3, 2);
            btnCancelar__LivroEmprestado.Name = "btnCancelar__LivroEmprestado";
            btnCancelar__LivroEmprestado.Size = new Size(132, 37);
            btnCancelar__LivroEmprestado.TabIndex = 41;
            btnCancelar__LivroEmprestado.Text = "CANCELAR";
            btnCancelar__LivroEmprestado.UseVisualStyleBackColor = false;
            btnCancelar__LivroEmprestado.Click += CancelarOperacao;
            // 
            // txbVerificar_LivroEmprestado
            // 
            txbVerificar_LivroEmprestado.BackColor = Color.Gray;
            txbVerificar_LivroEmprestado.Location = new Point(738, 470);
            txbVerificar_LivroEmprestado.Margin = new Padding(3, 2, 3, 2);
            txbVerificar_LivroEmprestado.Name = "txbVerificar_LivroEmprestado";
            txbVerificar_LivroEmprestado.Size = new Size(132, 37);
            txbVerificar_LivroEmprestado.TabIndex = 40;
            txbVerificar_LivroEmprestado.Text = "VERIFICAR";
            txbVerificar_LivroEmprestado.UseVisualStyleBackColor = false;
            txbVerificar_LivroEmprestado.Click += VerificarDados;
            // 
            // btnEmprestar_LivroEmprestado
            // 
            btnEmprestar_LivroEmprestado.BackColor = Color.Green;
            btnEmprestar_LivroEmprestado.Location = new Point(514, 470);
            btnEmprestar_LivroEmprestado.Margin = new Padding(3, 2, 3, 2);
            btnEmprestar_LivroEmprestado.Name = "btnEmprestar_LivroEmprestado";
            btnEmprestar_LivroEmprestado.Size = new Size(132, 37);
            btnEmprestar_LivroEmprestado.TabIndex = 39;
            btnEmprestar_LivroEmprestado.Text = "EMPRESTAR";
            btnEmprestar_LivroEmprestado.UseVisualStyleBackColor = false;
            btnEmprestar_LivroEmprestado.Click += EmprestarLivro;
            // 
            // dttmdataPrevistaDevolver_LivroEmprestado
            // 
            dttmdataPrevistaDevolver_LivroEmprestado.Location = new Point(725, 382);
            dttmdataPrevistaDevolver_LivroEmprestado.Margin = new Padding(3, 2, 3, 2);
            dttmdataPrevistaDevolver_LivroEmprestado.Name = "dttmdataPrevistaDevolver_LivroEmprestado";
            dttmdataPrevistaDevolver_LivroEmprestado.Size = new Size(336, 23);
            dttmdataPrevistaDevolver_LivroEmprestado.TabIndex = 38;
            // 
            // txbIDLivro_LivroEmprestado
            // 
            txbIDLivro_LivroEmprestado.Location = new Point(597, 292);
            txbIDLivro_LivroEmprestado.Margin = new Padding(3, 2, 3, 2);
            txbIDLivro_LivroEmprestado.Name = "txbIDLivro_LivroEmprestado";
            txbIDLivro_LivroEmprestado.Size = new Size(283, 23);
            txbIDLivro_LivroEmprestado.TabIndex = 37;
            txbIDLivro_LivroEmprestado.TextChanged += BuscarLivroPorId;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(597, 261);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 36;
            label7.Text = "ID DO LIVRO";
            // 
            // txbTitulolivro_LivroEmprestado
            // 
            txbTitulolivro_LivroEmprestado.Location = new Point(254, 292);
            txbTitulolivro_LivroEmprestado.Margin = new Padding(3, 2, 3, 2);
            txbTitulolivro_LivroEmprestado.Name = "txbTitulolivro_LivroEmprestado";
            txbTitulolivro_LivroEmprestado.Size = new Size(279, 23);
            txbTitulolivro_LivroEmprestado.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(254, 261);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 34;
            label8.Text = "TÍTULO DO LIVRO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(725, 354);
            label4.Name = "label4";
            label4.Size = new Size(177, 15);
            label4.TabIndex = 33;
            label4.Text = "DATA PREVISTA PARA DEVOLVER";
            // 
            // txbIDClienteEmprestado
            // 
            txbIDClienteEmprestado.Location = new Point(802, 183);
            txbIDClienteEmprestado.Margin = new Padding(3, 2, 3, 2);
            txbIDClienteEmprestado.Name = "txbIDClienteEmprestado";
            txbIDClienteEmprestado.Size = new Size(274, 23);
            txbIDClienteEmprestado.TabIndex = 28;
            txbIDClienteEmprestado.TextChanged += BuscarClientePorId;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(802, 152);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 27;
            label3.Text = "ID DO CLIENTE";
            // 
            // txbNomeCliente_LivroEmprestado
            // 
            txbNomeCliente_LivroEmprestado.Location = new Point(395, 183);
            txbNomeCliente_LivroEmprestado.Margin = new Padding(3, 2, 3, 2);
            txbNomeCliente_LivroEmprestado.Name = "txbNomeCliente_LivroEmprestado";
            txbNomeCliente_LivroEmprestado.Size = new Size(283, 23);
            txbNomeCliente_LivroEmprestado.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 152);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 25;
            label2.Text = "NOME DO CLIENTE";
            // 
            // txbCodFuncionario_LivroEmprestado
            // 
            txbCodFuncionario_LivroEmprestado.Location = new Point(52, 183);
            txbCodFuncionario_LivroEmprestado.Margin = new Padding(3, 2, 3, 2);
            txbCodFuncionario_LivroEmprestado.Name = "txbCodFuncionario_LivroEmprestado";
            txbCodFuncionario_LivroEmprestado.Size = new Size(279, 23);
            txbCodFuncionario_LivroEmprestado.TabIndex = 24;
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
            // dttmDataEmprestimo_LivroEmprestado
            // 
            dttmDataEmprestimo_LivroEmprestado.Location = new Point(122, 382);
            dttmDataEmprestimo_LivroEmprestado.Margin = new Padding(3, 2, 3, 2);
            dttmDataEmprestimo_LivroEmprestado.Name = "dttmDataEmprestimo_LivroEmprestado";
            dttmDataEmprestimo_LivroEmprestado.Size = new Size(336, 23);
            dttmDataEmprestimo_LivroEmprestado.TabIndex = 45;
            dttmDataEmprestimo_LivroEmprestado.ValueChanged += dttmDataEmprestimo_LivroEmprestado_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 354);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 44;
            label5.Text = "DATA DE EMPRESTIMO";
            // 
            // UcEmprestado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dttmDataEmprestimo_LivroEmprestado);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadaCliente);
            Controls.Add(btnCancelar__LivroEmprestado);
            Controls.Add(txbVerificar_LivroEmprestado);
            Controls.Add(btnEmprestar_LivroEmprestado);
            Controls.Add(dttmdataPrevistaDevolver_LivroEmprestado);
            Controls.Add(txbIDLivro_LivroEmprestado);
            Controls.Add(label7);
            Controls.Add(txbTitulolivro_LivroEmprestado);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txbIDClienteEmprestado);
            Controls.Add(label3);
            Controls.Add(txbNomeCliente_LivroEmprestado);
            Controls.Add(label2);
            Controls.Add(txbCodFuncionario_LivroEmprestado);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcEmprestado";
            Size = new Size(1342, 559);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCadaCliente;
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
        private TextBox txbIDClienteEmprestado;
        private TextBox txbNomeCliente_LivroEmprestado;
        private TextBox txbCodFuncionario_LivroEmprestado;
        private TextBox txbIDLivro_LivroEmprestado;
        private TextBox txbTitulolivro_LivroEmprestado;
        private DateTimePicker dttmDataEmprestimo_LivroEmprestado;
        private Button btnCancelar__LivroEmprestado;
        private Button txbVerificar_LivroEmprestado;
        private Button btnEmprestar_LivroEmprestado;
        private DateTimePicker dttmdataPrevistaDevolver_LivroEmprestado;
    }
}
