using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Pim3_2025.Models;

namespace Pim3_2025.TelasDeBibliotecario
{
    public partial class UcClientesCadastrados : UserControl
    {
        public UcClientesCadastrados()
        {
            InitializeComponent();
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            try
            {
                // Limpa o DataGridView
                dtgrClientesCadastrados.Rows.Clear();

                // Filtra apenas os usuários com perfil de Cliente (ID = 1)
                var clientes = BancoDados.usuarios
                    .Where(u => u.PerfilId == 1)
                    .OrderBy(u => u.Nome)
                    .ToList();

                // Adiciona cada cliente ao DataGridView
                foreach (var cliente in clientes)
                {
                    dtgrClientesCadastrados.Rows.Add(
                        cliente.Id,
                        cliente.Nome,
                        FormatCpf(cliente.Cpf),                        
                        FormatTelefone(cliente.Telefone),
                        cliente.Login // Usando o Login como e-mail (ou pode adicionar propriedade Email separada)
                    );
                }

                // Configurações adicionais do DataGridView
                dtgrClientesCadastrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgrClientesCadastrados.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
                dtgrClientesCadastrados.EnableHeadersVisualStyles = false;
                dtgrClientesCadastrados.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatCpf(string cpf)
        {
            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
                return cpf;

            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
        }

        private string FormatTelefone(string telefone)
        {
            if (string.IsNullOrEmpty(telefone))
                return telefone;

            telefone = new string(telefone.Where(char.IsDigit).ToArray());

            if (telefone.Length == 11)
                return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)}-{telefone.Substring(7, 4)}";
            else if (telefone.Length == 10)
                return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 4)}-{telefone.Substring(6, 4)}";
            else
                return telefone;
        }

        // Método para atualizar a lista quando novos clientes são adicionados
        public void AtualizarListaClientes()
        {
            CarregarClientes();
        }
    }
}