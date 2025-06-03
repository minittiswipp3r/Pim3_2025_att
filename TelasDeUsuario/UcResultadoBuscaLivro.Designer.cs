namespace Pim3_2025.TelasDeUsuario
{
    partial class UcResultadoBuscaLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcResultadoBuscaLivro));
            pictureBox1 = new PictureBox();
            lblresultadoBusca = new Label();
            dtgrHistoricoEmprestimo = new DataGridView();
            IDLIvro = new DataGridViewTextBoxColumn();
            TituloLivro = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Desponivel = new DataGridViewTextBoxColumn();
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
            // lblresultadoBusca
            // 
            lblresultadoBusca.AutoSize = true;
            lblresultadoBusca.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblresultadoBusca.Location = new Point(161, 68);
            lblresultadoBusca.Name = "lblresultadoBusca";
            lblresultadoBusca.Size = new Size(213, 30);
            lblresultadoBusca.TabIndex = 46;
            lblresultadoBusca.Text = "Resultado de Busca";
            // 
            // dtgrHistoricoEmprestimo
            // 
            dtgrHistoricoEmprestimo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrHistoricoEmprestimo.Columns.AddRange(new DataGridViewColumn[] { IDLIvro, TituloLivro, Column2, Column1, Categoria, Desponivel });
            dtgrHistoricoEmprestimo.Location = new Point(94, 185);
            dtgrHistoricoEmprestimo.Margin = new Padding(3, 2, 3, 2);
            dtgrHistoricoEmprestimo.Name = "dtgrHistoricoEmprestimo";
            dtgrHistoricoEmprestimo.RowHeadersWidth = 51;
            dtgrHistoricoEmprestimo.Size = new Size(1149, 146);
            dtgrHistoricoEmprestimo.TabIndex = 49;
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
            TituloLivro.Width = 300;
            // 
            // Column2
            // 
            Column2.HeaderText = "Autor";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 175;
            // 
            // Column1
            // 
            Column1.HeaderText = "Editora";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Genêro";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 150;
            // 
            // Desponivel
            // 
            Desponivel.HeaderText = "Status";
            Desponivel.MinimumWidth = 6;
            Desponivel.Name = "Desponivel";
            Desponivel.ReadOnly = true;
            Desponivel.Width = 200;
            // 
            // UcResultadoBuscaLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgrHistoricoEmprestimo);
            Controls.Add(pictureBox1);
            Controls.Add(lblresultadoBusca);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcResultadoBuscaLivro";
            Size = new Size(1342, 559);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgrHistoricoEmprestimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblresultadoBusca;
        private DataGridView dtgrHistoricoEmprestimo;
        private DataGridViewTextBoxColumn IDLIvro;
        private DataGridViewTextBoxColumn TituloLivro;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Desponivel;
    }
}
