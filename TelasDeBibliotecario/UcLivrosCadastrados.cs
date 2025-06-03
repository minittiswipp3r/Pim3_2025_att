using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Pim3_2025.Models;

namespace Pim3_2025.TelasDeBibliotecario
{
    public partial class UcLivrosCadastrados : UserControl
    {
        // Lista que combina livros mockados e cadastrados
        private List<Livro> listaLivrosCompleta;

        public UcLivrosCadastrados(List<Livro> livrosCadastrados)
        {
            InitializeComponent();

            // Combina os livros mockados com os cadastrados
            this.listaLivrosCompleta = new List<Livro>(BancoDados.livrosExistentes);
            
            CarregarDadosDataGridView();
        }

        private void CarregarDadosDataGridView()
        {
            // Limpa o DataGridView
            dtgrdEstoque_Bibliotecario.Rows.Clear();

            // Adiciona cada livro ao DataGridView
            int id = 1;
            foreach (var livro in listaLivrosCompleta)
            {
                dtgrdEstoque_Bibliotecario.Rows.Add(
                    id++,
                    livro.Titulo,
                    livro.Autor,
                    livro.AnoPublicacao,
                    livro.CodigoFuncionario,
                    livro.DataCadastro.ToShortDateString()
                );
            }

            // Configurações adicionais do DataGridView
            dtgrdEstoque_Bibliotecario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrdEstoque_Bibliotecario.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dtgrdEstoque_Bibliotecario.EnableHeadersVisualStyles = false;
            dtgrdEstoque_Bibliotecario.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
        }

        // Método para atualizar a lista quando novos livros são adicionados
        public void AtualizarListaLivros(List<Livro> novaLista)
        {
            this.listaLivrosCompleta = new List<Livro>(BancoDados.livrosExistentes);
            this.listaLivrosCompleta.AddRange(novaLista);
            CarregarDadosDataGridView();
        }
    }
}