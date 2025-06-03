using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Pim3_2025.Models;

namespace Pim3_2025
{
    public static class BancoDados
    {
        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Perfil> perfis = new List<Perfil>();
        public static List<Livro> livrosExistentes = new List<Livro>();
        public static List<Emprestimo> emprestimos = new List<Emprestimo>();

        public static void CarregarDadosMock()
        {
            // Carrega perfis
            perfis.Add(new Perfil(1, "Cliente"));
            perfis.Add(new Perfil(2, "Bibliotecario"));
            perfis.Add(new Perfil(3, "Administrador"));

            // Carrega usuários de teste
            usuarios.Add(new Usuario(
                id: 1,
                nome: "Cliente Teste",
                cpf: "11122233344",
                login: "cliente",
                senha: HashPassword("123"),
                perfilId: 1,
                telefone: "15997507987",
                codigoFuncionarioResponsavel: null,
                dataCadastro: new DateTime(2023, 1, 1)
            ));

            usuarios.Add(new Usuario(
                id: 2,
                nome: "Bibliotecário Teste",
                cpf: "22233344455",
                login: "bibliotecario",
                senha: HashPassword("123"),
                perfilId: 2,
                telefone: "15997702937",
                codigoFuncionarioResponsavel: "BIB001",
                dataCadastro: new DateTime(2023, 1, 1)
            ));

            usuarios.Add(new Usuario(
                id: 3,
                nome: "Admin Teste",
                cpf: "33344455566",
                login: "admin",
                senha: HashPassword("admin"),
                perfilId: 3,
                telefone: "15997401987",
                codigoFuncionarioResponsavel: "ADM001",
                dataCadastro: new DateTime(2023, 1, 1)
            ));

            // Carrega livros de teste com IDs
            livrosExistentes = new List<Livro>
            {
                new Livro {
                    Id = 1,
                    CodigoFuncionario = "001",
                    Titulo = "Dom Casmurro",
                    AnoPublicacao = 1899,
                    Autor = "Machado de Assis",
                    Genero = "Romance",
                    Editora = "Livraria Garnier",
                    Status = "Disponível",
                    DataCadastro = new DateTime(2023, 1, 15)
                },
                new Livro {
                    Id = 2,
                    CodigoFuncionario = "001",
                    Titulo = "O Senhor dos Anéis: A Sociedade do Anel",
                    AnoPublicacao = 1954,
                    Autor = "J.R.R. Tolkien",
                    Genero = "Fantasia",
                    Editora = "Martins Fontes",
                    Status = "Emprestado",
                    DataCadastro = new DateTime(2023, 2, 20)
                },
                new Livro {
                    Id = 3,
                    CodigoFuncionario = "003",
                    Titulo = "1984",
                    AnoPublicacao = 1949,
                    Autor = "George Orwell",
                    Genero = "Ficção Distópica",
                    Editora = "Companhia Editora Nacional",
                    Status = "Disponível",
                    DataCadastro = new DateTime(2023, 3, 10)
                },
                new Livro {
                    Id = 4,
                    CodigoFuncionario = "001",
                    Titulo = "Cem Anos de Solidão",
                    AnoPublicacao = 1967,
                    Autor = "Gabriel García Márquez",
                    Genero = "Realismo Mágico",
                    Editora = "Editora Record",
                    Status = "Disponível",
                    DataCadastro = new DateTime(2023, 4, 5)
                },
                new Livro {
                    Id = 5,
                    CodigoFuncionario = "001",
                    Titulo = "O Pequeno Príncipe",
                    AnoPublicacao = 1943,
                    Autor = "Antoine de Saint-Exupéry",
                    Genero = "Literatura Infantil",
                    Editora = "Agir",
                    Status = "Emprestado",
                    DataCadastro = new DateTime(2023, 5, 12)
                }
            };

            // Carrega empréstimos de teste
            emprestimos = new List<Emprestimo>
            {
                new Emprestimo {
                    Id = 1,
                    IdLivro = 2, // O Senhor dos Anéis
                    IdCliente = 1, // Cliente Teste
                    CodigoFuncionario = "BIB001",
                    DataEmprestimo = new DateTime(2023, 6, 1),
                    DataPrevistaDevolucao = new DateTime(2023, 6, 15),
                    DataDevolucao = null,
                    Devolvido = false
                },
                new Emprestimo {
                    Id = 2,
                    IdLivro = 5, // O Pequeno Príncipe
                    IdCliente = 1, // Cliente Teste
                    CodigoFuncionario = "BIB001",
                    DataEmprestimo = new DateTime(2023, 6, 5),
                    DataPrevistaDevolucao = new DateTime(2023, 6, 19),
                    DataDevolucao = null,
                    Devolvido = false
                }
            };
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static int ProximoIdEmprestimo()
        {
            return emprestimos.Count > 0 ? emprestimos.Max(e => e.Id) + 1 : 1;
        }

        public static int ProximoIdLivro()
        {
            return livrosExistentes.Count > 0 ? livrosExistentes.Max(l => l.Id) + 1 : 1;
        }

        // Novo método para verificar se cliente pode emprestar
        public static bool ClientePodeEmprestar(int clienteId, DateTime? dataemprestimo = null)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == clienteId);
            return usuario != null && !usuario.EstaSuspenso(dataemprestimo ?? DateTime.Now);
        }

        // Novo método para suspender cliente
        public static void SuspenderCliente(int clienteId, int dias)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == clienteId);
            if (usuario != null)
            {
                usuario.DataSuspensao = DateTime.Now.AddDays(dias);
            }
        }
    }
}