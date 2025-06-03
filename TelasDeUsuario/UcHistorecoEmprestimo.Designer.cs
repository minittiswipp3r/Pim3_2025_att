namespace Pim3_2025.TelasDeUsuario
{
    partial class UcHistorecoEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcHistorecoEmprestimo));
            pictureBox1 = new PictureBox();
            lblHistoricoEmprestimo = new Label();
            dtgrHistoricoEmprestimo = new DataGridView();
            IDLIvro = new DataGridViewTextBoxColumn();
            TituloLivro = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            DataPrestar = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgrHistoricoEmprestimo).BeginInit();
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
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // lblHistoricoEmprestimo
            // 
            lblHistoricoEmprestimo.AutoSize = true;
            lblHistoricoEmprestimo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHistoricoEmprestimo.Location = new Point(161, 68);
            lblHistoricoEmprestimo.Name = "lblHistoricoEmprestimo";
            lblHistoricoEmprestimo.Size = new Size(280, 30);
            lblHistoricoEmprestimo.TabIndex = 46;
            lblHistoricoEmprestimo.Text = "Histórico de Empréstimos";
            // 
            // dtgrHistoricoEmprestimo
            // 
            dtgrHistoricoEmprestimo.AccessibleRole = AccessibleRole.None;
            dtgrHistoricoEmprestimo.AllowUserToAddRows = false;
            dtgrHistoricoEmprestimo.AllowUserToDeleteRows = false;
            dtgrHistoricoEmprestimo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrHistoricoEmprestimo.Columns.AddRange(new DataGridViewColumn[] { IDLIvro, TituloLivro, Column1, Column2, Autor, DataPrestar, Categoria });
            dtgrHistoricoEmprestimo.Location = new Point(93, 130);
            dtgrHistoricoEmprestimo.Margin = new Padding(3, 2, 3, 2);
            dtgrHistoricoEmprestimo.Name = "dtgrHistoricoEmprestimo";
            dtgrHistoricoEmprestimo.RowHeadersWidth = 51;
            dtgrHistoricoEmprestimo.Size = new Size(1148, 416);
            dtgrHistoricoEmprestimo.TabIndex = 48;
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
            TituloLivro.HeaderText = "Titulo de Livro";
            TituloLivro.MinimumWidth = 6;
            TituloLivro.Name = "TituloLivro";
            TituloLivro.ReadOnly = true;
            TituloLivro.Width = 270;
            // 
            // Column1
            // 
            Column1.HeaderText = "Autor";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 175;
            // 
            // Column2
            // 
            Column2.HeaderText = "Editora";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 120;
            // 
            // Autor
            // 
            Autor.HeaderText = "Genêro";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Width = 120;
            // 
            // DataPrestar
            // 
            DataPrestar.HeaderText = "Data de Empréstimo";
            DataPrestar.MinimumWidth = 6;
            DataPrestar.Name = "DataPrestar";
            DataPrestar.ReadOnly = true;
            DataPrestar.Width = 160;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Data de Devolução";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 160;
            // 
            // UcHistorecoEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgrHistoricoEmprestimo);
            Controls.Add(pictureBox1);
            Controls.Add(lblHistoricoEmprestimo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcHistorecoEmprestimo";
            Size = new Size(1342, 559);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgrHistoricoEmprestimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHistoricoEmprestimo;
        private DataGridView dtgrHistoricoEmprestimo;
        private DataGridViewTextBoxColumn IDLIvro;
        private DataGridViewTextBoxColumn TituloLivro;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn DataPrestar;
        private DataGridViewTextBoxColumn Categoria;
    }
}
