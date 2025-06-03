namespace Pim3_2025.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int PerfilId { get; set; }
        public string Telefone { get; set; }
        public string CodigoFuncionarioResponsavel { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataSuspensao { get; set; }

        public Usuario(int id, string nome, string cpf, string login, string senha,
                      int perfilId, string telefone, string codigoFuncionarioResponsavel = null,
                      DateTime? dataCadastro = null)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Login = login;
            Senha = senha;
            PerfilId = perfilId;
            Telefone = telefone;
            CodigoFuncionarioResponsavel = codigoFuncionarioResponsavel;
            DataCadastro = dataCadastro ?? DateTime.Now;
            DataSuspensao = null;
        }

        public bool EstaSuspenso(DateTime dataverificar)
        {
            return DataSuspensao.HasValue && DataSuspensao.Value > dataverificar;
        }
    }
}