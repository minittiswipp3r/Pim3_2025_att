using System;
using System.Windows.Forms;
using Pim3_2025.Models;

namespace Pim3_2025.TelasDeBibliotecario
{
    public partial class UcCadastrarLivros : UserControl
    {
        public UcCadastrarLivros()
        {
            InitializeComponent();           
            ConfigurarDataPadrao();
        }        

        private void ValidarApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ConfigurarDataPadrao()
        {
            dttmDataCadastro_CadastroCliente.Value = DateTime.Today;
            dttmDataCadastro_CadastroCliente.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                if (!int.TryParse(txbIsban_CadastroLivro.Text, out int anoPublicacao))
                {
                    MessageBox.Show("Ano de publicação inválido!", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Livro novoLivro = new Livro
                {
                    Id = BancoDados.ProximoIdLivro(),
                    CodigoFuncionario = txbCodFuncionario_CadastroLivro.Text.Trim(),
                    Titulo = txbTituloLivro_CadastroLivro.Text.Trim(),
                    AnoPublicacao = anoPublicacao,
                    Autor = txbNomeAutor_CadastroLivro.Text.Trim(),
                    Genero = txbCategoria_CadastroLivro.Text.Trim(),
                    Editora = txbPrateleira_CadastroLivro.Text.Trim(),
                    Status = "Disponível",
                    DataCadastro = DateTime.Now
                };

                BancoDados.livrosExistentes.Add(novoLivro);

                MessageBox.Show($"Livro cadastrado com sucesso!\nID: {novoLivro.Id}", "Sucesso",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar livro: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txbCodFuncionario_CadastroLivro.Text) ||
                string.IsNullOrWhiteSpace(txbTituloLivro_CadastroLivro.Text) ||
                string.IsNullOrWhiteSpace(txbIsban_CadastroLivro.Text) ||
                string.IsNullOrWhiteSpace(txbNomeAutor_CadastroLivro.Text) ||
                string.IsNullOrWhiteSpace(txbCategoria_CadastroLivro.Text) ||
                string.IsNullOrWhiteSpace(txbPrateleira_CadastroLivro.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txbIsban_CadastroLivro.Text.Length != 4)
            {
                MessageBox.Show("Ano deve conter 4 dígitos!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var parentForm = this.ParentForm;
            parentForm?.Close();
        }

        private void LimparCampos()
        {
            txbCodFuncionario_CadastroLivro.Clear();
            txbTituloLivro_CadastroLivro.Clear();
            txbIsban_CadastroLivro.Clear();
            txbNomeAutor_CadastroLivro.Clear();
            txbCategoria_CadastroLivro.Clear();
            txbPrateleira_CadastroLivro.Clear();
            txbLocalizacao_CadastroLivro.Clear();
            dttmDataCadastro_CadastroCliente.Value = DateTime.Today;
            txbCodFuncionario_CadastroLivro.Focus();
        }
    }
}