using Pim3_2025.TelasDeBibliotecario;

namespace Pim3_2025.Telas_De_Administrador
{
    public partial class TelaAdminPrincipal : Form
    {
        public TelaAdminPrincipal(Models.Usuario usuario)
        {
            InitializeComponent();
        }

        private void lblBiblioteca_Click(object sender, EventArgs e)
        {
            UcBibliotecaBibliotecario ucBibliotecaBibliotecario = new UcBibliotecaBibliotecario();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucBibliotecaBibliotecario);
        }

        private void lblCadastroLivros_TelaAdm_Click(object sender, EventArgs e)
        {
            UcCadastrarLivros ucCadastro = new UcCadastrarLivros();

            // Configurar o UserControl para preencher o painel
            ucCadastro.Dock = DockStyle.Fill;

            UcCadastrarLivros UcCadastrarLivros = new UcCadastrarLivros();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(UcCadastrarLivros);
        }      

        private void lblCadastroCliente_TelaAdm_Click_1(object sender, EventArgs e)
        {
            UcCadastraraCliente ucCadastraraCliente = new UcCadastraraCliente();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucCadastraraCliente);
        }

        private void lblEmprestimo_TelaAdm_Click(object sender, EventArgs e)
        {
            UcEmprestado ucEmprestado = new UcEmprestado();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucEmprestado);
        }

        private void lblDevolucao_TelaAdm_Click(object sender, EventArgs e)
        {
            UcDevolucao ucDevolucao = new UcDevolucao();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucDevolucao);
        }

        private void lblEstoque_TelaAdm_Click(object sender, EventArgs e)
        {
            UcEstoqueBibliotecario ucEstoqueBibliotecario = new UcEstoqueBibliotecario();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucEstoqueBibliotecario);
        }

        private void btnSair_TelaAdm_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }      

        private void lblLivrosEmprestadosAdm_Click(object sender, EventArgs e)
        {
            UcLivros_Emprestados ucLivros_Emprestados = new UcLivros_Emprestados();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucLivros_Emprestados);
        }

        private void lblClientesCadastradosAdm_Click(object sender, EventArgs e)
        {
            UcClientesCadastrados ucClientesCadastrados = new UcClientesCadastrados();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucClientesCadastrados);
        }

        private void lblLivrosCadastradosAdm_Click(object sender, EventArgs e)
        {
            UcLivrosCadastrados ucLivros = new UcLivrosCadastrados(BancoDados.livrosExistentes);

            ucLivros.Dock = DockStyle.Fill;

            UcLivrosCadastrados ucLivrosCadastrados = new UcLivrosCadastrados(BancoDados.livrosExistentes);
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(ucLivrosCadastrados);
        }

        private void lblSuspenderRetomarClienteAdm_Click(object sender, EventArgs e)
        {
            UcSuspenderRetomarClienteAdm UcSuspenderRetomarClienteAdm = new UcSuspenderRetomarClienteAdm();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(UcSuspenderRetomarClienteAdm);
        }

        private void lblSuspenderRetomarLivrosAdm_Click(object sender, EventArgs e)
        {
            UcSuspenderRetomarLivrosAdm UcSuspenderRetomarLivrosAdm = new UcSuspenderRetomarLivrosAdm();
            pnlPrincipalAdm.Controls.Clear();
            pnlPrincipalAdm.Controls.Add(UcSuspenderRetomarLivrosAdm);
        }

        private void lblDesconectarAdm_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

