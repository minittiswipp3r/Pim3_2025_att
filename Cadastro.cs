using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Pim3_2025.Models;

namespace Pim3_2025
{
    public partial class Cadastro : Form
    {
        public Cadastro (List<Usuario> usuarios, List<Perfil> perfis)
        {
            InitializeComponent();
            ConfigurarEventos();            
        }        

        private void ConfigurarEventos()
        {
            btnCadastrar.Click += BtnCadastrar_Click;
            lblClickAquiCadastro.Click += (sender, e) => this.Close();

            // Validações de entrada
            txbCpfCadastro.KeyPress += ValidarCPF;
            txbTelefoneCadastro.KeyPress += ValidarTelefone;            
        }

        private void ValidarApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void ValidarTelefone(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '-' && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void ValidarCPF(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '.' && e.KeyChar != '-')
                e.Handled = true;
        }
        

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                // Obter o próximo ID disponível
                int novoId = BancoDados.usuarios.Count > 0 ?
                           BancoDados.usuarios.Max(u => u.Id) + 1 : 1;

                // Obter ID do perfil Cliente
                int idPerfilCliente = BancoDados.perfis.First(p => p.Nome.Equals("Cliente")).Id;

                // Criar novo usuário
                Usuario novoUsuario = new Usuario(
                    id: novoId,
                    nome: txbNomeCadastro.Text.Trim(),
                    cpf: txbCpfCadastro.Text.Trim(),
                    login: txbEmailCadstro.Text.Trim().ToLower(),
                    senha: BancoDados.HashPassword(txbSenha1Cadastro.Text),
                    perfilId: idPerfilCliente,
                    telefone: txbTelefoneCadastro.Text.Trim()
                    
                );

                // Adicionar ao banco de dados
                BancoDados.usuarios.Add(novoUsuario);

                MessageBox.Show("Cadastro realizado com sucesso!\n" +
                              $"Login: {novoUsuario.Login}",
                              "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar: {ex.Message}",
                              "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            // Validação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(txbNomeCadastro.Text) ||
                string.IsNullOrWhiteSpace(txbCpfCadastro.Text) ||
                string.IsNullOrWhiteSpace(txbEmailCadstro.Text) ||
                string.IsNullOrWhiteSpace(txbTelefoneCadastro.Text) ||
                string.IsNullOrWhiteSpace(txbSenha1Cadastro.Text) ||
                string.IsNullOrWhiteSpace(txbSenha2Cadastro.Text))
                
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios!",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validação do telefone
            string telefoneLimpo = txbTelefoneCadastro.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if (telefoneLimpo.Length < 10 || telefoneLimpo.Length > 11 || !long.TryParse(telefoneLimpo, out _))
            {
                MessageBox.Show("Telefone inválido! Deve conter 10 ou 11 dígitos (com DDD).",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validação do email
            if (!ValidarEmail(txbEmailCadstro.Text))
            {
                MessageBox.Show("Por favor, insira um email válido!",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validação da senha
            if (txbSenha1Cadastro.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres!",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txbSenha1Cadastro.Text != txbSenha2Cadastro.Text)
            {
                MessageBox.Show("As senhas não coincidem!",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validação do CPF
            string cpfLimpo = txbCpfCadastro.Text.Replace(".", "").Replace("-", "");
            if (cpfLimpo.Length != 11 || !long.TryParse(cpfLimpo, out _))
            {
                MessageBox.Show("CPF inválido! Deve conter 11 dígitos.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica se CPF já está cadastrado
            if (BancoDados.usuarios.Any(u => u.Cpf == cpfLimpo))
            {
                MessageBox.Show("CPF já cadastrado no sistema!",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica se email já está cadastrado
            if (BancoDados.usuarios.Any(u => u.Login.Equals(txbEmailCadstro.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Email já cadastrado como login!",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
