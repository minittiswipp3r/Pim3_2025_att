using System;
using System.Windows.Forms;
using System.Linq;
using Pim3_2025.Models;

namespace Pim3_2025.TelasDeBibliotecario
{
    public partial class UcEmprestado : UserControl
    {
        public UcEmprestado()
        {
            InitializeComponent();            
            ConfigurarDatasPadrao();
        }      

        private void ConfigurarDatasPadrao()
        {
            dttmDataEmprestimo_LivroEmprestado.Value = DateTime.Today;
            dttmdataPrevistaDevolver_LivroEmprestado.Value = DateTime.Today.AddDays(15);
        }

        private void BuscarClientePorId(object sender, EventArgs e)
        {
            if (int.TryParse(txbIDClienteEmprestado.Text, out int idCliente))
            {
                var cliente = BancoDados.usuarios
                    .FirstOrDefault(u => u.Id == idCliente && u.PerfilId == 1);

                if (cliente != null)
                {
                    txbNomeCliente_LivroEmprestado.Text = cliente.Nome;

                    // Verificar suspensão
                    if (cliente.EstaSuspenso(dttmDataEmprestimo_LivroEmprestado.Value))
                    {
                        MessageBox.Show($"Cliente suspenso até {cliente.DataSuspensao.Value.ToShortDateString()}",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    txbNomeCliente_LivroEmprestado.Clear();
                    MessageBox.Show("Cliente não encontrado!", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BuscarLivroPorId(object sender, EventArgs e)
        {
            if (int.TryParse(txbIDLivro_LivroEmprestado.Text, out int idLivro))
            {
                var livro = BancoDados.livrosExistentes.FirstOrDefault(l => l.Id == idLivro);

                if (livro != null)
                {
                    txbTitulolivro_LivroEmprestado.Text = livro.Titulo;

                    if (livro.Status != "Disponível")
                    {
                        MessageBox.Show($"Livro está {livro.Status.ToLower()}!", "Aviso",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    txbTitulolivro_LivroEmprestado.Clear();
                    MessageBox.Show("Livro não encontrado!", "Aviso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void VerificarDados(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Dados válidos para empréstimo!", "Sucesso",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txbCodFuncionario_LivroEmprestado.Text))
            {
                MessageBox.Show("Código do funcionário é obrigatório!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txbIDClienteEmprestado.Text, out int idCliente) ||
                !BancoDados.usuarios.Any(u => u.Id == idCliente))
            {
                MessageBox.Show("Cliente inválido!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar se cliente está suspenso
            if (!BancoDados.ClientePodeEmprestar(idCliente, dttmDataEmprestimo_LivroEmprestado.Value))
            {
                var cliente = BancoDados.usuarios.First(u => u.Id == idCliente);
                MessageBox.Show($"Cliente suspenso até {cliente.DataSuspensao.Value.ToShortDateString()}. Não pode realizar empréstimos.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txbIDLivro_LivroEmprestado.Text, out int idLivro))
            {
                MessageBox.Show("ID do livro inválido!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var livro = BancoDados.livrosExistentes.FirstOrDefault(l => l.Id == idLivro);
            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (livro.Status != "Disponível")
            {
                MessageBox.Show($"Livro está {livro.Status.ToLower()}!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dttmdataPrevistaDevolver_LivroEmprestado.Value <= DateTime.Today)
            {
                MessageBox.Show("Data de devolução deve ser futura!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void EmprestarLivro(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                int idLivro = int.Parse(txbIDLivro_LivroEmprestado.Text);
                int idCliente = int.Parse(txbIDClienteEmprestado.Text);
                string codFuncionario = txbCodFuncionario_LivroEmprestado.Text.Trim();

                var livro = BancoDados.livrosExistentes.First(l => l.Id == idLivro);
                var cliente = BancoDados.usuarios.First(u => u.Id == idCliente);

                var emprestimo = new Emprestimo
                {
                    Id = BancoDados.ProximoIdEmprestimo(),
                    IdLivro = livro.Id,
                    IdCliente = cliente.Id,
                    CodigoFuncionario = codFuncionario,
                    DataEmprestimo = dttmDataEmprestimo_LivroEmprestado.Value,
                    DataPrevistaDevolucao = dttmdataPrevistaDevolver_LivroEmprestado.Value,
                    Devolvido = false
                };

                livro.Status = "Emprestado";
                BancoDados.emprestimos.Add(emprestimo);

                MessageBox.Show($"Empréstimo realizado!\n" +
                              $"Livro: {livro.Titulo}\n" +
                              $"Cliente: {cliente.Nome}\n" +
                              $"Devolução: {emprestimo.DataPrevistaDevolucao.ToShortDateString()}",
                              "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarOperacao(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txbIDClienteEmprestado.Clear();
            txbNomeCliente_LivroEmprestado.Clear();
            txbIDLivro_LivroEmprestado.Clear();
            txbTitulolivro_LivroEmprestado.Clear();
            txbCodFuncionario_LivroEmprestado.Clear();
            ConfigurarDatasPadrao();
        }

        private void dttmDataEmprestimo_LivroEmprestado_ValueChanged(object sender, EventArgs e)
        {
            dttmdataPrevistaDevolver_LivroEmprestado.Value = dttmDataEmprestimo_LivroEmprestado.Value.AddDays(15);
        }
    }
}