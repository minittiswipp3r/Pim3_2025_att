namespace Pim3_2025.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string CodigoFuncionario { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Editora { get; set; }
        public string Status { get; set; } = "Disponível"; // Valor padrão
        public DateTime DataCadastro { get; set; } = DateTime.Now; // Valor padrão

        // Construtor vazio para serialização
        public Livro() { }
    }
}