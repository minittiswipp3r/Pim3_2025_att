using System;
using System.Windows.Forms;
using Pim3_2025.Models;

namespace Pim3_2025.TelasDeUsuario
{
    public partial class UcDadosPessoal : UserControl
    {
        private Usuario usuarioLogado;
        private bool senhaVisivel = false;

        public UcDadosPessoal(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            CarregarDadosUsuario();
        }       

        private void CarregarDadosUsuario()
        {
            try
            {
                lblIDDadosPessoal.Text = $"ID: {usuarioLogado.Id}";
                lblNomeCompletoDadosPessoal.Text = usuarioLogado.Nome;
                lblCpfDadosPessoal.Text = FormatCpf(usuarioLogado.Cpf);
                lblEmailDadosPessoal.Text = usuarioLogado.Login + "@biblioteca.com"; // Exemplo
                lblTelefoneDadosPessoal.Text = FormatTelefone(usuarioLogado.Telefone);
                lblSenhaDadosPessoal.Text = "•••••"; // Senha oculta inicialmente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados do usuário: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatCpf(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        private string FormatTelefone(string telefone)
        {
            if (telefone.Length == 11)
                return long.Parse(telefone).ToString(@"(00) 00000-0000");
            else
                return long.Parse(telefone).ToString(@"(00) 0000-0000");
        }        
    }
}