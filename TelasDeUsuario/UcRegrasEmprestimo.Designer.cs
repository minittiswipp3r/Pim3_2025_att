namespace Pim3_2025.TelasDeUsuario
{
    partial class UcRegrasEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcRegrasEmprestimo));
            pictureBox1 = new PictureBox();
            lblRegrasEmprestimo = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // lblRegrasEmprestimo
            // 
            lblRegrasEmprestimo.AutoSize = true;
            lblRegrasEmprestimo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRegrasEmprestimo.Location = new Point(171, 68);
            lblRegrasEmprestimo.Name = "lblRegrasEmprestimo";
            lblRegrasEmprestimo.Size = new Size(246, 30);
            lblRegrasEmprestimo.TabIndex = 51;
            lblRegrasEmprestimo.Text = "Regras de Empréstimo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 122);
            label1.Name = "label1";
            label1.Size = new Size(919, 360);
            label1.TabIndex = 53;
            label1.Text = resources.GetString("label1.Text");
            // 
            // UcRegrasEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblRegrasEmprestimo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcRegrasEmprestimo";
            Size = new Size(1342, 559);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblRegrasEmprestimo;
        private Label label1;
    }
}
