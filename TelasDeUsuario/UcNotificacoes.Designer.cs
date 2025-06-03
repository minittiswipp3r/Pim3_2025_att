namespace Pim3_2025.TelasDeUsuario
{
    partial class UcNotificacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcNotificacoes));
            pictureBox1 = new PictureBox();
            lblCadaCliente = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // lblCadaCliente
            // 
            lblCadaCliente.AutoSize = true;
            lblCadaCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadaCliente.Location = new Point(193, 88);
            lblCadaCliente.Name = "lblCadaCliente";
            lblCadaCliente.Size = new Size(357, 38);
            lblCadaCliente.TabIndex = 51;
            lblCadaCliente.Text = "Notificaçoes da Biblioteca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 162);
            label1.Name = "label1";
            label1.Size = new Size(1099, 350);
            label1.TabIndex = 53;
            label1.Text = resources.GetString("label1.Text");
            // 
            // UcNotificacoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadaCliente);
            Name = "UcNotificacoes";
            Size = new Size(1534, 745);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCadaCliente;
        private Label label1;
    }
}
