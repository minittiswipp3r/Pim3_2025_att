using System;
using System.Windows.Forms;
using System.Linq;
using Pim3_2025.Models;

namespace Pim3_2025.TelasDeUsuario
{
    public partial class UcHistorecoEmprestimo : UserControl
    {
        private Usuario _usuarioLogado;

        public UcHistorecoEmprestimo(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogado = usuario;
            CarregarHistoricoEmprestimos();
        }

        private void CarregarHistoricoEmprestimos()
        {
            try
            {
                // Limpa o DataGridView
                dtgrHistoricoEmprestimo.Rows.Clear();

                // Filtra os empréstimos do usuário logado (incluindo históricos)
                var emprestimosUsuario = BancoDados.emprestimos
                    .Where(e => e.IdCliente == _usuarioLogado.Id)
                    .OrderByDescending(e => e.DataEmprestimo)
                    .ToList();

                // Para cada empréstimo, busca as informações do livro
                foreach (var emprestimo in emprestimosUsuario)
                {
                    var livro = BancoDados.livrosExistentes.FirstOrDefault(l => l.Id == emprestimo.IdLivro);
                    if (livro != null)
                    {
                        dtgrHistoricoEmprestimo.Rows.Add(
                            livro.Id,
                            livro.Titulo,
                            livro.Autor,
                            livro.Editora,
                            livro.Genero,
                            emprestimo.DataEmprestimo.ToShortDateString(),
                            emprestimo.DataDevolucao?.ToShortDateString() ?? "Em aberto"
                        );
                    }
                }

                // Configurações adicionais do DataGridView
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar histórico: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dtgrHistoricoEmprestimo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrHistoricoEmprestimo.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            dtgrHistoricoEmprestimo.EnableHeadersVisualStyles = false;
            dtgrHistoricoEmprestimo.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.LightGray;
        }

        // Método para atualizar o histórico quando necessário
        public void AtualizarHistorico()
        {
            CarregarHistoricoEmprestimos();
        }
    }
}