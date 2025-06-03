using System;
using System.Windows.Forms;
using System.Linq;

namespace Pim3_2025.TelasDeBibliotecario
{
    public partial class UcBibliotecaBibliotecario : UserControl
    {
        public UcBibliotecaBibliotecario()
        {
            InitializeComponent();
            CarregarDadosBiblioteca();
            AplicarEstiloLabels();
        }

        private void CarregarDadosBiblioteca()
        {
            try
            {
                // Total de clientes cadastrados (perfil Cliente = 1)
                int totalClientes = BancoDados.usuarios.Count(u => u.PerfilId == 1);
                lblClienteCadastradosTotal.Text = totalClientes.ToString();

                // Total de livros no estoque
                int totalLivros = BancoDados.livrosExistentes.Count;
                lblLivrosEstoqueTotal.Text = totalLivros.ToString();

                // Total de livros emprestados (não devolvidos)
                int totalEmprestados = BancoDados.emprestimos.Count(e => !e.Devolvido);
                lblLivrosEmprestadosTotal.Text = totalEmprestados.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados da biblioteca: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarEstiloLabels()
        {
            // Configura estilo visual para os labels de total
            var labelsTotal = new[] { lblClienteCadastradosTotal, lblLivrosEstoqueTotal, lblLivrosEmprestadosTotal };

            foreach (var label in labelsTotal)
            {
                label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                label.ForeColor = Color.DarkBlue;
                label.BackColor = Color.Lavender;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Padding = new Padding(3);
                label.AutoSize = false;
                label.Size = new Size(80, 30);
                label.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        public void AtualizarDados()
        {
            CarregarDadosBiblioteca();
        }
    }
}