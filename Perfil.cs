namespace Pim3_2025
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Perfil(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}