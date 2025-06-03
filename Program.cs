using Pim3_2025.Models;

namespace Pim3_2025
{
    internal static class Program    {
       

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Carrega os dados mockados antes de iniciar a aplicação
            BancoDados.CarregarDadosMock();

            Application.Run(new Login());
        }      
       
    }
}