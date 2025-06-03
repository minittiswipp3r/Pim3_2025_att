using System;
using System.Windows.Forms;
using System.Linq;
using Pim3_2025.Models;

namespace Pim3_2025.TelasDeUsuario
{
    public partial class UcBuscaUsuario : UserControl
    {
        public UcBuscaUsuario()
        {
            InitializeComponent();
            button1.Click += ButtonBuscar_Click;
            tbxBuscarUsuario.KeyPress += TbxBuscarUsuario_KeyPress;
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            BuscarLivros();
        }

        private void TbxBuscarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarLivros();
            }
        }

        private void BuscarLivros()
        {
            string termoBusca = tbxBuscarUsuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(termoBusca))
            {
                MessageBox.Show("Por favor, digite um termo para busca.", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultados = BancoDados.livrosExistentes
                .Where(l => l.Titulo.Contains(termoBusca, StringComparison.OrdinalIgnoreCase) ||
                           l.Autor.Contains(termoBusca, StringComparison.OrdinalIgnoreCase) ||
                           l.Genero.Contains(termoBusca, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (resultados.Any())
            {
                var parent = this.Parent as Panel;
                if (parent != null)
                {
                    parent.Controls.Clear();
                    parent.Controls.Add(new UcResultadoBuscaLivro(resultados));
                }
            }
            else
            {
                MessageBox.Show("Nenhum livro encontrado com o termo buscado.", "Informação",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}