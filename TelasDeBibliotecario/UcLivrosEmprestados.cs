using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Pim3_2025.Models;

namespace Pim3_2025.TelasDeBibliotecario
{
    public partial class UcLivros_Emprestados : UserControl
    {
        public UcLivros_Emprestados()
        {
            InitializeComponent();
            CarregarDadosDataGridView();
        }

        private void CarregarDadosDataGridView()
        {
            // Limpa o DataGridView
            dtgrLivrosEmprestados.Rows.Clear();

            // Obtém todos os empréstimos ativos (não devolvidos)
            var emprestimosAtivos = BancoDados.emprestimos
                .Where(e => !e.Devolvido)
                .ToList();

            // Para cada empréstimo, busca as informações do livro e do cliente
            foreach (var emprestimo in emprestimosAtivos)
            {
                var livro = BancoDados.livrosExistentes.FirstOrDefault(l => l.Id == emprestimo.IdLivro);
                var cliente = BancoDados.usuarios.FirstOrDefault(u => u.Id == emprestimo.IdCliente);

                if (livro != null && cliente != null)
                {
                    dtgrLivrosEmprestados.Rows.Add(
                        livro.Id,
                        livro.Titulo,
                        cliente.Nome,  // Nome do cliente no lugar do autor
                        cliente.Id,    // ID do cliente
                        emprestimo.DataEmprestimo.ToShortDateString(),
                        emprestimo.DataPrevistaDevolucao.ToShortDateString()
                    );
                }
            }

            // Configurações adicionais do DataGridView
            dtgrLivrosEmprestados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrLivrosEmprestados.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            dtgrLivrosEmprestados.EnableHeadersVisualStyles = false;
            dtgrLivrosEmprestados.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
        }

        // Método para atualizar a lista quando novos empréstimos são feitos ou devolvidos
        public void AtualizarListaEmprestimos()
        {
            CarregarDadosDataGridView();
        }
    }
}