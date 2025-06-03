using Pim3_2025.Models;

namespace Pim3_2025.TelasDeBibliotecario
{
    public partial class TelaBibliotecarioPrincipal : Form
    {
        private List<Livro> listaLivros;
        public TelaBibliotecarioPrincipal(Usuario usuario)
        {
            InitializeComponent();
            listaLivros = new List<Livro>();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UcBibliotecaBibliotecario ucBibliotecaBibliotecario = new UcBibliotecaBibliotecario();
            pnlPrincipal_Bibliotecario.Controls.Clear();
            pnlPrincipal_Bibliotecario.Controls.Add(ucBibliotecaBibliotecario);
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblCadastroCliente_TelaBibliotecario_Click(object sender, EventArgs e)
        {
            UcCadastraraCliente ucCadastraraCliente = new UcCadastraraCliente();
            pnlPrincipal_Bibliotecario.Controls.Clear();
            pnlPrincipal_Bibliotecario.Controls.Add(ucCadastraraCliente);
        }

        private void lblCadastroLivros_TelaBibliotecario_Click(object sender, EventArgs e)
        {
            UcCadastrarLivros ucCadastro = new UcCadastrarLivros();            

            // Configurar o UserControl para preencher o painel
            ucCadastro.Dock = DockStyle.Fill;

            UcCadastrarLivros UcCadastrarLivros = new UcCadastrarLivros();
            pnlPrincipal_Bibliotecario.Controls.Clear();
            pnlPrincipal_Bibliotecario.Controls.Add(UcCadastrarLivros);
        }

        private void lblEmprestimo_TelaBibliotecario_Click(object sender, EventArgs e)
        {
            UcEmprestado ucEmprestado = new UcEmprestado();
            pnlPrincipal_Bibliotecario.Controls.Clear();
            pnlPrincipal_Bibliotecario.Controls.Add(ucEmprestado);
        }

        private void lblDevolucao_TelaBibliotecario_Click(object sender, EventArgs e)
        {
            UcDevolucao ucDevolucao = new UcDevolucao();
            pnlPrincipal_Bibliotecario.Controls.Clear();
            pnlPrincipal_Bibliotecario.Controls.Add(ucDevolucao);
        }

        private void lblEstoque_TelaBibliotecario_Click(object sender, EventArgs e)
        {
            UcEstoqueBibliotecario ucEstoqueBibliotecario = new UcEstoqueBibliotecario();
            pnlPrincipal_Bibliotecario.Controls.Clear();
            pnlPrincipal_Bibliotecario.Controls.Add(ucEstoqueBibliotecario);
        }

        private void btnSair_TelaBibliotecario_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void lblClientesCadastrados_Click(object sender, EventArgs e)
        {
            UcClientesCadastrados ucClientesCadastrados = new UcClientesCadastrados();
            pnlPrincipal_Bibliotecario.Controls.Clear();
            pnlPrincipal_Bibliotecario.Controls.Add(ucClientesCadastrados);
        }

        private void lblLivrosCadastrados_Click(object sender, EventArgs e)
        {
            UcLivrosCadastrados ucLivros = new UcLivrosCadastrados(BancoDados.livrosExistentes);

            ucLivros.Dock = DockStyle.Fill;

            UcLivrosCadastrados ucLivrosCadastrados = new UcLivrosCadastrados(BancoDados.livrosExistentes);
            pnlPrincipal_Bibliotecario.Controls.Clear();
            pnlPrincipal_Bibliotecario.Controls.Add(ucLivrosCadastrados);
        }

        private void lblSuspenderRetomarCliente_Click(object sender, EventArgs e)
        {
            UcLivros_Emprestados ucLivros_Emprestados = new UcLivros_Emprestados();
            pnlPrincipal_Bibliotecario.Controls.Clear();
            pnlPrincipal_Bibliotecario.Controls.Add(ucLivros_Emprestados);
        }

        private void lblDesconectarBibliotecario_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
