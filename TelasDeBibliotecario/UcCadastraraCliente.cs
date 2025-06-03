using System;
using System.Windows.Forms;
using Pim3_2025.Models;

namespace Pim3_2025.TelasDeBibliotecario
{
    public partial class UcCadastraraCliente : UserControl
    {
        public UcCadastraraCliente()
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

        private void ValidarTelefone(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void ValidarCPF(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '.' && e.KeyChar != '-')
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

                // Obter o próximo ID disponível
                int novoId = BancoDados.usuarios.Count > 0 ?
                           BancoDados.usuarios.Max(u => u.Id) + 1 : 1;

                // Criar novo usuário (cliente)
                Usuario novoCliente = new Usuario(
                    id: novoId,
                    nome: txbNomeCliente_CadastroCliente.Text.Trim(),
                    cpf: txbCpf_CadastroCliente.Text.Trim(),
                    login: GerarLogin(txbNomeCliente_CadastroCliente.Text),
                    senha: BancoDados.HashPassword(txbSenha_CadastroCliente.Text),
                    perfilId: 1, // ID do perfil Cliente
                    telefone: txbTelefone_CadastroCliente.Text.Trim(),
                    codigoFuncionarioResponsavel: txbCodFuncionario_CadastroCliente.Text.Trim(),
                    dataCadastro: dttmDataCadastro_CadastroCliente.Value
                );

                // Adicionar à lista de usuários
                BancoDados.usuarios.Add(novoCliente);

                MessageBox.Show("Cliente cadastrado com sucesso!\n" +
                               $"Login: {novoCliente.Login}\n" +
                               "Senha: a senha informada no cadastro",
                               "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar cliente: {ex.Message}",
                              "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GerarLogin(string nome)
        {
            // Gera um login baseado no nome (ex: "João Silva" -> "joao.silva")
            string login = nome.ToLower().Replace(" ", ".");

            // Verifica se o login já existe e adiciona número se necessário
            int count = 1;
            string loginOriginal = login;
            while (BancoDados.usuarios.Any(u => u.Login.Equals(login, StringComparison.OrdinalIgnoreCase)))
            {
                login = $"{loginOriginal}{count++}";
            }

            return login;
        }

        private bool ValidarCampos()
        {
            // Validação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(txbCodFuncionario_CadastroCliente.Text) ||
                string.IsNullOrWhiteSpace(txbNomeCliente_CadastroCliente.Text) ||
                string.IsNullOrWhiteSpace(txbCpf_CadastroCliente.Text) ||
                string.IsNullOrWhiteSpace(txbTelefone_CadastroCliente.Text) ||
                string.IsNullOrWhiteSpace(txbSenha_CadastroCliente.Text) ||
                string.IsNullOrWhiteSpace(txbConfSenha_CadastroCliente.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios!",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validação da senha
            if (txbSenha_CadastroCliente.Text != txbConfSenha_CadastroCliente.Text)
            {
                MessageBox.Show("As senhas não coincidem!",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validação do CPF
            string cpfLimpo = txbCpf_CadastroCliente.Text.Replace(".", "").Replace("-", "");
            if (cpfLimpo.Length != 11 || !long.TryParse(cpfLimpo, out _))
            {
                MessageBox.Show("CPF inválido! Deve conter 11 dígitos.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica se CPF já está cadastrado
            if (BancoDados.usuarios.Any(u => u.Cpf == txbCpf_CadastroCliente.Text.Trim()))
            {
                MessageBox.Show("CPF já cadastrado no sistema!",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                    textBox.Clear();
            }
            dttmDataCadastro_CadastroCliente.Value = DateTime.Today;
            txbCodFuncionario_CadastroCliente.Focus();
        }
    }
}