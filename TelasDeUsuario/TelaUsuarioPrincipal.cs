using Pim3_2025.Models;
using Pim3_2025.TelasDeUsuario;

namespace Pim3_2025.TelasDeUsuario
{
    public partial class TelaUsuarioPrincipal : Form
    {
        private readonly Usuario _usuarioLogado;

        public TelaUsuarioPrincipal(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogado = usuario;
        }

        private void TelaUsuarioPrincipal_Load(object sender, EventArgs e)
        {
            // Código de carregamento inicial, se necessário
        }

        private void pnlPrincipalUsuario_Paint(object sender, PaintEventArgs e)
        {
            // Código de pintura do painel, se necessário
        }

        private void lblTelaBuscaUser_Click(object sender, EventArgs e)
        {
            UcBuscaUsuario ucBuscaUsuario = new UcBuscaUsuario();
            pnlPrincipalUsuario.Controls.Clear();
            pnlPrincipalUsuario.Controls.Add(ucBuscaUsuario);
        }

        private void lblLivrosFamososUser_Click(object sender, EventArgs e)
        {
            UcLivrosFamosos ucLivrosFamosos = new UcLivrosFamosos();
            pnlPrincipalUsuario.Controls.Clear();
            pnlPrincipalUsuario.Controls.Add(ucLivrosFamosos);
        }

        private void lblNotificasoesUser_Click(object sender, EventArgs e)
        {
            UcNotificacoes ucNotificacoes = new UcNotificacoes();
            pnlPrincipalUsuario.Controls.Clear();
            pnlPrincipalUsuario.Controls.Add(ucNotificacoes);
        }

        private void lblFaqUser_Click(object sender, EventArgs e)
        {
            UcFAQ ucFAQ = new UcFAQ();
            pnlPrincipalUsuario.Controls.Clear();
            pnlPrincipalUsuario.Controls.Add(ucFAQ);
        }

        private void btnSairUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDadosPessoalUser_Click(object sender, EventArgs e)
        {
            // Corrigido: Passando o usuário logado para o UserControl
            UcDadosPessoal ucDadosPessoal = new UcDadosPessoal(_usuarioLogado);
            pnlPrincipalUsuario.Controls.Clear();
            pnlPrincipalUsuario.Controls.Add(ucDadosPessoal);
        }

        private void lblHistoricoEmprestimoUser_Click(object sender, EventArgs e)
        {
            // Se precisar do usuário, passe também para o histórico
            UcHistorecoEmprestimo ucHistorecoEmprestimo = new UcHistorecoEmprestimo(_usuarioLogado);
            pnlPrincipalUsuario.Controls.Clear();
            pnlPrincipalUsuario.Controls.Add(ucHistorecoEmprestimo);
        }

        private void lblRegrasUser_Click(object sender, EventArgs e)
        {
            UcRegrasEmprestimo ucRegrasEmprestimo = new UcRegrasEmprestimo();
            pnlPrincipalUsuario.Controls.Clear();
            pnlPrincipalUsuario.Controls.Add(ucRegrasEmprestimo);
        }

        private void lblDesconectar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}