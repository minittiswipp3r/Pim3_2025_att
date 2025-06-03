namespace Pim3_2025.TelasDeBibliotecario
{
    partial class UcBibliotecaBibliotecario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBibliotecaBibliotecario));
            label4 = new Label();
            panel4 = new Panel();
            lblClienteCadastradosTotal = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            panel5 = new Panel();
            lblLivrosEstoqueTotal = new Label();
            pictureBox6 = new PictureBox();
            label12 = new Label();
            label13 = new Label();
            panel6 = new Panel();
            lblLivrosEmprestadosTotal = new Label();
            pictureBox7 = new PictureBox();
            label14 = new Label();
            label15 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();

            // label4
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline);
            label4.Location = new Point(164, 68);
            label4.Name = "label4";
            label4.Size = new Size(136, 30);
            label4.TabIndex = 34;
            label4.Text = "BIBLIOTECA";

            // panel4
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(lblClienteCadastradosTotal);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(106, 136);
            panel4.Size = new Size(507, 170);
            panel4.TabIndex = 30;

            // lblClienteCadastradosTotal
            lblClienteCadastradosTotal.AutoSize = true;
            lblClienteCadastradosTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblClienteCadastradosTotal.Location = new Point(172, 112);
            lblClienteCadastradosTotal.Name = "lblClienteCadastradosTotal";
            lblClienteCadastradosTotal.Size = new Size(19, 21);
            lblClienteCadastradosTotal.TabIndex = 32;
            lblClienteCadastradosTotal.Text = "0";

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label1.Location = new Point(120, 53);
            label1.Name = "label1";
            label1.Size = new Size(191, 21);
            label1.TabIndex = 31;
            label1.Text = "CLIENTES CADASTRADOS";

            // pictureBox3
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 2);
            pictureBox3.Size = new Size(93, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;

            // label5
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label5.Location = new Point(110, 112);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 28;
            label5.Text = "TOTAL:";

            // pictureBox5
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(19, 14);
            pictureBox5.Size = new Size(137, 80);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;

            // panel5
            panel5.BackColor = Color.Thistle;
            panel5.Controls.Add(lblLivrosEstoqueTotal);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(728, 136);
            panel5.Size = new Size(507, 170);
            panel5.TabIndex = 32;

            // lblLivrosEstoqueTotal
            lblLivrosEstoqueTotal.AutoSize = true;
            lblLivrosEstoqueTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLivrosEstoqueTotal.Location = new Point(172, 112);
            lblLivrosEstoqueTotal.Name = "lblLivrosEstoqueTotal";
            lblLivrosEstoqueTotal.Size = new Size(19, 21);
            lblLivrosEstoqueTotal.TabIndex = 32;
            lblLivrosEstoqueTotal.Text = "0";

            // pictureBox6
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 2);
            pictureBox6.Size = new Size(93, 72);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 30;
            pictureBox6.TabStop = false;

            // label12
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label12.Location = new Point(110, 112);
            label12.Name = "label12";
            label12.Size = new Size(56, 21);
            label12.TabIndex = 28;
            label12.Text = "TOTAL:";

            // label13
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label13.Location = new Point(110, 51);
            label13.Name = "label13";
            label13.Size = new Size(162, 21);
            label13.TabIndex = 27;
            label13.Text = "LIVROS NO ESTOQUE";

            // panel6
            panel6.BackColor = Color.Thistle;
            panel6.Controls.Add(lblLivrosEmprestadosTotal);
            panel6.Controls.Add(pictureBox7);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label15);
            panel6.Location = new Point(455, 349);
            panel6.Size = new Size(507, 170);
            panel6.TabIndex = 29;

            // lblLivrosEmprestadosTotal
            lblLivrosEmprestadosTotal.AutoSize = true;
            lblLivrosEmprestadosTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLivrosEmprestadosTotal.Location = new Point(172, 112);
            lblLivrosEmprestadosTotal.Name = "lblLivrosEmprestadosTotal";
            lblLivrosEmprestadosTotal.Size = new Size(19, 21);
            lblLivrosEmprestadosTotal.TabIndex = 31;
            lblLivrosEmprestadosTotal.Text = "0";

            // pictureBox7
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 2);
            pictureBox7.Size = new Size(93, 72);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;

            // label14
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label14.Location = new Point(110, 112);
            label14.Name = "label14";
            label14.Size = new Size(56, 21);
            label14.TabIndex = 28;
            label14.Text = "TOTAL:";

            // label15
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label15.Location = new Point(110, 51);
            label15.Name = "label15";
            label15.Size = new Size(174, 21);
            label15.TabIndex = 27;
            label15.Text = "LIVROS EMPRESTADOS";

            // UcBibliotecaBibliotecario
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(pictureBox5);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Name = "UcBibliotecaBibliotecario";
            Size = new Size(1342, 559);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel4;
        private Label lblClienteCadastradosTotal;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox5;
        private Panel panel5;
        private Label lblLivrosEstoqueTotal;
        private PictureBox pictureBox6;
        private Label label12;
        private Label label13;
        private Panel panel6;
        private Label lblLivrosEmprestadosTotal;
        private PictureBox pictureBox7;
        private Label label14;
        private Label label15;
    }
}