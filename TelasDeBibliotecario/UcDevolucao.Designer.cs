namespace Pim3_2025.TelasDeBibliotecario
{
    partial class UcDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDevolucao));
            pictureBox1 = new PictureBox();
            lblCadaCliente = new Label();
            btnCancelar_DevolucaoLivro = new Button();
            btnVerificar_DevolucaoLivro = new Button();
            btnDevoluir_DevolucaoLivro = new Button();
            dttmDataDevolucao_DevolucaoLivro = new DateTimePicker();
            txbIDLivro_DevolucaoLivro = new TextBox();
            label7 = new Label();
            txbTituloLivro_DevolucaoLivro = new TextBox();
            label8 = new Label();
            label4 = new Label();
            txbIDCliente_DevolucaoLivro = new TextBox();
            label3 = new Label();
            txbNomeCliente_DevolucaoLivro = new TextBox();
            label2 = new Label();
            txbCodFuncionario_DevolucaoLivro = new TextBox();
            label1 = new Label();
            lblStatusSuspensao = new Label();
            txbStatusSuspensao = new TextBox();
            label5 = new Label();
            txbDataPrevistaDevolucao = new TextBox();
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
            lblCadaCliente.Size = new Size(216, 30);
            lblCadaCliente.TabIndex = 42;
            lblCadaCliente.Text = "DEVOLUÇÃO LIVRO";
            // 
            // btnCancelar_DevolucaoLivro
            // 
            btnCancelar_DevolucaoLivro.BackColor = Color.Red;
            btnCancelar_DevolucaoLivro.Location = new Point(956, 470);
            btnCancelar_DevolucaoLivro.Margin = new Padding(3, 2, 3, 2);
            btnCancelar_DevolucaoLivro.Name = "btnCancelar_DevolucaoLivro";
            btnCancelar_DevolucaoLivro.Size = new Size(132, 37);
            btnCancelar_DevolucaoLivro.TabIndex = 41;
            btnCancelar_DevolucaoLivro.Text = "CANCELAR";
            btnCancelar_DevolucaoLivro.UseVisualStyleBackColor = false;
            btnCancelar_DevolucaoLivro.Click += btnCancelar_DevolucaoLivro_Click;
            // 
            // btnVerificar_DevolucaoLivro
            // 
            btnVerificar_DevolucaoLivro.BackColor = Color.Gray;
            btnVerificar_DevolucaoLivro.Location = new Point(738, 470);
            btnVerificar_DevolucaoLivro.Margin = new Padding(3, 2, 3, 2);
            btnVerificar_DevolucaoLivro.Name = "btnVerificar_DevolucaoLivro";
            btnVerificar_DevolucaoLivro.Size = new Size(132, 37);
            btnVerificar_DevolucaoLivro.TabIndex = 40;
            btnVerificar_DevolucaoLivro.Text = "VERIFICAR";
            btnVerificar_DevolucaoLivro.UseVisualStyleBackColor = false;
            btnVerificar_DevolucaoLivro.Click += btnVerificar_DevolucaoLivro_Click;
            // 
            // btnDevoluir_DevolucaoLivro
            // 
            btnDevoluir_DevolucaoLivro.BackColor = Color.Green;
            btnDevoluir_DevolucaoLivro.Location = new Point(514, 470);
            btnDevoluir_DevolucaoLivro.Margin = new Padding(3, 2, 3, 2);
            btnDevoluir_DevolucaoLivro.Name = "btnDevoluir_DevolucaoLivro";
            btnDevoluir_DevolucaoLivro.Size = new Size(132, 37);
            btnDevoluir_DevolucaoLivro.TabIndex = 39;
            btnDevoluir_DevolucaoLivro.Text = "DEVOLVER";
            btnDevoluir_DevolucaoLivro.UseVisualStyleBackColor = false;
            btnDevoluir_DevolucaoLivro.Click += btnDevoluir_DevolucaoLivro_Click;
            // 
            // dttmDataDevolucao_DevolucaoLivro
            // 
            dttmDataDevolucao_DevolucaoLivro.Location = new Point(617, 382);
            dttmDataDevolucao_DevolucaoLivro.Margin = new Padding(3, 2, 3, 2);
            dttmDataDevolucao_DevolucaoLivro.Name = "dttmDataDevolucao_DevolucaoLivro";
            dttmDataDevolucao_DevolucaoLivro.Size = new Size(296, 23);
            dttmDataDevolucao_DevolucaoLivro.TabIndex = 38;
            // 
            // txbIDLivro_DevolucaoLivro
            // 
            txbIDLivro_DevolucaoLivro.Location = new Point(617, 292);
            txbIDLivro_DevolucaoLivro.Margin = new Padding(3, 2, 3, 2);
            txbIDLivro_DevolucaoLivro.Name = "txbIDLivro_DevolucaoLivro";
            txbIDLivro_DevolucaoLivro.Size = new Size(283, 23);
            txbIDLivro_DevolucaoLivro.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(617, 261);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 36;
            label7.Text = "ID DO LIVRO";
            // 
            // txbTituloLivro_DevolucaoLivro
            // 
            txbTituloLivro_DevolucaoLivro.Location = new Point(211, 292);
            txbTituloLivro_DevolucaoLivro.Margin = new Padding(3, 2, 3, 2);
            txbTituloLivro_DevolucaoLivro.Name = "txbTituloLivro_DevolucaoLivro";
            txbTituloLivro_DevolucaoLivro.ReadOnly = true;
            txbTituloLivro_DevolucaoLivro.Size = new Size(279, 23);
            txbTituloLivro_DevolucaoLivro.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(211, 261);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 34;
            label8.Text = "TÍTULO DO LIVRO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(623, 351);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 33;
            label4.Text = "DATA DA DEVOLUÇÃO";
            // 
            // txbIDCliente_DevolucaoLivro
            // 
            txbIDCliente_DevolucaoLivro.Location = new Point(802, 183);
            txbIDCliente_DevolucaoLivro.Margin = new Padding(3, 2, 3, 2);
            txbIDCliente_DevolucaoLivro.Name = "txbIDCliente_DevolucaoLivro";
            txbIDCliente_DevolucaoLivro.Size = new Size(274, 23);
            txbIDCliente_DevolucaoLivro.TabIndex = 28;
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
            // txbNomeCliente_DevolucaoLivro
            // 
            txbNomeCliente_DevolucaoLivro.Location = new Point(395, 183);
            txbNomeCliente_DevolucaoLivro.Margin = new Padding(3, 2, 3, 2);
            txbNomeCliente_DevolucaoLivro.Name = "txbNomeCliente_DevolucaoLivro";
            txbNomeCliente_DevolucaoLivro.ReadOnly = true;
            txbNomeCliente_DevolucaoLivro.Size = new Size(283, 23);
            txbNomeCliente_DevolucaoLivro.TabIndex = 26;
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
            // txbCodFuncionario_DevolucaoLivro
            // 
            txbCodFuncionario_DevolucaoLivro.Location = new Point(52, 183);
            txbCodFuncionario_DevolucaoLivro.Margin = new Padding(3, 2, 3, 2);
            txbCodFuncionario_DevolucaoLivro.Name = "txbCodFuncionario_DevolucaoLivro";
            txbCodFuncionario_DevolucaoLivro.Size = new Size(279, 23);
            txbCodFuncionario_DevolucaoLivro.TabIndex = 24;
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
            // lblStatusSuspensao
            // 
            lblStatusSuspensao.AutoSize = true;
            lblStatusSuspensao.Location = new Point(211, 351);
            lblStatusSuspensao.Name = "lblStatusSuspensao";
            lblStatusSuspensao.Size = new Size(113, 15);
            lblStatusSuspensao.TabIndex = 44;
            lblStatusSuspensao.Text = "STATUS SUSPENSÃO";
            // 
            // txbStatusSuspensao
            // 
            txbStatusSuspensao.Location = new Point(211, 382);
            txbStatusSuspensao.Margin = new Padding(3, 2, 3, 2);
            txbStatusSuspensao.Name = "txbStatusSuspensao";
            txbStatusSuspensao.ReadOnly = true;
            txbStatusSuspensao.Size = new Size(279, 23);
            txbStatusSuspensao.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(617, 351);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 47;
            // 
            // txbDataPrevistaDevolucao
            // 
            txbDataPrevistaDevolucao.Location = new Point(1332, 0);
            txbDataPrevistaDevolucao.Margin = new Padding(3, 2, 3, 2);
            txbDataPrevistaDevolucao.Name = "txbDataPrevistaDevolucao";
            txbDataPrevistaDevolucao.ReadOnly = true;
            txbDataPrevistaDevolucao.Size = new Size(10, 23);
            txbDataPrevistaDevolucao.TabIndex = 46;
            // 
            // UcDevolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label5);
            Controls.Add(txbDataPrevistaDevolucao);
            Controls.Add(txbStatusSuspensao);
            Controls.Add(lblStatusSuspensao);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadaCliente);
            Controls.Add(btnCancelar_DevolucaoLivro);
            Controls.Add(btnVerificar_DevolucaoLivro);
            Controls.Add(btnDevoluir_DevolucaoLivro);
            Controls.Add(dttmDataDevolucao_DevolucaoLivro);
            Controls.Add(txbIDLivro_DevolucaoLivro);
            Controls.Add(label7);
            Controls.Add(txbTituloLivro_DevolucaoLivro);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txbIDCliente_DevolucaoLivro);
            Controls.Add(label3);
            Controls.Add(txbNomeCliente_DevolucaoLivro);
            Controls.Add(label2);
            Controls.Add(txbCodFuncionario_DevolucaoLivro);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcDevolucao";
            Size = new Size(1342, 559);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCadaCliente;
        private Button btnCancelar_DevolucaoLivro;
        private Button btnVerificar_DevolucaoLivro;
        private Button btnDevoluir_DevolucaoLivro;
        private DateTimePicker dttmDataDevolucao_DevolucaoLivro;
        private TextBox txbIDLivro_DevolucaoLivro;
        private Label label7;
        private TextBox txbTituloLivro_DevolucaoLivro;
        private Label label8;
        private Label label4;
        private TextBox txbIDCliente_DevolucaoLivro;
        private Label label3;
        private TextBox txbNomeCliente_DevolucaoLivro;
        private Label label2;
        private TextBox txbCodFuncionario_DevolucaoLivro;
        private Label label1;
        private Label lblStatusSuspensao;
        private TextBox txbStatusSuspensao;
        private Label label5;
        private TextBox txbDataPrevistaDevolucao;
    }
}