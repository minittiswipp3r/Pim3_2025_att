namespace Pim3_2025.TelasDeUsuario
{
    partial class UcBuscaUsuario
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBuscaUsuario));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button1 = new Button();
            label1 = new Label();
            tbxBuscarUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(622, 374);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 1;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 118);
            label1.Name = "label1";
            label1.Size = new Size(805, 86);
            label1.TabIndex = 2;
            label1.Text = "BUSQUE SEU LIVRO AQUI";
            // 
            // tbxBuscarUsuario
            // 
            tbxBuscarUsuario.AllowDrop = true;
            tbxBuscarUsuario.BorderRadius = 25;
            tbxBuscarUsuario.CustomizableEdges = customizableEdges1;
            tbxBuscarUsuario.DefaultText = "";
            tbxBuscarUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbxBuscarUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbxBuscarUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbxBuscarUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbxBuscarUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxBuscarUsuario.Font = new Font("Segoe UI", 9F);
            tbxBuscarUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxBuscarUsuario.IconLeft = (Image)resources.GetObject("tbxBuscarUsuario.IconLeft");
            tbxBuscarUsuario.Location = new Point(257, 258);
            tbxBuscarUsuario.Name = "tbxBuscarUsuario";
            tbxBuscarUsuario.PlaceholderText = "";
            tbxBuscarUsuario.SelectedText = "";
            tbxBuscarUsuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbxBuscarUsuario.Size = new Size(830, 50);
            tbxBuscarUsuario.TabIndex = 3;
            // 
            // UcBuscaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbxBuscarUsuario);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcBuscaUsuario";
            Size = new Size(1342, 559);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbxBuscarUsuario;
    }
}
