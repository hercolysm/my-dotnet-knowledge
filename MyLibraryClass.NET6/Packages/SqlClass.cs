using Microsoft.Data.SqlClient;

namespace MyLibraryClass.NET6.Examples.Packages
{
    public class SqlClass
    {
        public void InstallPackage()
        {
            Console.WriteLine("Run command: dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.4");
        }
        
        public void TestarConexao()
        {
            var ConnectionString = "Server=localhost; Initial Catalog=Agenda; Integrated Security=True; TrustServerCertificate=True";

            using (SqlConnection conexao = new SqlConnection(ConnectionString))
            {
                conexao.Open();
                Console.WriteLine("Conexão realizada com sucesso!");
                conexao.Close();
            }
        }
    }
}