using Pim3_2025.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pim3_2025.TelasDeBibliotecario
{
    public partial class UcDevolucao : UserControl
    {
        private Emprestimo _emprestimoAtual;

        public UcDevolucao()
        {
            InitializeComponent();
            dttmDataDevolucao_DevolucaoLivro.Value = DateTime.Now;
            txbTituloLivro_DevolucaoLivro.ReadOnly = true;
            txbNomeCliente_DevolucaoLivro.ReadOnly = true;
            txbStatusSuspensao.ReadOnly = true;
            txbDataPrevistaDevolucao.ReadOnly = true;
        }

        private void btnVerificar_DevolucaoLivro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbIDCliente_DevolucaoLivro.Text) ||
                string.IsNullOrWhiteSpace(txbIDLivro_DevolucaoLivro.Text))
            {
                MessageBox.Show("Preencha o ID do Cliente e o ID do Livro para verificar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txbIDCliente_DevolucaoLivro.Text, out int clienteId) ||
                !int.TryParse(txbIDLivro_DevolucaoLivro.Text, out int livroId))
            {
                MessageBox.Show("IDs devem ser números válidos.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se o cliente existe
            var cliente = BancoDados.usuarios.FirstOrDefault(u => u.Id == clienteId);
            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txbNomeCliente_DevolucaoLivro.Text = cliente.Nome;

            // Atualizar status de suspensão
            if (cliente.EstaSuspenso(dttmDataDevolucao_DevolucaoLivro.Value))
            {
                txbStatusSuspensao.Text = $"SUSPENSO ATÉ {cliente.DataSuspensao.Value.ToShortDateString()}";
            }
            else
            {
                txbStatusSuspensao.Text = "LIBERADO";
            }

            // Verificar se o livro existe
            var livro = BancoDados.livrosExistentes.FirstOrDefault(l => l.Id == livroId);
            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txbTituloLivro_DevolucaoLivro.Text = livro.Titulo;

            // Verificar se há empréstimo ativo para este livro e cliente
            _emprestimoAtual = BancoDados.emprestimos.FirstOrDefault(emp =>
                emp.IdLivro == livroId &&
                emp.IdCliente == clienteId &&
                !emp.Devolvido);

            if (_emprestimoAtual == null)
            {
                MessageBox.Show("Não há empréstimo ativo deste livro para o cliente informado.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar data prevista de devolução
            txbDataPrevistaDevolucao.Text = _emprestimoAtual.DataPrevistaDevolucao.ToShortDateString();

            // Verificar se há atraso
            if (dttmDataDevolucao_DevolucaoLivro.Value > _emprestimoAtual.DataPrevistaDevolucao)
            {
                var diasAtraso = (dttmDataDevolucao_DevolucaoLivro.Value - _emprestimoAtual.DataPrevistaDevolucao).Days;
                MessageBox.Show($"ATENÇÃO: Livro com {diasAtraso} dias de atraso! Cliente será suspenso por 5 dias após a devolução.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("Empréstimo encontrado. Pronto para devolução.",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDevoluir_DevolucaoLivro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbIDCliente_DevolucaoLivro.Text) ||
                string.IsNullOrWhiteSpace(txbIDLivro_DevolucaoLivro.Text) ||
                string.IsNullOrWhiteSpace(txbCodFuncionario_DevolucaoLivro.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txbIDCliente_DevolucaoLivro.Text, out int clienteId) ||
                !int.TryParse(txbIDLivro_DevolucaoLivro.Text, out int livroId))
            {
                MessageBox.Show("IDs devem ser números válidos.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se há empréstimo ativo
            if (_emprestimoAtual == null)
            {
                MessageBox.Show("Não há empréstimo ativo para devolução. Verifique primeiro.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Atualizar o empréstimo
            _emprestimoAtual.DataDevolucao = dttmDataDevolucao_DevolucaoLivro.Value;
            _emprestimoAtual.Devolvido = true;

            // Atualizar o status do livro
            var livro = BancoDados.livrosExistentes.FirstOrDefault(l => l.Id == livroId);
            if (livro != null)
            {
                livro.Status = "Disponível";
            }

            // Verificar atraso e aplicar suspensão se necessário
            if (dttmDataDevolucao_DevolucaoLivro.Value > _emprestimoAtual.DataPrevistaDevolucao)
            {
                BancoDados.SuspenderCliente(clienteId, 5);
                var cliente = BancoDados.usuarios.FirstOrDefault(u => u.Id == clienteId);
                if (cliente != null)
                {
                    txbStatusSuspensao.Text = $"SUSPENSO ATÉ {cliente.DataSuspensao.Value.ToShortDateString()}";
                    MessageBox.Show($"Cliente suspenso por 5 dias devido ao atraso na devolução. Suspensão até: {cliente.DataSuspensao.Value.ToShortDateString()}",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            MessageBox.Show("Devolução realizada com sucesso!",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        private void btnCancelar_DevolucaoLivro_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txbIDCliente_DevolucaoLivro.Clear();
            txbNomeCliente_DevolucaoLivro.Clear();
            txbIDLivro_DevolucaoLivro.Clear();
            txbTituloLivro_DevolucaoLivro.Clear();
            txbStatusSuspensao.Clear();
            txbDataPrevistaDevolucao.Clear();
            dttmDataDevolucao_DevolucaoLivro.Value = DateTime.Now;
            _emprestimoAtual = null;
        }
    }
}