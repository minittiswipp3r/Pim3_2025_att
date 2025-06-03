using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Pim3_2025.Models;
using System.Drawing;

namespace Pim3_2025.TelasDeUsuario
{
    public partial class UcResultadoBuscaLivro : UserControl
    {
        public UcResultadoBuscaLivro(List<Livro> livrosEncontrados)
        {
            InitializeComponent();
            CarregarResultados(livrosEncontrados);
        }

        private void CarregarResultados(List<Livro> livrosEncontrados)
        {
            try
            {
                dtgrHistoricoEmprestimo.Rows.Clear();

                foreach (var livro in livrosEncontrados)
                {
                    // Verifica se o livro está emprestado
                    bool estaEmprestado = BancoDados.emprestimos
                        .Any(e => e.IdLivro == livro.Id && !e.Devolvido);

                    dtgrHistoricoEmprestimo.Rows.Add(
                        livro.Id,
                        livro.Titulo,
                        livro.Autor,
                        livro.Editora,
                        livro.Genero,
                        estaEmprestado ? "Emprestado" : "Disponível"
                    );
                }

                ConfigurarDataGridView();
                AplicarFormatacaoStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar resultados: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dtgrHistoricoEmprestimo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrHistoricoEmprestimo.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
            dtgrHistoricoEmprestimo.EnableHeadersVisualStyles = false;
            dtgrHistoricoEmprestimo.ColumnHeadersDefaultCellStyle.BackColor =
                Color.LightGray;

            // Configuração específica para a coluna de status
            dtgrHistoricoEmprestimo.Columns["Desponivel"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        private void AplicarFormatacaoStatus()
        {
            foreach (DataGridViewRow row in dtgrHistoricoEmprestimo.Rows)
            {
                if (row.Cells["Desponivel"].Value != null)
                {
                    string status = row.Cells["Desponivel"].Value.ToString();

                    if (status == "Emprestado")
                    {
                        row.Cells["Desponivel"].Style.BackColor = Color.LightCoral;
                        row.Cells["Desponivel"].Style.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        row.Cells["Desponivel"].Style.BackColor = Color.LightGreen;
                        row.Cells["Desponivel"].Style.ForeColor = Color.DarkGreen;
                    }

                    row.Cells["Desponivel"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }
    }
}