using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Pim3_2025.Models;
using System.Drawing;

namespace Pim3_2025.TelasDeBibliotecario
{
    public partial class UcEstoqueBibliotecario : UserControl
    {
        public UcEstoqueBibliotecario()
        {
            InitializeComponent();
            CarregarEstoque();
        }

        private void CarregarEstoque()
        {
            try
            {
                // Limpa o DataGridView
                dtgrdEstoque_Bibliotecario.Rows.Clear();

                // Ordena os livros por título
                var livrosOrdenados = BancoDados.livrosExistentes
                    .OrderBy(l => l.Titulo)
                    .ToList();

                // Adiciona cada livro ao DataGridView
                foreach (var livro in livrosOrdenados)
                {
                    // Verifica se o livro está emprestado
                    bool estaEmprestado = BancoDados.emprestimos
                        .Any(e => e.IdLivro == livro.Id && !e.Devolvido);

                    // Atualiza o status do livro no objeto
                    livro.Status = estaEmprestado ? "Emprestado" : "Disponível";

                    // Adiciona a linha com todas as colunas, incluindo o Status
                    dtgrdEstoque_Bibliotecario.Rows.Add(
                        livro.Id,
                        livro.Titulo,
                        livro.Autor,
                        livro.Genero,
                        livro.Editora,
                        livro.AnoPublicacao,
                        livro.Status
                    );
                }

                // Configurações adicionais do DataGridView
                ConfigurarDataGridView();
                AplicarFormatacaoStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar estoque: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dtgrdEstoque_Bibliotecario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrdEstoque_Bibliotecario.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
            dtgrdEstoque_Bibliotecario.EnableHeadersVisualStyles = false;
            dtgrdEstoque_Bibliotecario.ColumnHeadersDefaultCellStyle.BackColor =
                Color.LightGray;

            // Configuração específica para a coluna de ano
            dtgrdEstoque_Bibliotecario.Columns["AnoPublicacao"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Configuração específica para a coluna de status
            dtgrdEstoque_Bibliotecario.Columns["StatusLivro"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        private void AplicarFormatacaoStatus()
        {
            foreach (DataGridViewRow row in dtgrdEstoque_Bibliotecario.Rows)
            {
                if (row.Cells["StatusLivro"].Value != null)
                {
                    string status = row.Cells["StatusLivro"].Value.ToString();

                    if (status == "Emprestado")
                    {
                        row.Cells["StatusLivro"].Style.BackColor = Color.LightCoral;
                        row.Cells["StatusLivro"].Style.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        row.Cells["StatusLivro"].Style.BackColor = Color.LightGreen;
                        row.Cells["StatusLivro"].Style.ForeColor = Color.DarkGreen;
                    }

                    row.Cells["StatusLivro"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }

        // Método para atualizar a lista quando novos livros são adicionados
        public void AtualizarEstoque()
        {
            CarregarEstoque();
        }
    }
}