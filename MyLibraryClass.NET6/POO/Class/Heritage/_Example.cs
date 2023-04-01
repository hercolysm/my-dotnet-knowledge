using MyLibraryClass.NET6.Models;

namespace MyLibraryClass.NET6.POO.Class.Heritage
{
    public class _Example
    {
        public void Examples()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Pessoa 01";
            pessoa.Apresentar();

            PessoaFisica pessoaFisica = new();
            pessoaFisica.Nome = "Pessoa Fisica 01";
            pessoaFisica.Cpf = "12345678901";
            pessoaFisica.Apresentar();

            PesssoaJuridica pesssoaJuridica = new();
            pesssoaJuridica.Nome = "Pessoa Juridica 01";
            pesssoaJuridica.Cnpj = "12345678901234";
            pesssoaJuridica.Apresentar();

            // Herdando o construtor 
            PessoaFisica pessoaFisica2 = new PessoaFisica("Bejamin", 12);
            pessoaFisica2.Apresentar();
        }
    }
}