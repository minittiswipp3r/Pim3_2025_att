namespace Pim3_2025.TelasDeBibliotecario
{
    partial class UcLivros_Emprestados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcLivros_Emprestados));
            pictureBox1 = new PictureBox();
            lblCadaCliente = new Label();
            dtgrLivrosEmprestados = new DataGridView();
            IDLIvro = new DataGridViewTextBoxColumn();
            TituloLivro = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            DataPrestar = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgrLivrosEmprestados).BeginInit();
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
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // lblCadaCliente
            // 
            lblCadaCliente.AutoSize = true;
            lblCadaCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadaCliente.Location = new Point(161, 68);
            lblCadaCliente.Name = "lblCadaCliente";
            lblCadaCliente.Size = new Size(251, 30);
            lblCadaCliente.TabIndex = 44;
            lblCadaCliente.Text = "LIVROS EMPRESTADOS";
            // 
            // dtgrLivrosEmprestados
            // 
            dtgrLivrosEmprestados.AllowUserToAddRows = false;
            dtgrLivrosEmprestados.AllowUserToDeleteRows = false;
            dtgrLivrosEmprestados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrLivrosEmprestados.Columns.AddRange(new DataGridViewColumn[] { IDLIvro, TituloLivro, Autor, Categoria, DataPrestar, Column1 });
            dtgrLivrosEmprestados.Location = new Point(84, 131);
            dtgrLivrosEmprestados.Margin = new Padding(3, 2, 3, 2);
            dtgrLivrosEmprestados.Name = "dtgrLivrosEmprestados";
            dtgrLivrosEmprestados.RowHeadersWidth = 51;
            dtgrLivrosEmprestados.Size = new Size(1148, 416);
            dtgrLivrosEmprestados.TabIndex = 46;
            // 
            // IDLIvro
            // 
            IDLIvro.HeaderText = "ID Livro";
            IDLIvro.MinimumWidth = 6;
            IDLIvro.Name = "IDLIvro";
            IDLIvro.ReadOnly = true;
            IDLIvro.Width = 70;
            // 
            // TituloLivro
            // 
            TituloLivro.HeaderText = "Título do Livro";
            TituloLivro.MinimumWidth = 6;
            TituloLivro.Name = "TituloLivro";
            TituloLivro.ReadOnly = true;
            TituloLivro.Width = 270;
            // 
            // Autor
            // 
            Autor.HeaderText = "Nome Cliente";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Width = 270;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "ID Cliente";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 170;
            // 
            // DataPrestar
            // 
            DataPrestar.HeaderText = "Data de Empréstimo";
            DataPrestar.MinimumWidth = 6;
            DataPrestar.Name = "DataPrestar";
            DataPrestar.ReadOnly = true;
            DataPrestar.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Data Prevista de Devolução";
            Column1.Name = "Column1";
            // 
            // UcLivros_Emprestados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgrLivrosEmprestados);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadaCliente);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcLivros_Emprestados";
            Size = new Size(1342, 559);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgrLivrosEmprestados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCadaCliente;
        private DataGridView dtgrLivrosEmprestados;
        private DataGridViewTextBoxColumn IDLIvro;
        private DataGridViewTextBoxColumn TituloLivro;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn DataPrestar;
        private DataGridViewTextBoxColumn Column1;
    }
}
