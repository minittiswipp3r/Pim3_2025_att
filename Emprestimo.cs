namespace Pim3_2025.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int IdLivro { get; set; }
        public int IdCliente { get; set; }
        public string CodigoFuncionario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime? DataDevolucao { get; set; } // Nullable para quando não devolvido
        public bool Devolvido { get; set; }
    }
}