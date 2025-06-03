namespace Pim3_2025.TelasDeBibliotecario
{
    partial class UcClientesCadastrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcClientesCadastrados));
            dtgrClientesCadastrados = new DataGridView();
            pictureBox1 = new PictureBox();
            lblCadaCliente = new Label();
            IDLIvro = new DataGridViewTextBoxColumn();
            TituloLivro = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            DataPrestar = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgrClientesCadastrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgrClientesCadastrados
            // 
            dtgrClientesCadastrados.AllowUserToAddRows = false;
            dtgrClientesCadastrados.AllowUserToDeleteRows = false;
            dtgrClientesCadastrados.AllowUserToOrderColumns = true;
            dtgrClientesCadastrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrClientesCadastrados.Columns.AddRange(new DataGridViewColumn[] { IDLIvro, TituloLivro, Autor, DataPrestar, Categoria });
            dtgrClientesCadastrados.Location = new Point(94, 131);
            dtgrClientesCadastrados.Margin = new Padding(3, 2, 3, 2);
            dtgrClientesCadastrados.Name = "dtgrClientesCadastrados";
            dtgrClientesCadastrados.RowHeadersWidth = 51;
            dtgrClientesCadastrados.Size = new Size(1148, 416);
            dtgrClientesCadastrados.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // lblCadaCliente
            // 
            lblCadaCliente.AutoSize = true;
            lblCadaCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadaCliente.Location = new Point(160, 68);
            lblCadaCliente.Name = "lblCadaCliente";
            lblCadaCliente.Size = new Size(276, 30);
            lblCadaCliente.TabIndex = 47;
            lblCadaCliente.Text = "CLIENTES CADASTRADOS";
            // 
            // IDLIvro
            // 
            IDLIvro.HeaderText = "ID Cliente";
            IDLIvro.MinimumWidth = 6;
            IDLIvro.Name = "IDLIvro";
            IDLIvro.ReadOnly = true;
            IDLIvro.Width = 70;
            // 
            // TituloLivro
            // 
            TituloLivro.HeaderText = "Nome Cliente";
            TituloLivro.MinimumWidth = 6;
            TituloLivro.Name = "TituloLivro";
            TituloLivro.ReadOnly = true;
            TituloLivro.Width = 260;
            // 
            // Autor
            // 
            Autor.HeaderText = "CPF";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Width = 200;
            // 
            // DataPrestar
            // 
            DataPrestar.HeaderText = "Telefone";
            DataPrestar.MinimumWidth = 6;
            DataPrestar.Name = "DataPrestar";
            DataPrestar.ReadOnly = true;
            DataPrestar.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Login";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 170;
            // 
            // UcClientesCadastrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgrClientesCadastrados);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadaCliente);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcClientesCadastrados";
            Size = new Size(1342, 559);
            ((System.ComponentModel.ISupportInitialize)dtgrClientesCadastrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgrClientesCadastrados;
        private PictureBox pictureBox1;
        private Label lblCadaCliente;
        private DataGridViewTextBoxColumn IDLIvro;
        private DataGridViewTextBoxColumn TituloLivro;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn DataPrestar;
        private DataGridViewTextBoxColumn Categoria;
    }
}
