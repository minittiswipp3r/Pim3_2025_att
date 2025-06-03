using System;
using System.Windows.Forms;
using Pim3_2025.Models;
using Pim3_2025.TelasDeBibliotecario;
using Pim3_2025.TelasDeUsuario;
using Pim3_2025.Telas_De_Administrador;

namespace Pim3_2025
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ConfigurarEventos();
            this.StartPosition = FormStartPosition.CenterScreen; // Centraliza o formulário
        }

        private void ConfigurarEventos()
        {
            // Evento para cadastro novo
            lblClickaAquiLogin.Click += (sender, e) => {
                var formCadastro = new Cadastro(BancoDados.usuarios, BancoDados.perfis);
                if (formCadastro.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cadastro realizado com sucesso! Faça login.", "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            // Evento para pressionar Enter no campo senha
            txbSenhaLogin.KeyPress += (sender, e) => {
                if (e.KeyChar == (char)Keys.Enter)
                    btnLogin.PerformClick();
            };            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txbUsuarioLogin.Text.Trim();
                string senha = txbSenhaLogin.Text;

                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
                {
                    MessageBox.Show("Por favor, preencha todos os campos!", "Aviso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Busca o usuário pelo login (case insensitive)
                Usuario usuario = BancoDados.usuarios.Find(u =>
                    u.Login.Equals(login, StringComparison.OrdinalIgnoreCase));

                if (usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado!", "Erro de Login",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verifica se o usuário está suspenso
                if (usuario.EstaSuspenso(DateTime.Now))
                {
                    MessageBox.Show($"Usuário suspenso até {usuario.DataSuspensao.Value.ToShortDateString()}!",
                                  "Acesso Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // Verifica a senha com hash
                string senhaHash = BancoDados.HashPassword(senha);
                if (usuario.Senha != senhaHash)
                {
                    MessageBox.Show("Senha incorreta!", "Erro de Login",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtém o perfil do usuário
                Perfil perfil = BancoDados.perfis.Find(p => p.Id == usuario.PerfilId);
                if (perfil == null)
                {
                    MessageBox.Show("Perfil não configurado para este usuário!", "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Redireciona conforme o perfil
                RedirecionarPorPerfil(perfil.Nome, usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro durante o login: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RedirecionarPorPerfil(string perfil, Usuario usuario)
        {
            try
            {
                // Fecha o formulário de login antes de abrir o novo
                this.Hide();

                // Cria o formulário de destino baseado no perfil
                Form formDestino = perfil.ToUpper() switch
                {
                    "CLIENTE" => new TelaUsuarioPrincipal(usuario),
                    "BIBLIOTECARIO" => new TelaBibliotecarioPrincipal(usuario),
                    "ADMINISTRADOR" => new TelaAdminPrincipal(usuario),
                    _ => throw new Exception("Perfil não reconhecido!")
                };

                // Configura o evento para fechar a aplicação quando o form principal for fechado
                formDestino.FormClosed += (s, args) => Application.Exit();

                // Mostra o formulário principal
                formDestino.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao redirecionar: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Se ocorrer erro, mostra novamente o login
                this.Show();
            }
        }
    }
}